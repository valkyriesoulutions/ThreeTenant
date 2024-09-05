using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThreeTenant.Authorization;

namespace ThreeTenant
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(ThreeTenantApplicationSharedModule),
        typeof(ThreeTenantCoreModule)
        )]
    public class ThreeTenantApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThreeTenantApplicationModule).GetAssembly());
        }
    }
}