using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace API_USER.Controllers
{
    public abstract class API_USERControllerBase: AbpController
    {
        protected API_USERControllerBase()
        {
            LocalizationSourceName = API_USERConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
