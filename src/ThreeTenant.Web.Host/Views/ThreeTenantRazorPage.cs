using Abp.AspNetCore.Mvc.Views;

namespace ThreeTenant.Web.Views
{
    public abstract class ThreeTenantRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ThreeTenantRazorPage()
        {
            LocalizationSourceName = ThreeTenantConsts.LocalizationSourceName;
        }
    }
}
