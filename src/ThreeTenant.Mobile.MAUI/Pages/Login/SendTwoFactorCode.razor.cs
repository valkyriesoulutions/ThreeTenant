﻿using ThreeTenant.ApiClient;
using ThreeTenant.Authorization.Accounts;
using ThreeTenant.Core.Dependency;
using ThreeTenant.Core.Threading;
using ThreeTenant.Mobile.MAUI.Shared;
using ThreeTenant.Services.Account;

namespace ThreeTenant.Mobile.MAUI.Pages.Login
{
    public partial class SendTwoFactorCode : ThreeTenantComponentBase
    {
        public string CurrentTenancyNameOrDefault => _applicationContext.CurrentTenant != null
        ? _applicationContext.CurrentTenant.TenancyName
        : L("NotSelected");

        private IAccountService _accountService;
        private IApplicationContext _applicationContext;
        private readonly ProxyTokenAuthControllerService _proxyTokenAuthControllerService;

        private List<string> _twoFactorAuthProviders;
        private string _selectedProvider;

        public SendTwoFactorCode()
        {
            _accountService = DependencyResolver.Resolve<IAccountService>();
            _applicationContext = DependencyResolver.Resolve<IApplicationContext>();
            _proxyTokenAuthControllerService = DependencyResolver.Resolve<ProxyTokenAuthControllerService>();
        }

        protected override Task OnInitializedAsync()
        {
            _twoFactorAuthProviders = _accountService.AuthenticateResultModel.TwoFactorAuthProviders.ToList();
            _selectedProvider = _twoFactorAuthProviders.FirstOrDefault();
            return Task.CompletedTask;
        }

        private void OnLanguageSwitchAsync()
        {
            StateHasChanged();
        }

        private async Task SelectProvider()
        {
            await SetBusyAsync(async () =>
            {
                await WebRequestExecuter.Execute(
                    async () => await _proxyTokenAuthControllerService
                    .SendTwoFactorAuthCode(_accountService.AuthenticateResultModel.UserId, _selectedProvider)
                );
            });

            var promptResult = await UserDialogsService.Prompt(L("VerifySecurityCode_Information"), L("VerifySecurityCode"));

            if (!string.IsNullOrEmpty(promptResult))
            {
                _accountService.AbpAuthenticateModel.TwoFactorVerificationCode = promptResult;
                _accountService.AbpAuthenticateModel.RememberClient = true;

                await SetBusyAsync(async () =>
                {
                    await WebRequestExecuter.Execute(
                        async () => await _accountService.LoginUserAsync()
                    );
                });
            }
        }
    }
}
