using System.Collections.Generic;
using ThreeTenant.Editions.Dto;
using ThreeTenant.MultiTenancy.Payments;

namespace ThreeTenant.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}