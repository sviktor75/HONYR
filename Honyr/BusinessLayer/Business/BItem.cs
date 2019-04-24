using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;

namespace BusinessLayer.Business
{
    public class BItem
    {
        OItem itemOP = new OItem();


        public int AddItem(bool active, string deviceID, string deviceName, string ip, string mac, long locationid, int symbolId, string description)
        {
            return itemOP.AddItem(active,deviceID,deviceName,ip,mac,locationid,symbolId,description);

        }

        public int ModItem(long id, bool active, string deviceID, string deviceName, string ip, string mac, long locationid, int symbolId, string description)
        {
            return itemOP.ModItem(id, active, deviceID, deviceName, ip, mac, locationid, symbolId, description);
        }

        public int DelItem(long id)
        {
            return itemOP.DelItem(id);
        }

        public List<String> GetItem()
        {
            return itemOP.GetItem();
        }

        public List<String> GetItemByName(string name)
        {
            return itemOP.GetItemByName(name);
        }
    }
}
