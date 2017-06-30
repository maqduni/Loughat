using Loughat.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loughat.Entities
{
    public class Definition
    {
        public List<string> Tj { get; set; } = new List<string>();
        public List<string> Fa { get; set; } = new List<string>();

        public Definition()
        {

        }

        public Definition(LanguageCode languageCode, IEnumerable<string> meanings)
        {
            var nonEmptyMeanings = meanings.Where(m => !string.IsNullOrWhiteSpace(m));
            if (nonEmptyMeanings.Count() == 0)
            {
                throw new ArgumentException("List of meaninigs must contain at least 1 non-empty value.");
            }

            switch (languageCode)
            {
                case LanguageCode.Tj:
                    Tj.AddRange(meanings);
                    break;
                case LanguageCode.Fa:
                    Fa.AddRange(meanings);
                    break;
                default:
                    break;
            }
        }

        public Definition(LanguageCode languageCode, string meaning) : this(languageCode, new string[] { meaning })
        {
            if (string.IsNullOrWhiteSpace(meaning))
            {
                throw new ArgumentException("Meaninig must not be null or empty.");
            }
        }

        /// <summary>
        /// Serializes the contents of the definition instance
        /// NOTE: Cannot be used in RavenDB index creation tasks
        /// </summary>
        override public string ToString()
        {
            return string.Join("|", Fa.Concat(Tj));
        }
    }
}
