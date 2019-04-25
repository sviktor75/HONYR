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
    public partial class ItemActiveCtrl : UserControl
    {
        BItem item = new BItem();
        BSymbol symbol = new BSymbol();
        BLocation location = new BLocation();

        bool vissza = false;
        bool uj = false;
        bool modosit = false;

        public ItemActiveCtrl()
        {
            InitializeComponent();
        }

        private void ItemActiveCtrl_Load(object sender, EventArgs e)
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
            comboParent.Enabled = false;
            txtIP.Enabled = false;
            txtMAC.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            listPort.Enabled = false;
            txtPortAzonosito.Enabled = false;
            txtPortMegnevezes.Enabled = false;
            txtPortKonfig.Enabled = false;
            comboPortTipus.Enabled = false;


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
            comboParent.Enabled = false;
            txtIP.Enabled = false;
            txtMAC.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            listPort.Enabled = false;
            txtPortAzonosito.Enabled = false;
            txtPortMegnevezes.Enabled = false;
            txtPortKonfig.Enabled = false;
            comboPortTipus.Enabled = false;

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

      
        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (uj)
            {
                int effectedRows = item.AddItem(true, txtAzonosito.Text, txtMegenevezes.Text, txtIP.Text, txtMAC.Text, location.GetididByLocationid(comboParent.Text), comboSymbol.SelectedIndex + 1, txtDescription.Text);

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
                int effectedRows = item.ModItem(long.Parse(txtIndex.Text), true, txtAzonosito.Text, txtMegenevezes.Text, txtIP.Text, txtMAC.Text, location.GetididByLocationid(comboParent.Text), comboSymbol.SelectedIndex + 1, txtDescription.Text);

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
            comboParent.Enabled = true;
            txtIP.Enabled = true;
            txtMAC.Enabled = true;
            comboSymbol.Enabled = true;
            txtDescription.Enabled = true;

            listPort.Enabled = true;
            txtPortAzonosito.Enabled = true;
            txtPortMegnevezes.Enabled = true;
            txtPortKonfig.Enabled = true;
            comboPortTipus.Enabled = true;

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
            comboParent.Enabled = false;
            txtIP.Enabled = false;
            txtMAC.Enabled = false;
            comboSymbol.Enabled = false;
            txtDescription.Enabled = false;

            listPort.Enabled = false;
            txtPortAzonosito.Enabled = false;
            txtPortMegnevezes.Enabled = false;
            txtPortKonfig.Enabled = false;
            comboPortTipus.Enabled = false;

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
            comboParent.Enabled = true;
            txtIP.Enabled = true;
            txtMAC.Enabled = true;
            comboSymbol.Enabled = true;
            txtDescription.Enabled = true;

            listPort.Enabled = true;
            txtPortAzonosito.Enabled = true;
            txtPortMegnevezes.Enabled = true;
            txtPortKonfig.Enabled = true;
            comboPortTipus.Enabled = true;

            comboParent.DataSource = location.GetLocations();
            comboSymbol.DataSource = symbol.GetSymbols();

            vissza = false;

            txtKeres.Visible = false;

            modosit = true;
        }


        private void txtKeres_TextChanged(object sender, EventArgs e)
        {
            List<string> sor = item.GetItemByName(txtKeres.Text.ToString() + "%", true);
        
            try
            {
                txtIndex.Text = sor[0].ToString();
                txtAzonosito.Text = sor[2].ToString();
                txtMegenevezes.Text = sor[3].ToString();
                comboParent.Text = location.GetLocationidByID( int.Parse(sor[4])).ToString();
                txtIP.Text = sor[5].ToString();
                txtMAC.Text = sor[6].ToString();
                

                int.TryParse(sor[7], out int sid);

                List<object> kep = symbol.GetSymbolById(sid);
                comboSymbol.Text = kep[0].ToString();
                MemoryStream ms = new MemoryStream((byte[])kep[1]);
                picSymbol.Image = Image.FromStream(ms);

                txtDescription.Text = sor[8].ToString();
            }
            catch (Exception ex)
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
