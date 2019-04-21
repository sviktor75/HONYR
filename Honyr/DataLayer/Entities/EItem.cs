using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    class EItem  
    {
        public long Id { get; }
        public bool Active { get; set; }
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string IpAddress { get; set; }
        public string MacAddress { get; set; }
        public long LocationId { get; set; }
        public int SymbolId { get; set; }
        public string LocationNotes { get; set; }
    }
}
