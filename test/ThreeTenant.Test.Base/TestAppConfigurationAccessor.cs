using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using ThreeTenant.Configuration;

namespace ThreeTenant.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(ThreeTenantTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
