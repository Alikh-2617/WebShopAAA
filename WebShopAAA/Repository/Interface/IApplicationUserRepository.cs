using WebShopAAA.Models.ApplicationUserModel;

namespace WebShopAAA.Repository.Interface
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetList();
        Task<ApplicationUser> GetById(string id);
        Task<int> Insert(ApplicationUserViewModel user);
        Task<int> Delete(string id);
        Task<int> Update(ApplicationUser user);
        Task<int> AddRoleToUser(string id , string role);
        Task<int> DeleteRoleToUser(string id , string role);
    }
}
