using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataLayer.Operations
{
    public class OLocation
    {
        OInitDataConnection conn = new OInitDataConnection();

        public int AddLocation(string locationId, string name, string locationType, string parentId, int symbolId, string description)
        {
            string query = "INSERT INTO location (locationId, name, locationtype, parentid, symbolid, description)"+" VALUES" + " ('"+locationId+"', '"+name+"', '"+locationType+"', '"+parentId+"', '"+symbolId+"', '"+description+"');";

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

        public List<String> GetLocations()
        {
            string query = "select locationId from location";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                retList.Add(dataReader["locationId"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }


        public void GetLocationById()
        {

        }
    }
}
