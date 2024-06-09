using chefstock_platform.UserManagement.Domain.Model.Aggregates;

namespace chefstock_platform.UserManagement.Interfaces.ACL
{
    public interface IRoleContextFacade
    {
        Task<int> CreateRole(string roleName);
        Task<Role?> FetchRoleById(int id);
        Task<IEnumerable<Role>> FetchAllRoles();
        Task UpdateRole(int roleId,string roleName);
        Task DeleteRole(int id);
    }
}