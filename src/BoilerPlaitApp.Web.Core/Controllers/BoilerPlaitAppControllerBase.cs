using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BoilerPlaitApp.Controllers
{
    public abstract class BoilerPlaitAppControllerBase: AbpController
    {
        protected BoilerPlaitAppControllerBase()
        {
            LocalizationSourceName = BoilerPlaitAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
