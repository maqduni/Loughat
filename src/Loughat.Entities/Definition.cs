using Loughat.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loughat.Entities
{
    public class Definition
    {
        public string Tj { get; set; }
        public string Fa { get; set; }

        public Definition()
        {

        }

        public Definition(LanguageCode languageCode, string definition)
        {
            switch (languageCode)
            {
                case LanguageCode.Tj:
                    Tj = definition;
                    break;
                case LanguageCode.Fa:
                    Fa = definition;
                    break;
                default:
                    break;
            }
        }
    }
}
