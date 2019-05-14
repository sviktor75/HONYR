using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLayer.Business;
using System.IO;

namespace PresentationLayer
{
    public partial class ItemPassiveCtrl : UserControl
    {

        BItem item = new BItem();
        BSymbol symbol = new BSymbol();
        BLocation location = new BLocation();
        private bool activeItem = false;

        bool vissza = false;
        bool uj = false;
        bool modosit = false;

        public ItemPassiveCtrl()
        {
            InitializeComponent();

        }

        public void resetForm() { this.Controls.ClearControls(); }

        private void ItemPassiveCtrl_Load(object sender, EventArgs e)
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
            comboParent.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            listPort.Enabled = false;
            txtPortAzonosito.Enabled = false;
            comboPortTipus.Enabled = false;

            kereses(false);

            vissza = true;
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
            comboParent.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            listPort.Enabled = false;
            txtPortAzonosito.Enabled = false;
            comboPortTipus.Enabled = false;

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


        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (uj)
            {
                int effectedRows = item.AddItem(txtAzonosito.Text, txtMegenevezes.Text, int.Parse(comboParent.Text), int.Parse(comboSymbol.SelectedValue.ToString()), txtDescription.Text, activeItem);

                if (effectedRows >= 0)
                {
                    MessageBox.Show("Eszköz sikeresen hozzáadva.");
                }
                else
                {
                    MessageBox.Show("Az eszközt nem sikerült létrehozni.");
                }

                uj = false;
            }

            if (modosit)
            {
                int effectedRows = item.ModItem(long.Parse(txtIndex.Text), txtAzonosito.Text, txtMegenevezes.Text, int.Parse(comboParent.Text), int.Parse(comboSymbol.SelectedValue.ToString()), txtDescription.Text);

                if (effectedRows >= 0)
                {
                    MessageBox.Show("Eszköz sikeresen módosítva.");
                }
                else
                {
                    MessageBox.Show("Az eszközt nem sikerült Módosítani.");
                }

                modosit = false;
            }

            vissza = false;
            resetForm();
            btnMegse.PerformClick();
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
            comboParent.Enabled = true;
            comboSymbol.Enabled = true;
            txtDescription.Enabled = true;

            listPort.Enabled = true;
            txtPortAzonosito.Enabled = true;
            comboPortTipus.Enabled = true;

            kereses(false);

            comboParent.DataSource = location.GetLocations();

            comboSymbol.DataSource = symbol.GetSymbolsByType(4);
            comboSymbol.DisplayMember = "name";
            comboSymbol.ValueMember = "id";

            kepBetoltes();


            vissza = false;
            uj = true;
        }

        private void btnKeres_Click(object sender, EventArgs e)
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
            comboParent.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            listPort.Enabled = false;
            txtPortAzonosito.Enabled = false;
            comboPortTipus.Enabled = false;

            vissza = false;

            kereses(true);
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
            comboParent.Enabled = true;
            comboSymbol.Enabled = true;
            txtDescription.Enabled = true;

            listPort.Enabled = true;
            txtPortAzonosito.Enabled = true;
            comboPortTipus.Enabled = true;

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
            List<string> sor = item.GetItemByName(txtKeresNev.Text.ToString() + "%", activeItem);

            try
            {
                txtIndex.Text = sor[0].ToString();
                txtAzonosito.Text = sor[1].ToString();
                txtMegenevezes.Text = sor[2].ToString();
                comboParent.Text = sor[3].ToString();

                int.TryParse(sor[4], out int sid);

                List<object> kep = symbol.GetSymbolById(sid);
                comboSymbol.Text = kep[0].ToString();
                MemoryStream ms = new MemoryStream((byte[])kep[1]);
                picSymbol.Image = Image.FromStream(ms);

                txtDescription.Text = sor[5].ToString();
            }
            catch (Exception)
            {

            }

        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            int effectedRows = item.DelItem(long.Parse(txtIndex.Text));

            if (effectedRows >= 0)
            {
                MessageBox.Show("Lokáció sikeresen törölve.");
            }
            else
            {
                MessageBox.Show("A lokácót nem sikerült törölni.");
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

        private void txtKeresAzonosito_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
