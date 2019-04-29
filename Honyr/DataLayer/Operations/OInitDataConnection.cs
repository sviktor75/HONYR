using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataLayer.Operations
{
    public class OInitDataConnection
    {

        static string connString = "SERVER=sql.autodl.de;PORT=3306;DATABASE=leltar;UID=ppeti;PASSWORD=ppeti;encrypt=false;";


        public MySqlConnection conn = new MySqlConnection(connString);
        
        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
