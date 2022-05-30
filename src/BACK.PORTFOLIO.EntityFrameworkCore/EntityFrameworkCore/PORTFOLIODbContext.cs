using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BACK.PORTFOLIO.Authorization.Roles;
using BACK.PORTFOLIO.Authorization.Users;
using BACK.PORTFOLIO.MultiTenancy;
using Abp.Localization;

namespace BACK.PORTFOLIO.EntityFrameworkCore
{
    public class PORTFOLIODbContext : AbpZeroDbContext<Tenant, Role, User, PORTFOLIODbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PORTFOLIODbContext(DbContextOptions<PORTFOLIODbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
