using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ThreeTenant.Authorization.Permissions.Dto;

namespace ThreeTenant.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
