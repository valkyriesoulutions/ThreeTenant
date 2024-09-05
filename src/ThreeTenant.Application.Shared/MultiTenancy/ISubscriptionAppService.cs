﻿using System.Threading.Tasks;
using Abp.Application.Services;

namespace ThreeTenant.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
