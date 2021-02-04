using System.Threading.Tasks;
using Abp.Application.Services;
using API_USER.Sessions.Dto;

namespace API_USER.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
