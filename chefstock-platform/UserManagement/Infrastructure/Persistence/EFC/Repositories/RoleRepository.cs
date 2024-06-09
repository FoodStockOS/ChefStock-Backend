using chefstock_platform.UserManagement.Domain.Model.Aggregates;
using chefstock_platform.UserManagement.Domain.Repositories;
using chefstock_platform.Shared.Infrastructure.Persistence.EFC.Configuration;
using chefstock_platform.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace chefstock_platform.UserManagement.Infrastructure.Persistence.EFC.Repositories
{
    public class RoleRepository(AppDbContext context) : BaseRepository<Role>(context), IRoleRepository
    {
        public async Task<Role?> GetByIdAsync(int id)
        {
            return await Context.Set<Role>().FindAsync(id);
        }

        public async Task UpdateAsync(Role role)
        {
            Context.Set<Role>().Update(role);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var role = await Context.Set<Role>().FindAsync(id);
            if (role != null)
            {
                Context.Set<Role>().Remove(role);
                await Context.SaveChangesAsync();
            }
        }
    }
}