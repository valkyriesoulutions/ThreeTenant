using Abp.AspNetCore.Mvc.Authorization;
using ThreeTenant.Authorization.Users.Profile;
using ThreeTenant.Graphics;
using ThreeTenant.Storage;

namespace ThreeTenant.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService,
            IImageValidator imageValidator) :
            base(tempFileCacheManager, profileAppService, imageValidator)
        {
        }
    }
}