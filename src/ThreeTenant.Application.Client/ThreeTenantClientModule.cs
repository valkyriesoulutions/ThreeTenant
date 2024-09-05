using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ThreeTenant
{
    public class ThreeTenantClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThreeTenantClientModule).GetAssembly());
        }
    }
}
