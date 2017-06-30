using Loughat.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loughat.Entities
{
    public class Dictionary: IEntity
    {
        public string Id { get; set; }
        public Definition Name { get; set; }

        // TODO: Create Author entity
        public List<string> Authors { get; set; }

        // TODO: Add all remaining data, including the foreword etc.
    }
}
