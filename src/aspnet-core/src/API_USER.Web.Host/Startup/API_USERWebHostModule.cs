using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using API_USER.Configuration;

namespace API_USER.Web.Host.Startup
{
    [DependsOn(
       typeof(API_USERWebCoreModule))]
    public class API_USERWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public API_USERWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(API_USERWebHostModule).GetAssembly());
        }
    }
}
