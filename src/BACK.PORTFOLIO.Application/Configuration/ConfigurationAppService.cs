using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BACK.PORTFOLIO.Configuration.Dto;

namespace BACK.PORTFOLIO.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PORTFOLIOAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
