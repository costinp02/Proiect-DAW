using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class Game
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public float Price { get; set; }

        public string PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<GameStore> GameStores { get; set; }
        
        
    }
}
