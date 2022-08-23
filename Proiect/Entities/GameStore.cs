using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class GameStore
    {
        public string GameId { get; set; }
        public string StoreId { get; set; }

        public virtual Game Game { get; set; }
        public virtual Store Store { get; set; }
    }
}
