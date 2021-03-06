﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataLayer.Operations
{
    public class OItem
    {
        OInitDataConnection conn = new OInitDataConnection();

        public int AddItem(string deviceID, string deviceName, long locationID, int symbolID, string description, bool active)
        { 
            string query = "INSERT INTO item (deviceid, devicename, locationId, symbolid, description, active)" + " VALUES" + " ('"+ deviceID + "', '" + deviceName + "','" + locationID + "','" + symbolID + "','" + description + "'," + active + ");";
            MessageBox.Show(query);
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int ModItem(long id, string deviceID, string deviceName, long locationID, int symbolID, string description)
        {
            string query = "update item set deviceid='" + deviceID + "', devicename='" + deviceName + "', locationid='" + locationID + "', symbolid='" + symbolID + "', description='" + description + "' where id='" + id + "';";
            MessageBox.Show(query);
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int DelItem(long id)
        {
            string query = "delete from item where id='" + id + "';";
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public List<String> GetItemByName(string name, bool active)
        {
            string query = "select * from item where devicename like '" + name + "' and active=" + active + " order by devicename limit 1;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
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

        public List<String> GetItemByID(long id, bool active)
        {
            string query = "select * from item where id=" + id + " and active=" + active + ";";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
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

        public List<String> GetItemByDeviceId(string deviceId, bool active)
        {
            string query = "select * from item where deviceid like '" + deviceId + "' and active=" + active + " order by deviceid limit 1;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
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
