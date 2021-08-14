using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlaitApp.Authorization;

namespace BoilerPlaitApp
{
    [DependsOn(
        typeof(BoilerPlaitAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BoilerPlaitAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BoilerPlaitAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BoilerPlaitAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
