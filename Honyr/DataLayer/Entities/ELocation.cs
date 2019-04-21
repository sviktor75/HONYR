using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    class ELocation
    {
        public long Id { get; } // mert auto increment az adatbázis felől
        public string Name { get; set; }
        public string LocationType { get; set; }
        public long ParentId { get; set; }
        public int SymbolId { get; set; }
        public string Description { get; set; }
    }
}
