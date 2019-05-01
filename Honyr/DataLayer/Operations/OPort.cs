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

        public int AddPortActive(int portnumber, string portID, string portName, string portConfig, string portPhysicalType, long itemId)
        {
            string query = "INSERT INTO portactive (itemid, portnumber, portid, portname, portconfig, portphysicaltype )" + " VALUES" + " ('" + itemId + "', '" + portnumber + "', '" + portID + "', '" + portName + "', '" + portConfig + "', '" + portPhysicalType + "');";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int AddPortPassive(long itemId, int portnumber, string portID, string portPhysicalType)
        {
            string query = "INSERT INTO portpassive (itemid, portnumber, portid, portphysicaltype)" + " VALUES" + " ( '" + itemId + "', '" + portnumber + "', '" + portID + "', '" + portPhysicalType + "');";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

                                          
        public int ModPortActive(long id, int portnumber, string portID, string portName, string portConfig, string portPhysicalType, long itemId)
        {
            string query = "update portactive set itemid='" + itemId + "', portnumber='" + portnumber + "', portid='" + portID + "', portname='" + portName + "', portconfig='" + portConfig + "', portphysicaltype='" + portPhysicalType + "',  where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }


        public int ModPortPassive(long id, int portnumber, string portID, string portPhysicalType, long itemId)
        {
            string query = "update portpassive set itemid='" + itemId + "', portnumber='" + portnumber + "', portid='" + portID + "', portphysicaltype='" + portPhysicalType + "'  where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

                                  
        public int DelPortActive(long id)
        {

            string query = "delete from portactive where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int DelPortPassive(long id)
        {
            string query = "delete from portpassive where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public List<String> GetPortsByItemId(long itemid, bool active)
        {
            string query="";

            if (active)
            {
                query = "select portnumber from portactive where itemid=" + itemid + ";";
            }
            else
            {
                query = "select portnumber from portpassive where itemid=" + itemid + ";";
            }
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

        public List<string> GetPortDetailsByPortNumber(long itemid, int portnumber)
        {
            string query = "select * from portactive where itemid=" + itemid + " AND portnumber=" + portnumber +";";
            
            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                retList.Add(dataReader["portid"] + "");
                retList.Add(dataReader["portphysicaltype"] + "");
                retList.Add(dataReader["portname"] + "");
                retList.Add(dataReader["portconfig"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }

        //   ----  Egyenlőre nem kell ------
        //public List<String> GetPortByName(string portName)
        //{
        //    string query = "select * from port where portName like '" + portName + "' order by name limit 1;";

        //    List<string> retList = new List<string>();

        //    conn.OpenConnection();
        //    MySqlCommand cmd = new MySqlCommand(query, conn.conn);
        //    MySqlDataReader dataReader = cmd.ExecuteReader();


        //    while (dataReader.Read())
        //    {
        //        retList.Add(dataReader["id"] + "");
        //        retList.Add(dataReader["portnumber"] + "");
        //        retList.Add(dataReader["portID"] + "");
        //        retList.Add(dataReader["portName"] + "");
        //        retList.Add(dataReader["portConfig"] + "");
        //        retList.Add(dataReader["portPhysicalType"] + "");
        //    }
        //    dataReader.Close();
        //    conn.CloseConnection();

        //    return retList;

        //}
    }
}
