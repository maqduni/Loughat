using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loughat.Entities
{
    public class Abbreviation
    {
        public Abbreviation(string @short, string full, bool isLanguageName = false)
        {
            Short = @short;
            Full = full;
            IsLanguageName = isLanguageName;
        }

        public string Short { get; set; }

        public string Full { get; set; }

        public bool IsLanguageName { get; set; }
    }
}
