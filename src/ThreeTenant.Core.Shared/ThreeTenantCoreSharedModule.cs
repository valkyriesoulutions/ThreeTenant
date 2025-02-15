﻿using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ThreeTenant
{
    public class ThreeTenantCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThreeTenantCoreSharedModule).GetAssembly());
        }
    }
}