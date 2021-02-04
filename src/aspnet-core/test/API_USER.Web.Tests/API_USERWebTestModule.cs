using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using API_USER.EntityFrameworkCore;
using API_USER.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace API_USER.Web.Tests
{
    [DependsOn(
        typeof(API_USERWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class API_USERWebTestModule : AbpModule
    {
        public API_USERWebTestModule(API_USEREntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(API_USERWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(API_USERWebMvcModule).Assembly);
        }
    }
}