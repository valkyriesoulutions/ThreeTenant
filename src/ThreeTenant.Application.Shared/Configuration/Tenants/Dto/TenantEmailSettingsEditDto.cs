using Abp.Auditing;
using ThreeTenant.Configuration.Dto;

namespace ThreeTenant.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}