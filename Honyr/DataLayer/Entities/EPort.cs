using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    class EPort
    {
        public long ItemId { get; set; }
        public int PortNumber { get; set; }
        public string PortId { get; set; }
        public string PortName { get; set; }
        public string PortConfig { get; set; }
        public string PortPhysicalType { get; set; }
    }
}
