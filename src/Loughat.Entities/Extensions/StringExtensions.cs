using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loughat.Entities.Extensions
{
    public static class StringExtensions
    {
        public static Definition ToTj(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            return new Definition(Enums.LanguageCode.Tj, value);
        }

        public static Definition ToTj(this IEnumerable<string> values)
        {
            var nonEmptyMeanings = values.Where(m => !string.IsNullOrWhiteSpace(m));
            if (nonEmptyMeanings.Count() == 0)
                return null;

            return new Definition(Enums.LanguageCode.Tj, nonEmptyMeanings);
        }
    }
}
