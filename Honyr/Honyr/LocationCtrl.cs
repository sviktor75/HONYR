using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Business;


namespace Honyr
{
    public partial class addLocationCtrl : UserControl
    {
        bool vissza = false;
        public addLocationCtrl()
        {
            InitializeComponent();
        }


        private void btnMegse_Click_1(object sender, EventArgs e)
        {
            btnUj.Enabled = true;
            btnMentes.Enabled = false;
            btnKeres.Enabled = true;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            txtAzonosito.Enabled = false;
            txtMegenevezes.Enabled = false;
            comboTipus.Enabled = false;
            comboParent.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            if (vissza)
            {
                SendToBack();
            }
            
        }

        private void addLocationCtrl_Load(object sender, EventArgs e)
        {
            this.Controls.ClearControls();

            btnUj.Enabled = true;
            btnMentes.Enabled = false;
            btnKeres.Enabled = true;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            txtAzonosito.Enabled = false;
            txtMegenevezes.Enabled = false;
            comboTipus.Enabled = false;
            comboParent.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            vissza = true;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            BLocation location = new BLocation();

            int effectedRows = location.AddLocation(txtMegenevezes.Text, comboTipus.Text, long.Parse(comboParent.Text), int.Parse(comboSymbol.Text), txtDescription.Text);

            if (effectedRows >= 0)
            {
                MessageBox.Show("Lokáció sikeresen hozzáadva.");
            }
            else
            {
                MessageBox.Show("A lokácót nem sikerült létrehozni.");
            }

            vissza = false;
            btnMegse.Click += btnMegse_Click_1;
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            this.Controls.ClearControls();

            btnUj.Enabled = false;
            btnMentes.Enabled = true;
            btnKeres.Enabled = false;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            txtAzonosito.Enabled = false;
            txtMegenevezes.Enabled = true;
            comboTipus.Enabled = true;
            comboParent.Enabled = true;
            comboSymbol.Enabled = true;
            txtDescription.Enabled = true;

            vissza = false;
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            btnUj.Enabled = false;
            btnMentes.Enabled = false;
            btnKeres.Enabled = true;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            txtAzonosito.Enabled = false;
            txtMegenevezes.Enabled = true;
            comboTipus.Enabled = false; // majd lehet így is keresni ...
            comboParent.Enabled = false; // majd lehet így is keresni ...
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            vissza = false;
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            btnUj.Enabled = false;
            btnMentes.Enabled = true;
            btnKeres.Enabled = false;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            txtAzonosito.Enabled = false;
            txtMegenevezes.Enabled = true;
            comboTipus.Enabled = true;
            comboParent.Enabled = true;
            comboSymbol.Enabled = true;
            txtDescription.Enabled = true;

            vissza = false;
        }
    }
}
