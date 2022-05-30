using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BACK.PORTFOLIO.Controllers
{
    public abstract class PORTFOLIOControllerBase: AbpController
    {
        protected PORTFOLIOControllerBase()
        {
            LocalizationSourceName = PORTFOLIOConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
