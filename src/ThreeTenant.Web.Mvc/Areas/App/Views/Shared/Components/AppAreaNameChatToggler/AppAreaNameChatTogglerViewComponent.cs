using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThreeTenant.Web.Areas.App.Models.Layout;
using ThreeTenant.Web.Views;

namespace ThreeTenant.Web.Areas.App.Views.Shared.Components.AppChatToggler
{
    public class AppChatTogglerViewComponent : ThreeTenantViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-chat-2 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new ChatTogglerViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
