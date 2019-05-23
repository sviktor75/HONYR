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

namespace PresentationLayer
{
    public partial class WallMount : UserControl
    {
        BSymbol symbol = new BSymbol();
        BWallConnector wc = new BWallConnector();
        BLocation location = new BLocation();
        BCommonBase cbase = new BCommonBase();

        bool vissza = false;
        bool uj = false;
        bool modosit = false;

        public void resetForm() { this.Controls.ClearControls(); }

        public WallMount()
        {
            InitializeComponent();
        }


        private void WallMount_Load(object sender, EventArgs e)
        {
            this.Controls.ClearControls();

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
            txtKialakitas.Enabled = false;
            comboParent.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            vissza = true;

            kereses(false);

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
            txtKialakitas.Enabled = false;
            comboParent.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            this.Controls.ClearControls<ComboBox>();
            this.Controls.ClearControls<PictureBox>();


            if (vissza)
            {
                SendToBack();
                this.Controls.ClearControls();
            }

            vissza = true;
            uj = false;
            modosit = false;

            kereses(false);
        }


        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (uj)
            {
                int parent = int.Parse(comboParent.Text);
                int effectedRows = wc.AddConnector(txtAzonosito.Text, txtMegenevezes.Text, comboTipus.Text, txtKialakitas.Text, location.GetIdByLocationid(comboParent.Text), int.Parse(comboSymbol.SelectedValue.ToString()), txtDescription.Text);

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
                int effectedRows = wc.ModConnector(long.Parse(txtIndex.Text), txtAzonosito.Text, txtMegenevezes.Text, comboTipus.Text, txtKialakitas.Text, location.GetIdByLocationid(comboParent.Text), int.Parse(comboSymbol.SelectedValue.ToString()), txtDescription.Text);

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
            if (cbase.BaseSearch("wallconnector", "id", "1").Count > 0)
            {
                this.Controls.ClearControls();

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
                txtKialakitas.Enabled = true;
                comboParent.Enabled = true;
                comboSymbol.Enabled = true;
                txtDescription.Enabled = true;

                comboParent.DataSource = wc.GetConnector();

                comboSymbol.DataSource = symbol.GetSymbolsByType(3);
                comboSymbol.DisplayMember = "name";
                comboSymbol.ValueMember = "id";


                //
                kepBetoltes();

                vissza = false;
                uj = true;
            }
            else
            {
                MessageBox.Show("Nincs megjeleníthető szimbólum! Előbb azt kell feltölteni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            if (cbase.BaseSearch("wallconnector", "id", "1").Count > 0)
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
                txtKialakitas.Enabled = false;
                comboParent.Enabled = false;
                comboSymbol.Enabled = false;
                txtDescription.Enabled = false;

                vissza = false;

                kereses(true);
            }
            else
            {
                MessageBox.Show("Üres az fali csatlakozó tábla! Előbb azt kell feltölteni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModosit_Click(object sender, EventArgs e)
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
            txtKialakitas.Enabled = true;
            comboParent.Enabled = true;
            comboSymbol.Enabled = true;
            txtDescription.Enabled = true;

            comboParent.DataSource = location.GetLocations();

            comboSymbol.DataSource = symbol.GetSymbolsByType(4);
            comboSymbol.DisplayMember = "name";
            comboSymbol.ValueMember = "id";


            vissza = false;

            kereses(false);

            modosit = true;
        }


        private void txtKeresNev_TextChanged(object sender, EventArgs e)
        {
            List<string> sor = cbase.BaseSearch("wallconnecotr", "name", txtKeresNev.Text.ToString() + "%");

            try
            {
                txtIndex.Text = sor[0].ToString();
                txtAzonosito.Text = sor[1].ToString();
                txtMegenevezes.Text = sor[2].ToString();
                comboTipus.Text = sor[3].ToString();
                txtKialakitas.Text = sor[4].ToString();
                comboParent.Text = location.GetLocationidById(int.Parse(sor[5])).ToString();

                int.TryParse(sor[6], out int sid);

                List<object> kep = symbol.GetSymbolById(sid);
                comboSymbol.Text = kep[0].ToString();
                MemoryStream ms = new MemoryStream((byte[])kep[1]);
                picSymbol.Image = Image.FromStream(ms);
                txtDescription.Text = sor[7].ToString();
            }
            catch (Exception)
            {

            }

        }


        private void txtKeresAzonosito_TextChanged(object sender, EventArgs e)
        {
            List<string> sor = cbase.BaseSearch("wallconnecotr", "connectorid", txtAzonosito.Text.ToString() + "%");

            try
            {
                txtIndex.Text = sor[0].ToString();
                txtAzonosito.Text = sor[1].ToString();
                txtMegenevezes.Text = sor[2].ToString();
                comboTipus.Text = sor[3].ToString();
                txtKialakitas.Text = sor[4].ToString();
                comboParent.Text = location.GetLocationidById(int.Parse(sor[5])).ToString();

                int.TryParse(sor[6], out int sid);

                List<object> kep = symbol.GetSymbolById(sid);
                comboSymbol.Text = kep[0].ToString();
                MemoryStream ms = new MemoryStream((byte[])kep[1]);
                picSymbol.Image = Image.FromStream(ms);
                txtDescription.Text = sor[7].ToString();
            }
            catch (Exception)
            {

            }
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

    }
}

