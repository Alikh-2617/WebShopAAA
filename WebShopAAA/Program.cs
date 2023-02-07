using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Text;
using WebShopAAA.DataDB;
using WebShopAAA.Middlewares;
using WebShopAAA.Models.ApplicationUserModel;
using WebShopAAA.Models.Seeding;
using WebShopAAA.Repository.Implementation;
using WebShopAAA.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

//-------------------------------------------------------------------------------Adding Session och coockes
builder.Services.AddMvc();
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(15); });

//------------------------------------------------------------------------------DB Connection injection and Identity BD 
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


//-----------------------------------------------------------------------------
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(options =>
//    {
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            ValidateIssuer= true,
//            ValidateAudience= true,
//            ValidateLifetime= true,
//            ValidateIssuerSigningKey= true,
//            ValidIssuer = builder.Configuration["Authentication:Issuer"],
//            ValidAudience = builder.Configuration["Authentication:Audience"],
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Authentication:SecretForKey"]))
//        };
//    });

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(options =>
//{
//    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//    {
//        Description = "JWT Authorization",
//        Name = "Authorization",
//        In = ParameterLocation.Header,
//        Type = SecuritySchemeType.ApiKey,
//        Scheme = "Bearer"
//    });
//    options.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme
//            {
//            Reference = new OpenApiReference
//            {
//                Type = ReferenceType.SecurityScheme,
//                Id = "Bearer"
//            }
//            },
//            new string[]{}
//        }
//    });
//builder.Services.AddSwaggerGen();
//});

// DB connection för Identity ( vi kan låta när scafola den , skriver den själva) 
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddCors(p => p.AddPolicy("restPolicy", builder =>
{
    builder.WithOrigins("*")
    .AllowAnyMethod()
    .AllowAnyHeader();
}));


//--------------------------------------------------------------------------------Scoping och injection 
// här kan vi skapa Scop i våra 
//  builder.Services.AddScoped < interface , class >();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderRepository , OrderRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IOrderItemsRepository , OrderItemsRepository>(); 
builder.Services.AddScoped<IPaymentRepository , PaymentRepository>();

//--------------------------------------------------------------------------------eller vi kan skapa nån typ av meddleware inna run app builder (angående filtera IP) ?? 



//--------------------------------------------------------------------------------React Connection och access till nån VIEW 
builder.Services.AddCors( x => x.AddPolicy( "corsPolicy", 
    builder => { 
        builder.WithOrigins("*").  // Alla är välkomna :) 
        AllowAnyMethod().
        AllowAnyHeader();
    }));

//-----------------------------
var app = builder.Build();


//---------------------------------------------------------------------------------Seeding som injection till databasen 
// we can seeding directing from DB Conext when is creating too . 
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
    //DbInitializer.Seed(app);
}
//-----------------------------------------------------------------------------Error handel i Dev enviroment miljo och navigation 
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


//------------------------------------------------------------------------------ create and handel meddlewar ( vi kan skapa meddlewarClass för dem )

app.UseMService();  // we can remove it if we did not use this meddleware !! 


//----------------------------------------------------------------------------- 

app.UseSession();   
app.UseHttpsRedirection();  // redirect to https protecol 
app.UseStaticFiles();       // static files in wwwRoot file 
app.UseRouting();
app.UseCors("corsPolicy");

//--------------------------------------------------------------------------bör läggas till Authenticatin Use efter Authentication !! 
app.UseAuthentication();   
app.UseAuthorization();

//--------------------------------------------------------------------------navigation 

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run(); // sista meddlewar till controller inna RUN !! 
