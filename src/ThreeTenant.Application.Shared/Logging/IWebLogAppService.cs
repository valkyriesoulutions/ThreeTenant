using Abp.Application.Services;
using ThreeTenant.Dto;
using ThreeTenant.Logging.Dto;

namespace ThreeTenant.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
