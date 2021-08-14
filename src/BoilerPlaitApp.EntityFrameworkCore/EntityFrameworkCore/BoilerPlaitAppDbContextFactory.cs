using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BoilerPlaitApp.Configuration;
using BoilerPlaitApp.Web;

namespace BoilerPlaitApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BoilerPlaitAppDbContextFactory : IDesignTimeDbContextFactory<BoilerPlaitAppDbContext>
    {
        public BoilerPlaitAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BoilerPlaitAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BoilerPlaitAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BoilerPlaitAppConsts.ConnectionStringName));

            return new BoilerPlaitAppDbContext(builder.Options);
        }
    }
}
