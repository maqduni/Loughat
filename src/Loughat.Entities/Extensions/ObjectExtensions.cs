using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loughat.Entities.Extensions
{
    public static class ObjectExtensions
    {
        public static DenormalizedReference GetDenormalizedReference(this Dictionary dictionary)
        {
            return new DenormalizedReference()
            {
                Id = dictionary.Id,
                Name = dictionary.Name
            };
        }
    }
}
