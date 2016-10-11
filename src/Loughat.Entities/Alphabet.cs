using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loughat.Entities
{
    public class Alphabet
    {
        public string Name { get; set; }
        public Dictionary<string, Definition> Letters { get; set; }
    }
}
