using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataLayer.Operations
{
    public class OSymbol
    {

        OInitDataConnection conn = new OInitDataConnection();

        public List<String> GetSymbols()
        {
            string query = "select name from symbol;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                retList.Add(dataReader["name"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }



        public List <String> GetSymbolById(int id)
        {
            string query = "select * from symbol where id='" + id + "';";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                retList.Add(dataReader["name"] + "");
                retList.Add(dataReader["image"] + "");
            }

            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }

    }
}
