using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using ThreeTenant.EntityFrameworkCore;

namespace ThreeTenant.HealthChecks
{
    public class ThreeTenantDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public ThreeTenantDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("ThreeTenantDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("ThreeTenantDbContext could not connect to database"));
        }
    }
}
