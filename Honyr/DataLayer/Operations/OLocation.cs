using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataLayer.Operations
{
    public class OLocation
    {
        OInitDataConnection conn = new OInitDataConnection();

        public int AddLocation(string locationId, string name, string locationType, long parentId, int symbolId, string description)
        {
            string query = "INSERT INTO location (locationId, name, locationtype, parentid, symbolid, description)" + " VALUES" + " ('" + locationId + "', '" + name + "', '" + locationType + "', '" + parentId + "', '" + symbolId + "', '" + description + "');";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }


        public int ModLocation(long id, string locationId, string name, string locationType, long parentId, int symbolId, string description)
        {
            string query = "update location set locationId='"+locationId+"', name='"+name+"', locationtype='"+locationType+"', parentid='"+parentId+"', symbolid='"+symbolId+"', description='"+description+"' where id='"+id+"';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int DelLocation(long id)
        {
            string query = "delete from location where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public List<String> GetLocations()
        {
            string query = "select locationId from location;";

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


        public List<String> GetLocationByName(string name)
        {
            string query = "select * from location where name like '"+name+"' order by name limit 1;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                retList.Add(dataReader["id"] + "");
                retList.Add(dataReader["locationId"] + "");
                retList.Add(dataReader["name"] + "");
                retList.Add(dataReader["locationtype"] + "");
                retList.Add(dataReader["parentid"] + "");
                retList.Add(dataReader["symbolid"] + "");
                retList.Add(dataReader["description"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;

        }

        public void GetLocationidByID()
        {

        }
    }
}
