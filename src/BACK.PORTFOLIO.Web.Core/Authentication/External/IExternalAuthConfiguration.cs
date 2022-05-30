using System.Collections.Generic;

namespace BACK.PORTFOLIO.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
