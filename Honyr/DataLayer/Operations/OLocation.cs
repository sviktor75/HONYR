using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DataLayer.Entities;

namespace DataLayer.Operations
{
    public class OLocation
    {
        OInitDataConnection conn = new OInitDataConnection();

        public int AddLocation(ELocation location)
        {
            string query = "INSERT INTO location (name, locationtype, parentid, symbolid, description)"+" VALUES" + " ('"+location.Name+"', '"+location.LocationType+"', '"+location.ParentId+"', '"+location.SymbolId+"', '"+location.Description+"');";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery(); // sql query végrehajtása
            conn.CloseConnection();
            return effectedRows;
        }

        public void ModLocation()
        {

        }

        public void DelLocation()
        {

        }

        public void GetLocationById()
        {

        }
    }
}
