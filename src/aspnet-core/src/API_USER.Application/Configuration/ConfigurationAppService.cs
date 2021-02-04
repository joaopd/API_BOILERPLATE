using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using API_USER.Configuration.Dto;

namespace API_USER.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : API_USERAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
