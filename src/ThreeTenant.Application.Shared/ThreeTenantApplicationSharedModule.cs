using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ThreeTenant
{
    [DependsOn(typeof(ThreeTenantCoreSharedModule))]
    public class ThreeTenantApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThreeTenantApplicationSharedModule).GetAssembly());
        }
    }
}