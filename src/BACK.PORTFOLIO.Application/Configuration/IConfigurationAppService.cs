using System.Threading.Tasks;
using BACK.PORTFOLIO.Configuration.Dto;

namespace BACK.PORTFOLIO.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
