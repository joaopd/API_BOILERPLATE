using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using API_USER.Authorization;

namespace API_USER
{
    [DependsOn(
        typeof(API_USERCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class API_USERApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<API_USERAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(API_USERApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
