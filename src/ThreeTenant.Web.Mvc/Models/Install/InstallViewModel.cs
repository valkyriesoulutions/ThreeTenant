using System.Collections.Generic;
using Abp.Localization;
using ThreeTenant.Install.Dto;

namespace ThreeTenant.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
