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
using System.IO;

namespace Honyr
{
    public partial class WallMount : UserControl
    {
        BSymbol symbol = new BSymbol();
        BWallConnector wc = new BWallConnector();

        bool vissza = false;
        bool uj = false;
        bool modosit = false;

        public WallMount()
        {
            InitializeComponent();
        }


        private void WallMount_Load(object sender, EventArgs e)
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

            txtKeres.Visible = false;
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
                this.Controls.ClearControls();
            }

            vissza = true;
            uj = false;
            modosit = false;

            txtKeres.Visible = false;
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

            txtKeres.Visible = false;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (uj)
            {
                int effectedRows = wc.AddConnector(txtAzonosito.Text, txtMegenevezes.Text, comboTipus.Text, txtKialakitas.Text, int.Parse(comboParent.Text), comboSymbol.SelectedIndex + 1, txtDescription.Text);

                if (effectedRows >= 0)
                {
                    MessageBox.Show("Fali csatlakozó sikeresen hozzáadva.");
                }
                else
                {
                    MessageBox.Show("A fali csatlakozót nem sikerült létrehozni.");
                }

                uj = false;
            }

            if (modosit)
            {
                int effectedRows = wc.ModConnector(long.Parse(txtIndex.Text), txtAzonosito.Text, txtMegenevezes.Text, comboTipus.Text, txtKialakitas.Text, int.Parse(comboParent.Text), comboSymbol.SelectedIndex + 1, txtDescription.Text);

                if (effectedRows >= 0)
                {
                    MessageBox.Show("Fali csatlakozó sikeresen módosítva.");
                }
                else
                {
                    MessageBox.Show("A fali csatlakozót nem sikerült Módosítani.");
                }

                modosit = false;
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

            comboParent.DataSource = wc.GetConnecctor();
            comboSymbol.DataSource = symbol.GetSymbols();
            kepBetoltes();


            vissza = false;
            uj = true;
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            btnUj.Enabled = false;
            btnMentes.Enabled = false;
            btnKeres.Enabled = true;
            btnModosit.Enabled = true;
            btnTorol.Enabled = true;
            btnMegse.Enabled = true;

            txtAzonosito.Enabled = false;
            txtMegenevezes.Enabled = false;
            comboTipus.Enabled = false; // majd lehet így is keresni ... csak meg kell írni hozzá a metódust
            comboParent.Enabled = false; // majd lehet így is keresni ...
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            vissza = false;

            txtKeres.Visible = true;
            txtKeres.Focus();
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

            comboParent.DataSource = wc.GetConnecctor();
            comboSymbol.DataSource = symbol.GetSymbols();

            vissza = false;

            txtKeres.Visible = false;

            modosit = true;
        }


        private void txtKeres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            int effectedRows = wc.DelConnector(long.Parse(txtIndex.Text));

            if (effectedRows >= 0)
            {
                MessageBox.Show("Fali csatlakozó sikeresen törölve.");
            }
            else
            {
                MessageBox.Show("A fali csatlakozót nem sikerült törölni.");
            }

            this.Controls.ClearControls();
            btnMegse.PerformClick();
        }

        private void kepBetoltes()
        {
            List<object> kep = symbol.GetSymbolById(comboSymbol.SelectedIndex + 1);
            comboSymbol.Text = kep[0].ToString();
            MemoryStream ms = new MemoryStream((byte[])kep[1]);
            picSymbol.Image = Image.FromStream(ms);
        }

        private void comboSymbol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            kepBetoltes();
        }


    }
}

