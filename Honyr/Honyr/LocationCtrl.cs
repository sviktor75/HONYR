﻿using System;
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


namespace PresentationLayer
{
    public partial class addLocationCtrl : UserControl
    {
        BLocation location = new BLocation();
        BSymbol symbol = new BSymbol();
        BCommonBase cbase = new BCommonBase();
        BTypes ttype = new BTypes();

        bool vissza = false;
        bool uj = false;
        bool modosit = false;

        public void resetForm() { this.Controls.ClearControls(); }

        public addLocationCtrl()
        {
            InitializeComponent();
        }


        private void btnMegse_Click_1(object sender, EventArgs e)
        {
            btnUj.Enabled = true;
            btnMentes.Enabled = false;
            btnMentesMint.Enabled = false;
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

            this.Controls.ClearControls<ComboBox>();
            this.Controls.ClearControls<PictureBox>();

            if (vissza)
            {
                SendToBack();
                resetForm();
            }

            vissza = true;
            uj = false;
            modosit = false;

            kereses(false);
        }

        private void addLocationCtrl_Load(object sender, EventArgs e)
        {
            resetForm();

            btnUj.Enabled = true;
            btnMentes.Enabled = false;
            btnMentesMint.Enabled = false;
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

            comboTipus.DataSource = location.GetLocationsTable();
            comboTipus.DisplayMember = "name";
            comboTipus.ValueMember = "id";

            comboParent.DataSource = location.GetLocationsTable();
            comboParent.DisplayMember = "name";
            comboParent.ValueMember = "id";

            comboSymbol.DataSource = symbol.GetSymbolsByType(1);
            comboSymbol.DisplayMember = "name";
            comboSymbol.ValueMember = "id";

            vissza = true;

            kereses(false);
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if ((txtAzonosito.Text != "") || (txtMegenevezes.Text != ""))
            {
                if (uj)
                {
                    int effectedRows = location.AddLocation(txtAzonosito.Text, txtMegenevezes.Text, Convert.ToInt32(comboTipus.SelectedValue), Convert.ToInt64(comboParent.SelectedValue), Convert.ToInt32(comboSymbol.SelectedValue), txtDescription.Text);

                    if (effectedRows >= 0)
                    {
                        MessageBox.Show("Lokáció sikeresen hozzáadva.");
                    }
                    else
                    {
                        MessageBox.Show("A lokácót nem sikerült létrehozni.");
                    }

                    uj = false;
                }

                if (modosit)
                {
                    int effectedRows = location.ModLocation(long.Parse(txtIndex.Text), txtAzonosito.Text, txtMegenevezes.Text, Convert.ToInt32(comboTipus.SelectedValue), Convert.ToInt64(comboParent.SelectedValue), Convert.ToInt32(comboSymbol.SelectedValue), txtDescription.Text);

                    if (effectedRows >= 0)
                    {
                        MessageBox.Show("Lokáció sikeresen módosítva.");
                    }
                    else
                    {
                        MessageBox.Show("A lokácót nem sikerült Módosítani.");
                    }

                    modosit = false;
                }

                vissza = false;
                this.Controls.ClearControls();
                btnMegse.PerformClick();
            }
            else
            {
                MessageBox.Show("A megnevezést és azonosító mezők  nem lehetnek üresek!");
            }
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            resetForm();

            btnUj.Enabled = false;
            btnMentes.Enabled = true;
            btnMentesMint.Enabled = false;
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
            
            comboTipus.DataSource = location.GetLocationsTable();
            comboTipus.DisplayMember = "name";
            comboTipus.ValueMember = "id";

            comboParent.DataSource = location.GetLocationsTable();
            comboParent.DisplayMember = "name";
            comboParent.ValueMember = "id";

            comboSymbol.DataSource = symbol.GetSymbolsByType(1);
            comboSymbol.DisplayMember = "name";
            comboSymbol.ValueMember = "id";
            
            //MessageBox.Show(comboSymbol.SelectedValue.ToString());

            kepBetoltes();

            vissza = false;
            uj = true;
        }


