using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ThreeTenant.Localization
{
    public static class ThreeTenantLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    ThreeTenantConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ThreeTenantLocalizationConfigurer).GetAssembly(),
                        "ThreeTenant.Localization.ThreeTenant"
                    )
                )
            );
        }
    }
}