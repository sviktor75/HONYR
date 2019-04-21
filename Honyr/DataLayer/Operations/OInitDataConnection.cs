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
        string connString = "Server=sql.celofan.eu;Database=leltar;port=3306;UID=ppeti;password=ppeti;";
        MySqlConnection conn = new MySqlConnection(connString);

        public void OpenConnection()
        {
            try
            {
                conn.Open();
                MessageBox.Show("successful connection");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
                MessageBox.Show("successful detach");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }
        }
    }
}
