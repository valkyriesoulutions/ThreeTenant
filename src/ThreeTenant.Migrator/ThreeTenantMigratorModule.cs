using Abp.AspNetZeroCore;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using ThreeTenant.Configuration;
using ThreeTenant.EntityFrameworkCore;
using ThreeTenant.Migrator.DependencyInjection;

namespace ThreeTenant.Migrator
{
    [DependsOn(typeof(ThreeTenantEntityFrameworkCoreModule))]
    public class ThreeTenantMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ThreeTenantMigratorModule(ThreeTenantEntityFrameworkCoreModule threeTenantEntityFrameworkCoreModule)
        {
            threeTenantEntityFrameworkCoreModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ThreeTenantMigratorModule).GetAssembly().GetDirectoryPathOrNull(),
                addUserSecrets: true
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ThreeTenantConsts.ConnectionStringName
                );
            Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThreeTenantMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}