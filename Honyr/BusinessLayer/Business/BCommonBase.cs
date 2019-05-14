using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;

namespace BusinessLayer.Business
{
    public class BCommonBase
    {
        OCommonBase cbase = new OCommonBase();

        public List<String> BaseSearch(string table, string columnname, string searchstring)
        {
            return cbase.BaseSearch(table, columnname, searchstring);
        }
    }
}
