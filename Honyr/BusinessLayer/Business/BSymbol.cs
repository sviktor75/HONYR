using System;
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
        
        public List<String> GetSymbols()
        {
            return symbolOP.GetSymbols();
        }
        
        public List<String> GetSymbolById(int id)
        {
            return symbolOP.GetSymbolById(id);
        }
    }
}
