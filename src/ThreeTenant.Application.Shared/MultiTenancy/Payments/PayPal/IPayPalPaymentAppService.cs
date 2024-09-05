﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ThreeTenant.MultiTenancy.Payments.PayPal.Dto;

namespace ThreeTenant.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
