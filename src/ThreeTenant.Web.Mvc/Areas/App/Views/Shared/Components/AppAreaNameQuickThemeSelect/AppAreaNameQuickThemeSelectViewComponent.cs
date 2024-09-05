using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThreeTenant.Web.Areas.App.Models.Layout;
using ThreeTenant.Web.Views;

namespace ThreeTenant.Web.Areas.App.Views.Shared.Components.
    AppQuickThemeSelect
{
    public class AppQuickThemeSelectViewComponent : ThreeTenantViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-interface-7 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
