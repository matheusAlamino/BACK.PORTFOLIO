using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BACK.PORTFOLIO.MultiTenancy;

namespace BACK.PORTFOLIO.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
