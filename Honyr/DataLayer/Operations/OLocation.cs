using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Operations
{
    public class OLocation
    {
        public void AddLocation(string name, string locationtype, long parentid, int symbolid, string description)
        {
            this.name = name;
            this.locationtype = locationtypre;
            this.parentid = parentid;
            this.symbolid = symbolid;
            this.description = description;

            OInitDataConnection.OpenConnection();
            string query = "INSERT INTO location (name, location, parentid, symbolid, description) VALUES("+name+", "+locationtype+", "+parentid+", "+symbolid+", "+description+");";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
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
