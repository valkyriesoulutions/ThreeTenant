using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThreeTenant.Web.Areas.App.Models.Layout;
using ThreeTenant.Web.Views;

namespace ThreeTenant.Web.Areas.App.Views.Shared.Components.AppRecentNotifications
{
    public class AppRecentNotificationsViewComponent : ThreeTenantViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-alert-2 unread-notification fs-2")
        {
            var model = new RecentNotificationsViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
