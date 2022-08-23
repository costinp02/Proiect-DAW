using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class Store
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<GameStore> GameStores { get; set; }
    }
}
