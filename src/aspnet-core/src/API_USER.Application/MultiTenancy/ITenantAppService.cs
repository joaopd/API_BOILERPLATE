using Abp.Application.Services;
using API_USER.MultiTenancy.Dto;

namespace API_USER.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

