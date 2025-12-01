using System.Globalization;
using System.Text;

namespace CatalogWebApi.Helper
{
    public class NameNormalizer
    {
        public static string Normalize(string name) 
        { 
            if(string.IsNullOrWhiteSpace(name))
                return name;

            name = name.ToLowerInvariant();

            var normalized = name.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var c in normalized) 
            { 
                var category = CharUnicodeInfo.GetUnicodeCategory(c);
                if(category != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC).Trim();
        }
    }
}
