using System.Threading.Tasks;
using Abp.Application.Services;
using BACK.PORTFOLIO.Sessions.Dto;

namespace BACK.PORTFOLIO.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
