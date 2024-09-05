using Microsoft.AspNetCore.Mvc;
using ThreeTenant.Web.Controllers;

namespace ThreeTenant.Web.Public.Controllers
{
    public class HomeController : ThreeTenantControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}