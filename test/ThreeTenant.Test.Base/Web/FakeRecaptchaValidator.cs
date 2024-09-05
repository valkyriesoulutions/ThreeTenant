using System.Threading.Tasks;
using ThreeTenant.Security.Recaptcha;

namespace ThreeTenant.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
