using Abp.AspNetCore.Mvc.ViewComponents;

namespace ThreeTenant.Web.Views
{
    public abstract class ThreeTenantViewComponent : AbpViewComponent
    {
        protected ThreeTenantViewComponent()
        {
            LocalizationSourceName = ThreeTenantConsts.LocalizationSourceName;
        }
    }
}