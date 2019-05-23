using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;
using System.IO;
using System.Data;


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

        public DataTable GetLocationsTable()
        {
            return location.GetLocationsTable();
        }


        public List<String> GetLocationByName(string name)
        {
            return location.GetLocationByName(name);
        }

        public int GetIdByLocationid(string locationid)
        {
            return location.GetIdByLocationid(locationid);
        }

        public string GetLocationidById(int id)
        {
            return location.GetLocationidById(id);
        }
    }
}
