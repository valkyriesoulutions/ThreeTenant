using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using ThreeTenant.Configure;
using ThreeTenant.Startup;
using ThreeTenant.Test.Base;

namespace ThreeTenant.GraphQL.Tests
{
    [DependsOn(
        typeof(ThreeTenantGraphQLModule),
        typeof(ThreeTenantTestBaseModule))]
    public class ThreeTenantGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThreeTenantGraphQLTestModule).GetAssembly());
        }
    }
}