using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataLayer.Operations
{
    public class OWallConnector
    {
        OInitDataConnection conn = new OInitDataConnection();

        public int AddConnector(string connectorId, string name, string connectorType, string connectorProperty, int locationId, int symbolId, string description)
        {
            string query = "INSERT INTO WallConnector (connectorid, name, type, property, locationid, symbolid, description)" + " VALUES" + " ('" + connectorId + "','" + name + "', '" + connectorType + "', '" + connectorProperty + "', '" + locationId + "', '" + symbolId + "', '" + description + "');";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }


        public int ModConnector(long id, string connectorID, string name, string connectorType, string connectorProperty, int locationId, int symbolId, string description)
        {
            string query = "update WallConnector set connectorId='" + connectorID + "', name='" + name + "', type='" + connectorType + "', property='" + connectorProperty + "', locationid='" + locationId + "', symbolid='" + symbolId + "', description='" + description + "' where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int DelConnector(long id)
        {
            string query = "delete from WallConnector where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public List<String> GetConnector()
        {
            string query = "select connectorid from WallConnector;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                retList.Add(dataReader["connectorid"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }


        public List<String> GetConnectorByName(string name)
        {
            string query = "select * from WallConnector where name like '" + name + "' order by name limit 1;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                retList.Add(dataReader["id"] + "");
                retList.Add(dataReader["connectorid"] + "");
                retList.Add(dataReader["name"] + "");
                retList.Add(dataReader["type"] + "");
                retList.Add(dataReader["property"] + "");
                retList.Add(dataReader["locationid"] + "");
                retList.Add(dataReader["symbolid"] + "");
                retList.Add(dataReader["description"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;

        }
    }
}
