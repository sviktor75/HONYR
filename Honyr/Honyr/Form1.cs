using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            
        }

        private void portToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void passzívToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passiveItemCtrl1.BringToFront();

            mountWall1.SendToBack();
            addLocation1.SendToBack();
            itemActiveCtrl1.SendToBack();

            mountWall1.reset();
            addLocation1.resetForm();
            itemActiveCtrl1.resetForm(); 
            passiveItemCtrl1.resetForm();
        }

        private void AktivToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            itemActiveCtrl1.BringToFront();

            mountWall1.SendToBack();
            addLocation1.SendToBack();
            passiveItemCtrl1.SendToBack();

            mountWall1.reset();
            addLocation1.resetForm();
            itemActiveCtrl1.resetForm();
            passiveItemCtrl1.resetForm();

        }

        private void HelyisegToolStripMenuItem1_Click(object sender, EventArgs e) 
        {
            addLocation1.BringToFront();

            mountWall1.SendToBack();
            passiveItemCtrl1.SendToBack();
            itemActiveCtrl1.SendToBack();

            mountWall1.reset();
            addLocation1.resetForm();
            itemActiveCtrl1.resetForm();
            passiveItemCtrl1.resetForm();
        }

        private void FaliCsatlakozoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mountWall1.BringToFront();

            addLocation1.SendToBack();
            passiveItemCtrl1.SendToBack();
            itemActiveCtrl1.SendToBack();

            mountWall1.reset();
            addLocation1.resetForm();
            itemActiveCtrl1.resetForm();
            passiveItemCtrl1.resetForm();
        }

        private void típusokMeghatározásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
