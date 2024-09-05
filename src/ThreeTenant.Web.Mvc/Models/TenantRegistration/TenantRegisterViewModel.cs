using ThreeTenant.Editions;
using ThreeTenant.Editions.Dto;
using ThreeTenant.MultiTenancy.Payments;
using ThreeTenant.Security;
using ThreeTenant.MultiTenancy.Payments.Dto;

namespace ThreeTenant.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
