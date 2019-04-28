using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataLayer.Operations
{
    public class OItem
    {
        OInitDataConnection conn = new OInitDataConnection();

        public int AddItem(string deviceID, string deviceName, long locationID, int symbolID, string description)
        { 
            string query = "INSERT INTO itemactive (deviceid, devicename, locationId, symbolid, description)" + " VALUES" + " ('"+ deviceID + "', '" + deviceName + "','" + locationID + "','" + symbolID + "','" + description + "');";
            MessageBox.Show(query);
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }


        public int ModItem(long id, string deviceID, string deviceName, long locationID, int symbolID, string description)
        {
            string query = "update itemactive set deviceid='" + deviceID + "', devicename='" + deviceName + "', locationid='" + locationID + "', symbolid='" + symbolID + "', description='" + description + "' where id='" + id + "';";
            MessageBox.Show(query);
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int DelItem(long id)
        {
            
            string query = "delete from itemactive where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }


        public List<String> GetItemByName(string name)
        {
            string query = "select * from itemactive where devicename like '" + name + "' order by devicename limit 1;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                retList.Add(dataReader["id"] + "");
                retList.Add(dataReader["deviceid"] + "");
                retList.Add(dataReader["devicename"] + "");
                retList.Add(dataReader["locationid"] + "");
                retList.Add(dataReader["symbolid"] + "");
                retList.Add(dataReader["description"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();
            return retList;

        }

        public List<String> GetItemByID(long id)
        {
            string query = "select * from itemactive where id=" + id+";";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                retList.Add(dataReader["id"] + "");
                retList.Add(dataReader["deviceid"] + "");
                retList.Add(dataReader["devicename"] + "");
                retList.Add(dataReader["locationid"] + "");
                retList.Add(dataReader["symbolid"] + "");
                retList.Add(dataReader["description"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();
            return retList;

        }

        public List<String> GetItemByDeviceID(string deviceID)
        {
            string query = "select * from itemactive where deviceid=" + deviceID + ";";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                retList.Add(dataReader["id"] + "");
                retList.Add(dataReader["deviceid"] + "");
                retList.Add(dataReader["devicename"] + "");
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
