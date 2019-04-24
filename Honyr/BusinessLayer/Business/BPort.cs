using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;

namespace BusinessLayer.Business
{
    class BPort
    {
        OPort portOP = new OPort();

        public int AddLocation(int portnumber, string portID, string portName, string portConfig, string portPhysicalType)
        {
            return portOP.AddPort(portnumber, portID, portName, portConfig, portPhysicalType);

        }

        public int ModLocation(long id, int portnumber, string portID, string portName, string portConfig, string portPhysicalType)
        {
            return portOP.ModPort(id, portnumber, portID, portName, portConfig, portPhysicalType);
        }

        public int DelLocation(long id)
        {
            return portOP.DelPort(id);
        }

        public List<String> GetPorts()
        {
            return portOP.GetPorts();
        }

        public List<String> GetPortsByName(string name)
        {
            return portOP.GetPortByName(name);
        }
    }
}
