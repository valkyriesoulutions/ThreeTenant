using System.Threading.Tasks;
using Abp.Application.Services;
using ThreeTenant.Configuration.Host.Dto;

namespace ThreeTenant.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
