using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThreeTenant.Web.Areas.App.Models.Layout;
using ThreeTenant.Web.Session;
using ThreeTenant.Web.Views;

namespace ThreeTenant.Web.Areas.App.Views.Shared.Themes.Theme4.Components.AppTheme4Brand
{
    public class AppTheme4BrandViewComponent : ThreeTenantViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme4BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