        private void btnKeres_Click(object sender, EventArgs e)
        {
            if (cbase.BaseSearch("location", "id", "1").Count > 0)
            {
                btnUj.Enabled = false;
                btnMentes.Enabled = false;
                btnMentesMint.Enabled = false;
                btnKeres.Enabled = true;
                btnModosit.Enabled = true;
                btnTorol.Enabled = true;
                btnMegse.Enabled = true;

                txtAzonosito.Enabled = false;
                txtMegenevezes.Enabled = false;
                comboTipus.Enabled = false;
                comboParent.Enabled = false;
                comboSymbol.Enabled = false;
                txtDescription.Enabled = false;

                vissza = false;

                kereses(true);
            }
            else
            {
                MessageBox.Show("Üres az helyiségek tábla, nincs mit keresni benne!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModosit_Click(object sender, EventArgs e)
        {
            if (txtAzonosito.Text != "")
            {
                btnUj.Enabled = false;
                btnMentes.Enabled = true;
                btnMentesMint.Enabled = true;
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

                int ptipus, pparent;

                if (comboTipus.Text != "")
                {
                    ptipus = Convert.ToInt32(comboTipus.SelectedValue);
                    comboTipus.DataSource = location.GetLocationsTable();
                    comboTipus.DisplayMember = "name";
                    comboTipus.ValueMember = "id";
                    comboTipus.SelectedValue = ptipus;
                }

                if (comboParent.Text != "")
                {
                    pparent = Convert.ToInt32(comboParent.SelectedValue);
                    comboParent.DataSource = location.GetLocationsTable();
                    comboParent.DisplayMember = "name";
                    comboParent.ValueMember = "id";
                    comboParent.SelectedValue = pparent;
                }

                comboSymbol.DataSource = symbol.GetSymbolsByType(1);
                comboSymbol.DisplayMember = "name";
                comboSymbol.ValueMember = "id";
                
                vissza = false;

                kereses(false);

                modosit = true;
            }
            else
            {
                MessageBox.Show("Nincs adat, amit módosítani lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtKeresNev_TextChanged(object sender, EventArgs e)
        {
            List<string> sor = location.GetLocationByName(txtKeresNev.Text.ToString() + "%");

            try
            {
                txtIndex.Text = sor[0].ToString();
                txtAzonosito.Text = sor[1].ToString();
                txtMegenevezes.Text = sor[2].ToString();
                /*
                comboTipus.DataSource = location.GetLocationsTable();
                comboTipus.DisplayMember = "name";
                comboTipus.ValueMember = "id";*/
                comboTipus.SelectedValue = sor[3];
                /*
                comboParent.DataSource = location.GetLocationsTable();
                comboParent.DisplayMember = "name";
                comboParent.ValueMember = "id";*/
                comboParent.SelectedValue = sor[4];

                int.TryParse(sor[5], out int sid);
                List<object> kep = symbol.GetSymbolById(sid);
                comboSymbol.Text = kep[0].ToString();
                MemoryStream ms = new MemoryStream((byte[])kep[1]);
                picSymbol.Image = Image.FromStream(ms);

                txtDescription.Text = sor[6].ToString();
            }
            catch (Exception)
            {

            }
        }


        private void txtKeresAzonosito_TextChanged(object sender, EventArgs e)
        {
            List<string> sor = location.GetLocationByName(txtKeresAzonosito.Text.ToString() + "%");

            try
            {
                txtIndex.Text = sor[0].ToString();
                txtAzonosito.Text = sor[1].ToString();
                txtMegenevezes.Text = sor[2].ToString();

               /* comboTipus.DataSource = location.GetLocationsTable();
                comboTipus.DisplayMember = "name";
                comboTipus.ValueMember = "id";*/
                comboTipus.SelectedValue = sor[3];

               /* comboParent.DataSource = location.GetLocationsTable();
                comboParent.DisplayMember = "name";
                comboParent.ValueMember = "id";*/
                comboParent.SelectedValue = sor[4];

                int.TryParse(sor[5], out int sid);
                List<object> kep = symbol.GetSymbolById(sid);
                comboSymbol.Text = kep[0].ToString();
                MemoryStream ms = new MemoryStream((byte[])kep[1]);
                picSymbol.Image = Image.FromStream(ms);

                txtDescription.Text = sor[6].ToString();
            }
            catch (Exception)
            {

            }
        }



        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (txtAzonosito.Text != "")
            {
                int effectedRows = location.DelLocation(long.Parse(txtIndex.Text));

                if (effectedRows >= 0)
                {
                    MessageBox.Show("Lokáció sikeresen törölve.");
                }
                else
                {
                    MessageBox.Show("A lokácót nem sikerült törölni.");
                }

                resetForm();
                btnMegse.PerformClick();
            }
            else
            {
                MessageBox.Show("Nincs adat, amit törölni lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kepBetoltes()
        {
        List<object> kep = symbol.GetSymbolById(int.Parse(comboSymbol.SelectedValue.ToString()));
        comboSymbol.Text = kep[0].ToString();
        MemoryStream ms = new MemoryStream((byte[])kep[1]);
        picSymbol.Image = Image.FromStream(ms);
        }

        private void comboSymbol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            kepBetoltes();
        }

        private void kereses(bool active)
        {
            if (active)
            {
                lblKeresAzonositoSzerint.Visible = true;
                lblKeresesNevSzerint.Visible = true;
                txtKeresAzonosito.Visible = true;
                txtKeresNev.Visible = true;
                txtKeresAzonosito.Focus();
            }
            else
            {
                lblKeresAzonositoSzerint.Visible = false;
                lblKeresesNevSzerint.Visible = false;
                txtKeresAzonosito.Visible = false;
                txtKeresNev.Visible = false;
            }
        }


        private void lblKeresesNevSzerint_Click(object sender, EventArgs e)
        {

        }

        private void lblKeresAzonositoSzerint_Click(object sender, EventArgs e)
        {

        }

        private void txtIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTipus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
