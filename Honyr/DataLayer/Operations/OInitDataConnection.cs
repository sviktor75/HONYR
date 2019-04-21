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
        static string connString = "Server=sql.celofan.eu;Database=leltar;port=3306;UID=ppeti;password=ppeti;";
        public MySqlConnection conn = new MySqlConnection(connString);

        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                MessageBox.Show("successful connection");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connString);
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                conn.Close();
                MessageBox.Show("successful detach");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connString);
            }
        }
    }
}
