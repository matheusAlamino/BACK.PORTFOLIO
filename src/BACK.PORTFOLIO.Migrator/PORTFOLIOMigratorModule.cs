using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BACK.PORTFOLIO.Configuration;
using BACK.PORTFOLIO.EntityFrameworkCore;
using BACK.PORTFOLIO.Migrator.DependencyInjection;

namespace BACK.PORTFOLIO.Migrator
{
    [DependsOn(typeof(PORTFOLIOEntityFrameworkModule))]
    public class PORTFOLIOMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PORTFOLIOMigratorModule(PORTFOLIOEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PORTFOLIOMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PORTFOLIOConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PORTFOLIOMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
