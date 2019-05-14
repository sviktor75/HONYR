using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataLayer.Operations
{
    public class OCommonBase
    {
        OInitDataConnection conn = new OInitDataConnection();

        public List <String> BaseSearch(string table, string columnname, string searchstring)
        {
            string query = "select * from " + table + " where " + columnname + " like '" + searchstring + "' order by name limit 1;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            int i = 0;

            while (dataReader.Read())
            {
                retList.Add(dataReader.GetValue(i).ToString());
                i++;
            }

            dataReader.Close();
            conn.CloseConnection();

            return retList;

        }
    }
}
