using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer.Operations
{
    public class OItem
    {
        OInitDataConnection conn = new OInitDataConnection();

        bool active = true;

        public int AddItem(bool active, string deviceID, string deviceName, string ip, string mac, long locationid, int symbolId, string description)
        {
            this.active = active;  
            string query = "INSERT INTO item (active, deviceID, deviceName, ip, mac, locationid, symbolid, description)" + " VALUES" + " ('" + active + "', '" + deviceID + "', '" + deviceName + "', '" + ip + "', '" + mac + "', '" + locationid + "','" + symbolId + "','" + description + "');";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }


        public int ModItem(long id, bool active, string deviceID, string deviceName, string ip, string mac, long locationid, int symbolId, string description)
        {
            this.active = active;
            string query = "update item set active='" + active + "', deviceID='" + deviceID + "', deviceName='" + deviceName + "', ip='" + ip + "', mac='" + mac + "', locationid='" + locationid + "', symbolid='" + symbolId + "', description='" + description + "' where id='" + id + "';";
            MessageBox.Show(query);
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int DelItem(long id)
        {
            
            string query = "delete from item where id='" + id + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public List<String> GetItemLoctaion()
        {
            string query = "select locationid from item;";

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


        public List<String> GetItemByName(string name, bool active)
        {
            string query = "select * from item where name like '" + name + "' AND active = '"+ active +"'  order by name limit 1;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                retList.Add(dataReader["id"] + "");
                retList.Add(dataReader["active"] + "");
                retList.Add(dataReader["deviceID"] + "");
                retList.Add(dataReader["deviceName"] + "");
                retList.Add(dataReader["ip"] + "");
                retList.Add(dataReader["mac"] + "");
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
