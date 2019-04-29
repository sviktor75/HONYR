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
        OItem itemActive = new OItem();


        public int AddItem(string deviceID, string deviceName, long locationID, int symbolId, string description, bool active)
        {
            return itemActive.AddItem(deviceID,deviceName,locationID,symbolId,description,active);

        }

        public int ModItem(long id, string deviceID, string deviceName, long locationID, int symbolID, string description)
        {
            return itemActive.ModItem(id, deviceID, deviceName, locationID, symbolID, description);
        }

        public int DelItem(long id)
        {
            return itemActive.DelItem(id);
        }


        public List<String> GetItemByName(string name, bool active)
        {
            return itemActive.GetItemByName(name, active);
        }
    }
}
