using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DataLayer.Operations
{
    public class OLocation
    {
        OInitDataConnection db = new OInitDataConnection();
        public void AddLocation(string name, string locationtype, string parentid, string symbolid, string description)
        {

            //db.OpenConnection();
            string query = "INSERT INTO location (name, locationtype, parentid, symbolid, description) VALUES('"+name+"', '"+locationtype+"', '"+parentid+"', '"+symbolid+"', '"+description+"');";

            //open connection
            if (db.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, db.conn);

                //Execute command
                
                cmd.ExecuteNonQuery();

                //close connection
                db.CloseConnection();
            }
        }

        public void ModLocation()
        {

        }

        public void DelLocation()
        {

        }

        public void GetLocationById()
        {

        }
    }
}
