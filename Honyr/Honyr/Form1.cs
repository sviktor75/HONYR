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


namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            defaultMain1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbNotSetted();
        }

        private void portToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void passzívToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbNotSetted();

            passiveItemCtrl1.BringToFront();

            mountWall1.SendToBack();
            addLocation1.SendToBack();
            itemActiveCtrl1.SendToBack();
            typeDeclareCtrl11.SendToBack();
            

            mountWall1.resetForm();
            addLocation1.resetForm();
            itemActiveCtrl1.resetForm(); 
            passiveItemCtrl1.resetForm();
        }

        private void AktivToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            dbNotSetted();

            itemActiveCtrl1.BringToFront();

            mountWall1.SendToBack();
            addLocation1.SendToBack();
            passiveItemCtrl1.SendToBack();
            typeDeclareCtrl11.SendToBack();

            mountWall1.resetForm();
            addLocation1.resetForm();
            itemActiveCtrl1.resetForm();
            passiveItemCtrl1.resetForm();

        }

        private void HelyisegToolStripMenuItem1_Click(object sender, EventArgs e) 
        {
            dbNotSetted();

            addLocation1.BringToFront();

            mountWall1.SendToBack();
            passiveItemCtrl1.SendToBack();
            itemActiveCtrl1.SendToBack();
            typeDeclareCtrl11.SendToBack();

            mountWall1.resetForm();
            addLocation1.resetForm();
            itemActiveCtrl1.resetForm();
            passiveItemCtrl1.resetForm();
        }

        private void FaliCsatlakozoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dbNotSetted();

            mountWall1.BringToFront();

            addLocation1.SendToBack();
            passiveItemCtrl1.SendToBack();
            itemActiveCtrl1.SendToBack();
            typeDeclareCtrl11.SendToBack();

            mountWall1.resetForm();
            addLocation1.resetForm();
            itemActiveCtrl1.resetForm();
            passiveItemCtrl1.resetForm();
        }

        private void típusokMeghatározásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbNotSetted();

            typeDeclareCtrl11.BringToFront();

            mountWall1.SendToBack();
            addLocation1.SendToBack();
            passiveItemCtrl1.SendToBack();
            itemActiveCtrl1.SendToBack();

            //reset formok ide kellenek

        }

        DBConnectionSettings.DBConnectionSettings connectionSettings = new DBConnectionSettings.DBConnectionSettings();
        private void szerverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionSettings.ShowDialog();
        }

        private void dbNotSetted()
        {
            string DBServerConfigFile = "dbsettings.config";
            if (!File.Exists(DBServerConfigFile))
            {
                MessageBox.Show("Az adatbázis szerver még nem lett beállítva.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectionSettings.ShowDialog();
            }
        }
    }
}
