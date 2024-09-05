using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ThreeTenant.Configuration;
using ThreeTenant.Web;

namespace ThreeTenant.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ThreeTenantDbContextFactory : IDesignTimeDbContextFactory<ThreeTenantDbContext>
    {
        public ThreeTenantDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ThreeTenantDbContext>();

            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            ThreeTenantDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ThreeTenantConsts.ConnectionStringName));

            return new ThreeTenantDbContext(builder.Options);
        }
    }
}
