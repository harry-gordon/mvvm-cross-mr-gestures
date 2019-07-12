// ---------------------------------------------------------------
// <author>Paul Datsyuk</author>
// <url>https://www.linkedin.com/in/pauldatsyuk/</url>
// ---------------------------------------------------------------

using MvvmCrossGestureSample.Core.Resources;
using MvvmCrossGestureSample.Core.Services;

namespace MvvmCrossGestureSample.Core.Helpers
{
    public static class TranslateExtension
    {
        public static string Translate(this ILocalizeService localizeService, string str)
        {
            var tranlation = AppResources.ResourceManager.GetString(str, localizeService.GetCurrentCultureInfo());
            return string.IsNullOrEmpty(tranlation) ? str : tranlation;
        }
    }
}
