using Abp.Modules;
using ThreeTenant.Test.Base;

namespace ThreeTenant.Tests
{
    [DependsOn(typeof(ThreeTenantTestBaseModule))]
    public class ThreeTenantTestModule : AbpModule
    {
       
    }
}
