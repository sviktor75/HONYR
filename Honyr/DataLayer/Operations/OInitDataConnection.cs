using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace DataLayer.Operations
{
    public class OInitDataConnection
    {

        ODecrypt decrypt = new ODecrypt();

        public MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string username;
        private string password;
        private string dataBaseServerSettingsFile;

        public OInitDataConnection()
        {
            Initialize();
        }


    public void Initialize()
        {
            List<string> dbServerSettings = new List<string>();
            string dataBaseServerSettingsFile = "dbsettings.config";

            if (File.Exists(dataBaseServerSettingsFile))
            {
                using (StreamReader sr = File.OpenText(dataBaseServerSettingsFile))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        dbServerSettings.Add(line);
                    }
                };
                server = dbServerSettings[0];
                port = dbServerSettings[1];
                database = dbServerSettings[2];
                username = dbServerSettings[3];
                password = decrypt.decrypt(dbServerSettings[4]);

                string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + database + ";UID=" + username + ";PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
            }
            else
            {
              //  MessageBox.Show("Az adatbázis szerver még nem lett beállítva.");
            }

        }

        public bool OpenConnection()
        {
                try
                {
                    connection.Open();
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
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
