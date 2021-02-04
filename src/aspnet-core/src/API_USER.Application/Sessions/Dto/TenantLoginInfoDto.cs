using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using API_USER.MultiTenancy;

namespace API_USER.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
