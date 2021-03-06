﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataLayer.Operations
{
    public class OSymbol
    {
        OInitDataConnection conn = new OInitDataConnection();

        public List<String> GetSymbols(int symboltypeid)
        {
            string query = "select name from symbol where symboltypeid like '" + symboltypeid + "';";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                retList.Add(dataReader["name"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }


        public DataTable GetSymbolsByType(int symboltypeid)
        {
            string query = "select name, id from symbol where symboltypeid like '" + symboltypeid + "';";

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            
            conn.CloseConnection();

            return dt;
        }


        public List <object> GetSymbolById(int id)
        {

            string query = "select * from symbol where id='" + id + "';";

            List<object> retList = new List<object>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            /*MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            da.Fill(table);
            retList.Add(table.Rows[0][1].ToString());
            byte[] img = (byte[])table.Rows[0][2];
            retList.Add(img);
            */

            while (dataReader.Read())
            {
                retList.Add(dataReader["name"] + "");
                retList.Add((byte[])(dataReader["image"]));
            }

            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }

    }
}
