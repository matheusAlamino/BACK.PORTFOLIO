using System.Threading.Tasks;
using Abp.Application.Services;
using BACK.PORTFOLIO.Authorization.Accounts.Dto;

namespace BACK.PORTFOLIO.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
