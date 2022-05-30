using System.Collections.Generic;
using Abp.Configuration;
using Microsoft.Extensions.Configuration;

namespace BACK.PORTFOLIO.Configuration
{
    public class AppSettingProvider : SettingProvider
    {
        private readonly IConfiguration _appConfiguration;

        public AppSettingProvider(IConfiguration appConfiguration)
        {
            _appConfiguration = appConfiguration;
        }

        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {
                new SettingDefinition(AppSettingNames.UiTheme, "red", scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                new SettingDefinition(AppSettingNames.VimeoClientId, _appConfiguration.GetValue<string>(PORTFOLIOConsts.VimeoClientId),scopes: SettingScopes.Application ),
                new SettingDefinition(AppSettingNames.VimeoClientSecret, _appConfiguration.GetValue<string>(PORTFOLIOConsts.VimeoClientSecret),scopes: SettingScopes.Application ),
                new SettingDefinition(AppSettingNames.VimeoAccessToken, _appConfiguration.GetValue<string>(PORTFOLIOConsts.VimeoAccessToken),scopes: SettingScopes.Application )
            };
        }
    }
}
