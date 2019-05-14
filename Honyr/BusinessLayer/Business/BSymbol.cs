using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Operations;


namespace BusinessLayer.Business
{
    public class BSymbol
    {
        OSymbol symbolOP = new OSymbol();
        
        public List<String> GetSymbols(int symboltypeid)
        {
            return symbolOP.GetSymbols(symboltypeid);
        }


        public DataTable GetSymbolsByType(int symboltypeid)
        {
            return symbolOP.GetSymbolsByType(symboltypeid);
        }


        public List<object> GetSymbolById(int id)
        {
            return symbolOP.GetSymbolById(id);
        }
    }
}
