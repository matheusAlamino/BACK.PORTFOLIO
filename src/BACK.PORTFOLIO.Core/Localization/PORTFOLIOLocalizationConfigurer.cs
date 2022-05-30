using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BACK.PORTFOLIO.Localization
{
    public static class PORTFOLIOLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PORTFOLIOConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PORTFOLIOLocalizationConfigurer).GetAssembly(),
                        "BACK.PORTFOLIO.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
