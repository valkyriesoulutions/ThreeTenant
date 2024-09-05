using System.Threading.Tasks;
using Abp.Application.Services;
using ThreeTenant.Sessions.Dto;

namespace ThreeTenant.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
