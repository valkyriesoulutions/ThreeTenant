﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ThreeTenant.MultiTenancy.Payments.Dto;
using ThreeTenant.MultiTenancy.Payments.Stripe.Dto;

namespace ThreeTenant.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}