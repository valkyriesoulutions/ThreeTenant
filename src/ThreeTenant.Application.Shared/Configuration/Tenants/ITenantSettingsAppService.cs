using System.Threading.Tasks;
using Abp.Application.Services;
using ThreeTenant.Configuration.Tenants.Dto;

namespace ThreeTenant.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearDarkLogo();
        
        Task ClearLightLogo();

        Task ClearCustomCss();
    }
}
