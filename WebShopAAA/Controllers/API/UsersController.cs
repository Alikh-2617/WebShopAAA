using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Encodings.Web;
using System.Text;
//using WebShopAAA.Migrations;
using WebShopAAA.Models.ApplicationUserModel;
using WebShopAAA.Models.ViewModels;

namespace WebShopAAA.Controllers.API
{
    [Route("api/authentication")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;

            _roleManager = roleManager;
 
        }

        [HttpPost]
        public async Task<UserapiViewModel?> Login(LoginViewModel loginViewModel)
        {
            var user = await _userManager.FindByEmailAsync(loginViewModel.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, loginViewModel.Password))
            {
                UserapiViewModel userapi = new UserapiViewModel
                {
                    Email = user.Email,
                    Name = $"{user.FirstName} {user.LastName}",
                    Username = user.UserName,
                    Id = user.Id
                };
                return userapi;
            }
            return null;
        }

        [HttpPost]
        [Route("register")]
        public async Task<UserapiViewModel?> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
            
                var user = new ApplicationUser();
                user.UserName = registerViewModel.Email;
                user.Email= registerViewModel.Email;
                user.NormalizedUserName = registerViewModel.Email.ToUpper();
                user.NormalizedEmail = registerViewModel.Email.ToUpper(); ;
                user.FirstName = registerViewModel.FirstName;
                user.LastName = registerViewModel.LastName;
                user.Address = registerViewModel.Address;
                user.PostCode = registerViewModel.PostCode;
                user.City = registerViewModel.City;
                user.Country = registerViewModel.Country;
                user.Phonenummer = registerViewModel.Phonenummer;
                user.Modilephone = registerViewModel.Modilephone;
                user.CreateAt = DateTime.Now;

                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                    UserapiViewModel userapi = new UserapiViewModel
                    {
                        Email = user.Email,
                        Name = $"{user.FirstName} {user.LastName}",
                        Username = user.UserName,
                        FirstName= user.FirstName,
                        LastName= user.LastName,
                        Address = user.Address,
                        PostCode = user.PostCode,
                        City = user.City,
                        Country = user.Country,
                        Phonenummer = user.Phonenummer,
                        Modilephone = user.Modilephone,
                        Id = user.Id,
                    };
 
                    return userapi;
                   
                }
            }
            return null;
        }

        [HttpPost]
        [Route("edit")]
        public async Task<UserapiViewModel?> Edit(EditUserViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                //ApplicationUser user = new ApplicationUser();

                var user = await _userManager.FindByIdAsync(viewModel.Id);
                //var user = await _userManager.FindByEmailAsync(viewModel.Email);
                user.Id= viewModel.Id;
                user.Email = viewModel.Email;
                user.UserName = viewModel.Username.ToString();
                user.NormalizedUserName = viewModel.Email.ToUpper();
                user.NormalizedEmail = viewModel.Email.ToUpper(); ;
                user.FirstName = viewModel.FirstName;
                user.LastName = viewModel.LastName;
                user.Address = viewModel.Address;
                user.PostCode = viewModel.PostCode;
                user.City = viewModel.City;
                user.Country = viewModel.Country;
                user.Phonenummer = viewModel.Phonenummer;
                user.Modilephone = viewModel.Modilephone;
                user.ModifiedAt = DateTime.Now;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    UserapiViewModel userapi = new UserapiViewModel
                    {
                        Email = user.Email,
                        Name = $"{user.FirstName} {user.LastName}",
                        FirstName= viewModel.FirstName ,
                        LastName= viewModel.LastName ,
                        Address = viewModel.Address ,
                        PostCode = viewModel.PostCode ,
                        City = viewModel.City ,
                        Country = viewModel.Country ,
                        Phonenummer= viewModel.Phonenummer ,
                        Modilephone = viewModel.Modilephone ,
                        Username = user.UserName,
                        Id = user.Id
                    };

                    return userapi;

                }
            }
            return null;
        }

    }
}
