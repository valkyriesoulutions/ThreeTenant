using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThreeTenant.ApiClient;
using ThreeTenant.Mobile.MAUI.Core.ApiClient;

namespace ThreeTenant
{
    [DependsOn(typeof(ThreeTenantClientModule), typeof(AbpAutoMapperModule))]

    public class ThreeTenantMobileMAUIModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.ReplaceService<IApplicationContext, MAUIApplicationContext>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThreeTenantMobileMAUIModule).GetAssembly());
        }
    }
}