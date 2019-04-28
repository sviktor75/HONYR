using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataLayer.Operations
{
    public class OLocation
    {
        OInitDataConnection conn = new OInitDataConnection();

        public int AddLocation(string locationId, string name, int locationTypeId, long parentId, int symbolId, string description)
        {
            string query = "INSERT INTO location (locationid, name, locationtypeid, parentid, symbolid, description)" + " VALUES" + " ('" + locationId + "', '" + name + "', '" + locationTypeId + "', '" + parentId + "', '" + symbolId + "', '" + description + "');";
            MessageBox.Show(query);
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }


        public int ModLocation(long id, string locationId, string name, int locationTypeId, long parentId, int symbolId, string description)
        {
            string query = "update location set locationid='" + locationId+"', name='"+name+ "', locationtypeid='" + locationTypeId+"', parentid='"+parentId+"', symbolid='"+symbolId+"', description='"+description+"' where id='"+id+"';";

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
            string query = "select locationid from location;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                retList.Add(dataReader["locationid"] + "");
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
                retList.Add(dataReader["locationid"] + "");
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

        public int GetididByLocationid(string locationid)
        {
            string query = "select id from location where locationid = '" + locationid + "';";

            int id=0;

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                id = int.Parse(dataReader["id"] + "");
            }
            conn.CloseConnection();

            return id;

        }

        public string GetLocationidByID(int id)
        {
            string query = "select locationid from location where id=" + id + ";";

            string retString = "";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                retString = dataReader["locationid"] + "";
            }

            dataReader.Close();
            conn.CloseConnection();

            return retString;

        }
            

    }
}

