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
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

        public int ModType(string type, string name)
        {
            string query = "";
            switch (type)
            {
                case "helyiség":
                    query = "update locationtype set name='" + name + "' where name='" + name + "';";
                    break;

                case "szimbólum":
                    query = "update symboltype set name='" + name + "' where name='" + name + "';";
                    break;

                case "fali csatlakozó":
                    query = "update connectortype set name='" + name + "' where name='" + name + "';";
                    break;
                /*
                                case "aktív eszköz":
                                    query = "update type set name='" + name + "' where name='" + name + "';";
                                    break;

                                case "passzív eszköz":
                                    query = "update type set name='" + name + "' where name='" + name + "';";
                                    break;

                                case "aktív port":
                                    query = "update type set name='" + name + "' where name='" + name + "';";
                                    break;

                                case "passzív port":
                                    query = "update type set name='" + name + "' where name='" + name + "';";
                                    break;
                */
                case "port":
                    query = "update portphysicaltype set name='" + name + "' where name='" + name + "';";
                    break;
            }
            conn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn.conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.CloseConnection();
            return effectedRows;
        }

    }
}
