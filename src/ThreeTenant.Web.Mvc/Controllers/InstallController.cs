﻿using Abp.AspNetCore.Mvc.Controllers;
using Abp.Auditing;
using Abp.Domain.Uow;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using ThreeTenant.Configuration;
using ThreeTenant.EntityFrameworkCore;
using ThreeTenant.Install;
using ThreeTenant.Migrations.Seed.Host;
using ThreeTenant.Web.Models.Install;
using Newtonsoft.Json.Linq;

namespace ThreeTenant.Web.Controllers
{
    [DisableAuditing]
    public class InstallController : AbpController
    {
        private readonly IInstallAppService _installAppService;
        private readonly IHostApplicationLifetime _applicationLifetime;
        private readonly DatabaseCheckHelper _databaseCheckHelper;
        private readonly IConfigurationRoot _appConfiguration;

        public InstallController(
            IInstallAppService installAppService,
            IHostApplicationLifetime applicationLifetime,
            DatabaseCheckHelper databaseCheckHelper,
            IAppConfigurationAccessor appConfigurationAccessor)
        {
            _installAppService = installAppService;
            _applicationLifetime = applicationLifetime;
            _databaseCheckHelper = databaseCheckHelper;
            _appConfiguration = appConfigurationAccessor.Configuration;
        }

        [UnitOfWork(IsDisabled = true)]
        public ActionResult Index()
        {
            var appSettings = _installAppService.GetAppSettingsJson();
            var connectionString = _appConfiguration[$"ConnectionStrings:{ThreeTenantConsts.ConnectionStringName}"];

            if (_databaseCheckHelper.Exist(connectionString))
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new InstallViewModel
            {
                Languages = DefaultLanguagesCreator.InitialLanguages,
                AppSettingsJson = appSettings
            };

            return View(model);
        }

        public ActionResult Restart()
        {
            _applicationLifetime.StopApplication();
            return View();
        }
    }
}
