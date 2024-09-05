using Abp.AspNetZeroCore;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using ThreeTenant.Auditing;
using ThreeTenant.Authorization.Users.Password;
using ThreeTenant.Configuration;
using ThreeTenant.EntityFrameworkCore;
using ThreeTenant.MultiTenancy;
using ThreeTenant.Web.Areas.App.Startup;

namespace ThreeTenant.Web.Startup
{
    [DependsOn(
        typeof(ThreeTenantWebCoreModule)
    )]
    public class ThreeTenantWebMvcModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ThreeTenantWebMvcModule(IWebHostEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebCommon().MultiTenancy.DomainFormat = _appConfiguration["App:WebSiteRootAddress"] ?? "https://localhost:44302/";
            Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];
            Configuration.Navigation.Providers.Add<AppNavigationProvider>();

            IocManager.Register<DashboardViewConfiguration>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThreeTenantWebMvcModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!IocManager.Resolve<IMultiTenancyConfig>().IsEnabled)
            {
                return;
            }

            using (var scope = IocManager.CreateScope())
            {
                if (!scope.Resolve<DatabaseCheckHelper>().Exist(_appConfiguration["ConnectionStrings:Default"]))
                {
                    return;
                }
            }

            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            workManager.Add(IocManager.Resolve<SubscriptionExpirationCheckWorker>());
            workManager.Add(IocManager.Resolve<SubscriptionExpireEmailNotifierWorker>());
            workManager.Add(IocManager.Resolve<SubscriptionPaymentNotCompletedEmailNotifierWorker>());

            var expiredAuditLogDeleterWorker = IocManager.Resolve<ExpiredAuditLogDeleterWorker>();
            if (Configuration.Auditing.IsEnabled && expiredAuditLogDeleterWorker.IsEnabled)
            {
                workManager.Add(expiredAuditLogDeleterWorker);
            }

            workManager.Add(IocManager.Resolve<PasswordExpirationBackgroundWorker>());
        }
    }
}