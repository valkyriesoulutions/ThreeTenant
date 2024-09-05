using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThreeTenant.Authorization;
using ThreeTenant.Caching;
using ThreeTenant.Web.Areas.App.Models.Maintenance;
using ThreeTenant.Web.Controllers;

namespace ThreeTenant.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Maintenance)]
    public class MaintenanceController : ThreeTenantControllerBase
    {
        private readonly ICachingAppService _cachingAppService;

        public MaintenanceController(ICachingAppService cachingAppService)
        {
            _cachingAppService = cachingAppService;
        }

        public ActionResult Index()
        {
            var model = new MaintenanceViewModel
            {
                Caches = _cachingAppService.GetAllCaches().Items,
                CanClearAllCaches = _cachingAppService.CanClearAllCaches()
            };

            return View(model);
        }
    }
}