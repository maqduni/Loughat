using System;
using System.Collections.Generic;
using System.Text;

namespace Loughat.Entities.Extensions
{
    public static class DefinitionExtensions
    {
        public static Definition AddTj(this Definition definition, string meaninig)
        {
            definition.Tj.Add(meaninig);
            return definition;
        }

        public static Definition AddFa(this Definition definition, string meaninig)
        {
            definition.Fa.Add(meaninig);
            return definition;
        }
    }
}
