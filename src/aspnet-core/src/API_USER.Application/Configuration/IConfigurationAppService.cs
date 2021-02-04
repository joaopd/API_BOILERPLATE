using System.Threading.Tasks;
using API_USER.Configuration.Dto;

namespace API_USER.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
