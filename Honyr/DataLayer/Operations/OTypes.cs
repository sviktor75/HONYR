using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataLayer.Operations
{
    public class OTypes
    {
        OInitDataConnection conn = new OInitDataConnection();

        public int AddType(string type, string name)
        {
            string query = "";
            switch (type)
            {
                case "helyiség":
                    query = "INSERT INTO locationtype (name)" + " VALUES" + " ('" + name + "');";
                    break;

                case "szimbólum":
                    query = "INSERT INTO symboltype (name)" + " VALUES" + " ('" + name + "');";
                    break;

                case "fali csatlakozó":
                    query = "INSERT INTO connectortype (name)" + " VALUES" + " ('" + name + "');";
                    break;
                /*
                                case "aktív eszköz":
                                    query = "INSERT INTO locationtype (name)" + " VALUES" + " ('" + name + "');";
                                    break;

                                case "passzív eszköz":
                                    query = "INSERT INTO locationtype (name)" + " VALUES" + " ('" + name + "');";
                                    break;

                                case "aktív port":
                                    query = "INSERT INTO locationtype (name)" + " VALUES" + " ('" + name + "');";
                                    break;

                                case "passzív port":
                                    query = "INSERT INTO locationtype (name)" + " VALUES" + " ('" + name + "');";
                                    break;
                */
                case "port":
                    query = "INSERT INTO portphysicaltype (name)" + " VALUES" + " ('" + name + "');";
                    break;
            }
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int ModType(string type, int id, string name)
        {
            string query = "";
            switch (type)
            {
                case "helyiség":
                    query = "update locationtype set name='" + name + "' where id='" + id + "';";
                    break;

                case "szimbólum":
                    query = "update symboltype set name='" + name + "' where id='" + id + "';";
                    break;

                case "fali csatlakozó":
                    query = "update connectortype set name='" + name + "' where id='" + id + "';";
                    break;
                /*
                                case "aktív eszköz":
                                    query = "update type set name='" + name + "' where id='" + id + "';";
                                    break;

                                case "passzív eszköz":
                                    query = "update type set name='" + name + "' where id='" + id + "';";
                                    break;

                                case "aktív port":
                                    query = "update type set name='" + name + "' where id='" + id + "';";
                                    break;

                                case "passzív port":
                                    query = "update type set name='" + name + "' where id='" + id + "';";
                                    break;
                */
                case "port":
                    query = "update portphysicaltype set name='" + name + "' where name='" + id + "';";
                    break;
            }
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int DelType(string type, int id)
        {
            string query = "";
            switch (type)
            {
                case "helyiség":
                    query = "delete from locationtype where name='" + id + "';";
                    break;

                case "szimbólum":
                    query = "delete from symboltype where name='" + id + "';";
                    break;

                case "fali csatlakozó":
                    query = "delete from connectortype where name='" + id + "';";
                    break;
                /*
                                case "aktív eszköz":
                                    query = "delete from symboltype where name='" + id + "';";
                                    break;

                                case "passzív eszköz":
                                    query = "delete from symboltype where name='" + id + "';";
                                    break;

                                case "aktív port":
                                    query = "delete from symboltype where name='" + id + "';";
                                    break;

                                case "passzív port":
                                    query = "delete from symboltype where name='" + id + "';";
                                    break;
                */
                case "port":
                    query = "delete from portphysicaltype where name='" + id + "';";
                    break;
            }
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public List<String> GetTypeByName(string type, string name)
        {
            string ttype = translate(type);
            string query = "select * from " + ttype + " where name like '" + name + "' order by name limit 1;";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                retList.Add(dataReader["id"] + "");
                retList.Add(dataReader["name"] + "");
            }
            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }

        public List<string> GetTypeById(string type, int id)
        {
            string ttype = translate(type);
            string query = "select * from " + ttype + " where id='" + id + "';";

            List<string> retList = new List<string>();

            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                retList.Add(dataReader["id"] + "");
                retList.Add(dataReader["name"] + "");
            }

            dataReader.Close();
            conn.CloseConnection();

            return retList;
        }

        static string translate(string type)
        {
            string ttype = "";
            switch (type)
            {
                case "helyiség":
                    ttype="locationtype";
                    break;

                case "szimbólum":
                    ttype = "symboltype";
                    break;

                case "fali csatlakozó":
                    ttype = "connectortype";
                    break;
                /*
                                case "aktív eszköz":
                                    ttype = "connectortype";
                                    break;

                                case "passzív eszköz":
                                    ttype = "connectortype";
                                    break;

                                case "aktív port":
                                    ttype = "connectortype";
                                    break;

                                case "passzív port":
                                    ttype = "connectortype";
                                    break;
                */
                case "port":
                    ttype = "portphysicaltype";
                    break;
            }
            return ttype;
        }
    }
}
