using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;

namespace BusinessLayer.Business
{
    public class BTypes
    {
        OTypes typesOP = new OTypes();

        public int AddType(string type, string name)
        {
            return typesOP.AddType(type, name);
        }

        public int ModType(string type, int id, string name)
        {
            return typesOP.ModType(type, id, name);
        }

        public int DelType(string type, int id)
        {
            return typesOP.DelType(type, id);
        }

        public List<String> GetTypeByName(string type, string name)
        {
            return typesOP.GetTypeByName(type, name);
        }

        public List<String> GetTypeById(string type, int id)
        {
            return typesOP.GetTypeById(type, id);
        }

    }
}
