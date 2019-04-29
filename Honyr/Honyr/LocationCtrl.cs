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
    public partial class addLocationCtrl : UserControl
    {
        BLocation location = new BLocation();
        BSymbol symbol = new BSymbol();

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

            txtKeres.Visible = false;
        }

        private void addLocationCtrl_Load(object sender, EventArgs e)
        {
            resetForm();

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

                int effectedRows = location.AddLocation(txtAzonosito.Text, txtMegenevezes.Text, int.Parse(comboTipus.Text), location.GetididByLocationid(comboParent.Text), comboSymbol.SelectedIndex + 1, txtDescription.Text);

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
                int effectedRows = location.ModLocation(long.Parse(txtIndex.Text), txtAzonosito.Text, txtMegenevezes.Text, int.Parse(comboTipus.Text), location.GetididByLocationid(comboParent.Text), comboSymbol.SelectedIndex + 1, txtDescription.Text);

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

        private void btnUj_Click(object sender, EventArgs e)
        {
            resetForm();

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
            comboTipus.Enabled = false; 
            comboParent.Enabled = false; 
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

            comboParent.DataSource = location.GetLocations();
            comboSymbol.DataSource = symbol.GetSymbols();

            vissza = false;

            txtKeres.Visible = false;

            modosit = true;
        }


        private void txtKeres_TextChanged(object sender, EventArgs e)
        {
            List<string> sor = location.GetLocationByName(txtKeres.Text.ToString() + "%");

            try
            {
                txtIndex.Text = sor[0].ToString();
                txtAzonosito.Text = sor[1].ToString();
                txtMegenevezes.Text = sor[2].ToString();
                comboTipus.Text = sor[3].ToString();
                comboParent.Text = location.GetLocationidByID( int.Parse(sor[4])).ToString();

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
