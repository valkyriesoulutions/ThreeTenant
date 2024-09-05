using System.Threading.Tasks;
using ThreeTenant.Sessions.Dto;

namespace ThreeTenant.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
