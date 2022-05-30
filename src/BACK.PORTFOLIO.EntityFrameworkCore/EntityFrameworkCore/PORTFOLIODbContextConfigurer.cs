using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BACK.PORTFOLIO.EntityFrameworkCore
{
    public static class PORTFOLIODbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PORTFOLIODbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PORTFOLIODbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
