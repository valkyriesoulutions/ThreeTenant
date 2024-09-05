using Microsoft.Extensions.Configuration;

namespace ThreeTenant.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
