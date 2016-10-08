using Loughat.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loughat.Entities
{
    public class DenormalizedReference: IEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
