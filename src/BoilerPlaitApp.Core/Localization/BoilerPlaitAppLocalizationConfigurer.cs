using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BoilerPlaitApp.Localization
{
    public static class BoilerPlaitAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BoilerPlaitAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BoilerPlaitAppLocalizationConfigurer).GetAssembly(),
                        "BoilerPlaitApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
