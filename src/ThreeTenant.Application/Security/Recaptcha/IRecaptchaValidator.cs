using System.Threading.Tasks;

namespace ThreeTenant.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}