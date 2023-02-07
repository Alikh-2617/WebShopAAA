using Microsoft.AspNetCore.Identity;
using WebShopAAA.Models.ApplicationUserModel;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Repository.Implementation
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        // jag tror inte vi behöver den att all, daremot vi kan har controller direckt till Add Roll till Admin om vi vill 
        private RoleManager<IdentityRole> _roleManager;  // ? 
        private UserManager<ApplicationUser> _userManager;

        public ApplicationUserRepository(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public List<ApplicationUser> GetList()
        {
            List<ApplicationUser> list = _userManager.Users.ToList();
            return list;
        }


        public async Task<ApplicationUser> GetById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null) return user;
            return null;
        }
        
        public async Task<int> Update(ApplicationUser user)
        {
            var user1 = await _userManager.FindByIdAsync(user.Id);
            if (user1 != null)
            {
                await _userManager.UpdateAsync(user);
                return 200;
            }
            return 404;
        }


        public async Task<int> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                await _userManager.DeleteAsync(user);
                return 200;
            }
            return 404;
        }

        public async Task<int> Insert(ApplicationUserViewModel user)
        {    
            ApplicationUser newUser = new ApplicationUser();
            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;
            newUser.UserName = user.Email;
            newUser.NormalizedUserName = user.Email.ToUpper();
            newUser.Email = user.Email;
            newUser.NormalizedEmail = user.Email.ToUpper();
            newUser.Address = user.Address;
            newUser.PostCode = user.PostCode;
            newUser.City = user.City;
            newUser.Country = user.Country;
            newUser.PhoneNumber = user.PhoneNumber;
            newUser.Modilephone = user.Modilephone;
            newUser.CreateAt = DateTime.Now;
            await _userManager.CreateAsync(newUser, user.PassWord);
            return 200;
        }

        public async Task<int> AddRoleToUser(string id, string role)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user != null)
            {
                await _userManager.AddToRoleAsync(user, role);
                return 200;
            }
            return 404;
        }

        public async Task<int> DeleteRoleToUser(string id, string role)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user != null)
            {
                var role1 = await _roleManager.FindByIdAsync(user.Id);
                if (!role1.Equals(role))
                {
                    await _userManager.RemoveFromRoleAsync(user, role);
                    return 200;
                }
                return 202; 
            }
            return 404;
        }
    }
}
