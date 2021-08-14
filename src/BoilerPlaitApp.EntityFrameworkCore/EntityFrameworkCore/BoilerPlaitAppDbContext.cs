using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BoilerPlaitApp.Authorization.Roles;
using BoilerPlaitApp.Authorization.Users;
using BoilerPlaitApp.MultiTenancy;

namespace BoilerPlaitApp.EntityFrameworkCore
{
    public class BoilerPlaitAppDbContext : AbpZeroDbContext<Tenant, Role, User, BoilerPlaitAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BoilerPlaitAppDbContext(DbContextOptions<BoilerPlaitAppDbContext> options)
            : base(options)
        {
        }
    }
}
