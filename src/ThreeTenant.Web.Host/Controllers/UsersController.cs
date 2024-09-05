using Abp.AspNetCore.Mvc.Authorization;
using ThreeTenant.Authorization;
using ThreeTenant.Storage;
using Abp.BackgroundJobs;

namespace ThreeTenant.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}