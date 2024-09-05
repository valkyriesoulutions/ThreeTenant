using Abp.Events.Bus;

namespace ThreeTenant.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}