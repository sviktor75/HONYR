using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Honyr
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

        private void locationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addLocation1.BringToFront();
            mountWall1.SendToBack();
        }

        private void portToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void faliCsatlakoz�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addLocation1.SendToBack();
            mountWall1.BringToFront();
        }
    }
}
