﻿using Microsoft.JSInterop;
using ThreeTenant.ApiClient;
using ThreeTenant.Core.Dependency;
using ThreeTenant.Mobile.MAUI.Services.UI;
using ThreeTenant.Mobile.MAUI.Services.User;
using ThreeTenant.Models.NavigationMenu;
using ThreeTenant.Services.Navigation;

namespace ThreeTenant.Mobile.MAUI.Shared
{
    public partial class NavMenu : ThreeTenantComponentBase
    {
        protected IMenuProvider MenuProvider { get; set; }
        protected IApplicationContext ApplicationContext { get; set; }
        protected IAccessTokenManager AccessTokenManager { get; set; }
        protected LanguageService LanguageService { get; set; }
        protected IUserProfileService UserProfileService { get; set; }

        protected List<NavigationMenuItem> MenuItems;

        private bool HasUserInfo => AccessTokenManager != null &&
            AccessTokenManager.IsUserLoggedIn &&
            ApplicationContext != null &&
            ApplicationContext.LoginInfo != null &&
            ApplicationContext?.LoginInfo?.User != null;

        private string _userImage;

        protected override async Task OnInitializedAsync()
        {
            MenuItems = new List<NavigationMenuItem>();

            MenuProvider = DependencyResolver.Resolve<IMenuProvider>();
            ApplicationContext = DependencyResolver.Resolve<IApplicationContext>();
            AccessTokenManager = DependencyResolver.Resolve<IAccessTokenManager>();
            UserProfileService = DependencyResolver.Resolve<IUserProfileService>();

            LanguageService = DependencyResolver.Resolve<LanguageService>();
            LanguageService.OnLanguageChanged += (s, e) =>
            {
                BuildMenuItems();
                StateHasChanged();
            };

            BuildMenuItems();
            await GetUserPhoto();
        }

        public void BuildMenuItems()
        {
            if (!AccessTokenManager.IsUserLoggedIn)
            {
                MenuItems = MenuProvider.GetAuthorizedMenuItems(null);
                return;
            }

            var grantedPermissions = ApplicationContext.Configuration.Auth.GrantedPermissions;
            MenuItems = MenuProvider.GetAuthorizedMenuItems(grantedPermissions);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Task.Delay(1000);
                await JS.InvokeVoidAsync("KTDialer.init");
                await JS.InvokeVoidAsync("KTDrawer.init");
                await JS.InvokeVoidAsync("KTImageInput.init");
                await JS.InvokeVoidAsync("KTMenu.init");
                await JS.InvokeVoidAsync("KTPasswordMeter.init");
                await JS.InvokeVoidAsync("KTScroll.init");
                await JS.InvokeVoidAsync("KTScrolltop.init");
                await JS.InvokeVoidAsync("KTSticky.init");
                await JS.InvokeVoidAsync("KTSwapper.init");
                await JS.InvokeVoidAsync("KTToggle.init");
                await JS.InvokeVoidAsync("KTApp.init");
                await JS.InvokeVoidAsync("KTAppLayoutBuilder.init");
                await JS.InvokeVoidAsync("KTLayoutSearch.init");
                await JS.InvokeVoidAsync("KTAppSidebar.init");
                await JS.InvokeVoidAsync("KTThemeModeUser.init");
                await JS.InvokeVoidAsync("KTThemeMode.init");
                await JS.InvokeVoidAsync("KTLayoutToolbar.init");
            }
        }

        private async Task GetUserPhoto()
        {
            if (!HasUserInfo)
            {
                return;
            }

            _userImage = await UserProfileService.GetProfilePicture(ApplicationContext.LoginInfo.User.Id);
            StateHasChanged();
        }
    }
}
