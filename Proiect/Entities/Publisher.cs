using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class Publisher
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public float Rating { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
