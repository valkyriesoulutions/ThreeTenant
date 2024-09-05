using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ThreeTenant.Startup
{
    [DependsOn(typeof(ThreeTenantCoreModule))]
    public class ThreeTenantGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThreeTenantGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}