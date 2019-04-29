using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;

namespace BusinessLayer.Business
{

    public class BPort
    {
        OPort portOP = new OPort();

        public int AddPortActive(int portnumber, string portID, string portName, string portConfig, string portPhysicalType, long itemId)
        { return portOP.AddPortActive(portnumber, portID, portName, portConfig, portPhysicalType, itemId); }

        //public int AddPortPassive(long itemId, int portnumber, string portID, string portPhysicalType)
        //{return }

        //    public int ModPortActive(long id, int portnumber, string portID, string portName, string portConfig, string portPhysicalType, long itemId)
        //    { }

        //    public int ModPortPassive(long id, int portnumber, string portID, string portPhysicalType, long itemId)
        //    { }


        //    public int DelPortActive(long id)
        //    { }

        public int DelPortPassive(long id)
        { return portOP.DelPortPassive(id); }




        // ----------  fos ---------------
        //public int AddLocation(int portnumber, string portID, string portName, string portConfig, string portPhysicalType)
        //{
        //    return portOP.AddPort(portnumber, portID, portName, portConfig, portPhysicalType);

        //}

        //public int ModLocation(long id, int portnumber, string portID, string portName, string portConfig, string portPhysicalType)
        //{
        //    return portOP.ModPort(id, portnumber, portID, portName, portConfig, portPhysicalType);
        //}

        //public int DelLocation(long id)
        //{
        //    return portOP.DelPort(id);
        //}

        //public List<String> GetPorts()
        //{
        //    return portOP.GetPorts();
        //}



        public List<String> GetPortsByItemId(long itemid, bool active)
        {
            return portOP.GetPortsByItemId(itemid, active);
        }


        public List<string> GetPortDetailsByPortNumber(long itemid, int portnumber)
        {
            return portOP.GetPortDetailsByPortNumber(itemid, portnumber);
        }



    }

}