using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BACK.PORTFOLIO.Configuration;

namespace BACK.PORTFOLIO.Web.Host.Startup
{
    [DependsOn(
       typeof(PORTFOLIOWebCoreModule))]
    public class PORTFOLIOWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PORTFOLIOWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PORTFOLIOWebHostModule).GetAssembly());
        }
    }
}
