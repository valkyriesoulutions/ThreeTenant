﻿using ThreeTenant.ApiClient;
using ThreeTenant.Core.Dependency;
using ThreeTenant.Services.Account;
using ThreeTenant.Services.Storage;

namespace ThreeTenant.Mobile.MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static async Task OnSessionTimeout()
        {
            await DependencyResolver.Resolve<IAccountService>().LogoutAsync();
        }

        public static async Task OnAccessTokenRefresh(string newAccessToken, string newEncryptedAccessToken)
        {
            await DependencyResolver.Resolve<IDataStorageService>().StoreAccessTokenAsync(newAccessToken, newEncryptedAccessToken);
        }

        public static void LoadPersistedSession()
        {
            var accessTokenManager = DependencyResolver.Resolve<IAccessTokenManager>();
            var dataStorageService = DependencyResolver.Resolve<IDataStorageService>();
            var applicationContext = DependencyResolver.Resolve<IApplicationContext>();

            accessTokenManager.AuthenticateResult = dataStorageService.RetrieveAuthenticateResult();
            applicationContext.Load(dataStorageService.RetrieveTenantInfo(), dataStorageService.RetrieveLoginInfo());
        }
    }
}