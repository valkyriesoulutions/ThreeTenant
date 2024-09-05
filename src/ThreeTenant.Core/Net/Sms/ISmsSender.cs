using System.Threading.Tasks;

namespace ThreeTenant.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}