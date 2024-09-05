using Microsoft.AspNetCore.Mvc;
using ThreeTenant.Web.Controllers;

namespace ThreeTenant.Web.Public.Controllers
{
    public class AboutController : ThreeTenantControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}