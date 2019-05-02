using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PresentationLayer.DBConnectionSettings
{
    public partial class DBConnectionSettings : Form
    {
        public DBConnectionSettings()
        {
            InitializeComponent();
        }
        Helpers.Encryption cryptography = new Helpers.Encryption();
        private string dbConfigFileOrPath = "dbsettings.config";

        private void btnMegse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter(dbConfigFileOrPath))
            {
                writetext.WriteLine(txtDbServer.Text);
                writetext.WriteLine(txtDbServerPort.Text);
                writetext.WriteLine(txtDatabaseSchema.Text);
                writetext.WriteLine(txtDbUsername.Text);
                writetext.WriteLine(cryptography.Encrypt(txtDbPassword.Text));
            }
            Close();
        }
    }
}
