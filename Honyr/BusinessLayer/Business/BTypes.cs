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

        public int ModType(string type, string name)
        {
            return typesOP.ModType(type, name);
        }

    }
}
