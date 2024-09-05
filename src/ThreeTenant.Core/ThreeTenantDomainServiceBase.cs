using Abp.Domain.Services;

namespace ThreeTenant
{
    public abstract class ThreeTenantDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected ThreeTenantDomainServiceBase()
        {
            LocalizationSourceName = ThreeTenantConsts.LocalizationSourceName;
        }
    }
}
