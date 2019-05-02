using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;
using System.IO;


namespace BusinessLayer.Business
{
    public class BLocation
    {

        OLocation location = new OLocation();    

        public int AddLocation(string locationId, string name, int locationTypeId, long parentId, int symbolId, string description)
        {
            return location.AddLocation(locationId, name, locationTypeId, parentId, symbolId, description);

        }

        public int ModLocation(long id, string locationId, string name, int locationTypeId, long parentId, int symbolId, string description)
        {
            return location.ModLocation(id, locationId, name, locationTypeId, parentId, symbolId, description);
        }

        public int DelLocation(long id)
        {
            return location.DelLocation(id);
        }

        public List<String> GetLocations()
        {
            return location.GetLocations();
        }

        public List<String> GetLocationByName(string name)
        {
            return location.GetLocationByName(name);
        }

        public int GetididByLocationid(string locationid)
        {
            return location.GetididByLocationid(locationid);
        }

        public string GetLocationidByID(int id)
        {
            return location.GetLocationidByID(id);
        }
    }
}
