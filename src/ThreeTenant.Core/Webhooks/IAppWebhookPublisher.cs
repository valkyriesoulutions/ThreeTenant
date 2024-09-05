using System.Threading.Tasks;
using ThreeTenant.Authorization.Users;

namespace ThreeTenant.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
