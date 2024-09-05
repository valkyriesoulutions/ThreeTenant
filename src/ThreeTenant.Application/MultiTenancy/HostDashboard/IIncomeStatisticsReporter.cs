using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThreeTenant.MultiTenancy.HostDashboard.Dto;

namespace ThreeTenant.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}