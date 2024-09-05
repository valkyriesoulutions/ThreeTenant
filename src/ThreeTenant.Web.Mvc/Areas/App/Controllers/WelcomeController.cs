using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThreeTenant.Web.Controllers;

namespace ThreeTenant.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : ThreeTenantControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}