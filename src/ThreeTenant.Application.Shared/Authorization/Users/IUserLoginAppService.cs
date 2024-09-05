using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ThreeTenant.Authorization.Users.Dto;

namespace ThreeTenant.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<PagedResultDto<UserLoginAttemptDto>> GetUserLoginAttempts(GetLoginAttemptsInput input);
    }
}
