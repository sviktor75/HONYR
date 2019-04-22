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
        public int AddLocation(string name, string locationType, long parentId, int symbolId, string description)
        {
            return locationOP.AddLocation(name, locationType, parentId, symbolId, description);
        }

        
        

    }
}
