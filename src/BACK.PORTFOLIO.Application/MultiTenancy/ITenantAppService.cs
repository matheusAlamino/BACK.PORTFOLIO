using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BACK.PORTFOLIO.MultiTenancy.Dto;

namespace BACK.PORTFOLIO.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

