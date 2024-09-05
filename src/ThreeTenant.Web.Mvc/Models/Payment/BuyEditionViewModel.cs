using System.Collections.Generic;
using ThreeTenant.Editions;
using ThreeTenant.Editions.Dto;
using ThreeTenant.MultiTenancy.Payments;
using ThreeTenant.MultiTenancy.Payments.Dto;

namespace ThreeTenant.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
