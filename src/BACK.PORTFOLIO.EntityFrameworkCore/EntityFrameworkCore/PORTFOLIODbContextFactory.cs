using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BACK.PORTFOLIO.Configuration;
using BACK.PORTFOLIO.Web;

namespace BACK.PORTFOLIO.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PORTFOLIODbContextFactory : IDesignTimeDbContextFactory<PORTFOLIODbContext>
    {
        public PORTFOLIODbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PORTFOLIODbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PORTFOLIODbContextConfigurer.Configure(builder, configuration.GetConnectionString(PORTFOLIOConsts.ConnectionStringName));

            return new PORTFOLIODbContext(builder.Options);
        }
    }
}
