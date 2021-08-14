using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlaitApp.EntityFrameworkCore;
using BoilerPlaitApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BoilerPlaitApp.Web.Tests
{
    [DependsOn(
        typeof(BoilerPlaitAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BoilerPlaitAppWebTestModule : AbpModule
    {
        public BoilerPlaitAppWebTestModule(BoilerPlaitAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlaitAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BoilerPlaitAppWebMvcModule).Assembly);
        }
    }
}