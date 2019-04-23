using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;


namespace BusinessLayer.Business
{
    public class BLocation
    {
        OLocation locationOP = new OLocation();

        public int AddLocation(string locationId, string name, string locationType, string parentId, int symbolId, string description)
        {
            return locationOP.AddLocation(locationId, name, locationType, parentId, symbolId, description);
        }

        public int ModLocation(long id, string locationId, string name, string locationType, string parentId, int symbolId, string description)
        {
            return locationOP.ModLocation(id, locationId, name, locationType, parentId, symbolId, description);
        }

        public int DelLocation(long id)
        {
            return locationOP.DelLocation(id);
        }

        public List<String> GetLocations()
        {
            return locationOP.GetLocations();
        }

        public List<String> GetLocationByName(string name)
        {
            return locationOP.GetLocationByName(name);
        }

    }
}
