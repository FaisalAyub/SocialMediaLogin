using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlaitApp.Configuration;

namespace BoilerPlaitApp.Web.Host.Startup
{
    [DependsOn(
       typeof(BoilerPlaitAppWebCoreModule))]
    public class BoilerPlaitAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerPlaitAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlaitAppWebHostModule).GetAssembly());
        }
    }
}
