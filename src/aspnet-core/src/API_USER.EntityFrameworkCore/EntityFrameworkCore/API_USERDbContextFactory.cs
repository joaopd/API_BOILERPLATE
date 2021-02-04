using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using API_USER.Configuration;
using API_USER.Web;

namespace API_USER.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class API_USERDbContextFactory : IDesignTimeDbContextFactory<API_USERDbContext>
    {
        public API_USERDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<API_USERDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            API_USERDbContextConfigurer.Configure(builder, configuration.GetConnectionString(API_USERConsts.ConnectionStringName));

            return new API_USERDbContext(builder.Options);
        }
    }
}
