using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Operations
{
    public class OPort
    {
        OInitDataConnection conn = new OInitDataConnection();

        public int AddPort(int portnumber, string portID, string portName, string portConfig, string portPhysicalType, long itemId)
        {
            string query = "INSERT INTO port (portnumber, portID, portName, portConfig, portPhysicalType, itemId)" + " VALUES" + " ('" + portnumber + "', '" + portID + "', '" + portName + "', '" + portConfig + "', '" + portPhysicalType + "', '" + itemId + "');";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int ModPort(long id, int portnumber, string portID, string portName, string portConfig, string portPhysicalType, long itemId)
        {
            string query = "update port set portnumber='" + portnumber + "', portID='" + portID + "', portName='" + portName + "', portConfig='" + portConfig + "', portPhysicalType='" + portPhysicalType + "', itemId='" + itemId + "' where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }


        public int DelPort(long id)
        {

            string query = "delete from port where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }


        public List<String> GetPorts()
        {
            string query = "select portNumber from port;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                retList.Add(dataReader["portnumber"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }

        public List<String> GetPortByName(string portName)
        {
            string query = "select * from port where portName like '" + portName + "' order by name limit 1;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                retList.Add(dataReader["id"] + "");
                retList.Add(dataReader["portnumber"] + "");
                retList.Add(dataReader["portID"] + "");
                retList.Add(dataReader["portName"] + "");
                retList.Add(dataReader["portConfig"] + "");
                retList.Add(dataReader["portPhysicalType"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;

        }
    }
}
