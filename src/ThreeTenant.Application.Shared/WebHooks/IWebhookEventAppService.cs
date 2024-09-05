using System.Threading.Tasks;
using Abp.Webhooks;

namespace ThreeTenant.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
