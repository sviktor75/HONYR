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
        BLocation location = new BLocation();

        bool vissza = false;
        bool kereses = false;

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

            vissza = true;
            
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

            int effectedRows = location.AddLocation(txtAzonosito.Text, txtMegenevezes.Text, comboTipus.Text, comboParent.Text, int.Parse(comboSymbol.Text), txtDescription.Text);

            if (effectedRows >= 0)
            {
                MessageBox.Show("Lokáció sikeresen hozzáadva.");
            }
            else
            {
                MessageBox.Show("A lokácót nem sikerült létrehozni.");
            }

            vissza = false;
            this.Controls.ClearControls();
            btnMegse.PerformClick();
            
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

            txtAzonosito.Enabled = true;
            txtMegenevezes.Enabled = true;
            comboTipus.Enabled = true;
            comboParent.Enabled = true;
            comboSymbol.Enabled = true;
            txtDescription.Enabled = true;

            comboParent.DataSource = location.GetLocations();

            vissza = false;
            kereses = false;
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
            kereses = true; // oda figyelni mikor kell kikapcsolni !!!

            txtMegenevezes.Focus();
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            btnUj.Enabled = false;
            btnMentes.Enabled = true;
            btnKeres.Enabled = false;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            txtAzonosito.Enabled = true;
            txtMegenevezes.Enabled = true;
            comboTipus.Enabled = true;
            comboParent.Enabled = true;
            comboSymbol.Enabled = true;
            txtDescription.Enabled = true;

            comboParent.DataSource = location.GetLocations();

            vissza = false;
            kereses = false;
        }

        private void txtMegenevezes_TextChanged(object sender, EventArgs e)
        {
            List<string>[] sor = location.GetLocationByName(txtMegenevezes.Text.ToString() + "%"); // ezt nem muszaly átadni .... 

            string valami = sor[0].ToString(); // ez úgy sem kell
            txtAzonosito.Text = sor[1].ToString();
            txtMegenevezes.Text = sor[2].ToString();
            comboTipus.Text = sor[3].ToString();
            comboParent.Text = sor[4].ToString();
            comboSymbol.Text = sor[5].ToString();
            txtDescription.Text = sor[6].ToString();

        }
    }
}
