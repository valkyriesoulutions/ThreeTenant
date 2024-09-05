using System.Threading.Tasks;
using Abp.Application.Services;
using ThreeTenant.Install.Dto;

namespace ThreeTenant.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}