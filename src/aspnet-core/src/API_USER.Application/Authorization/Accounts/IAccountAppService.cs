using System.Threading.Tasks;
using Abp.Application.Services;
using API_USER.Authorization.Accounts.Dto;

namespace API_USER.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
