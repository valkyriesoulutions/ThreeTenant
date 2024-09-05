using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThreeTenant.Authorization;
using ThreeTenant.DashboardCustomization;
using System.Threading.Tasks;
using ThreeTenant.Web.Areas.App.Startup;

namespace ThreeTenant.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Dashboard)]
    public class HostDashboardController : CustomizableDashboardControllerBase
    {
        public HostDashboardController(
            DashboardViewConfiguration dashboardViewConfiguration,
            IDashboardCustomizationAppService dashboardCustomizationAppService)
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(ThreeTenantDashboardCustomizationConsts.DashboardNames.DefaultHostDashboard);
        }
    }
}