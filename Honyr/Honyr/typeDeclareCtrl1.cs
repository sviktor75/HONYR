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
    public partial class typeDeclareCtrl1 : UserControl
    {
        BTypes types = new BTypes();

        public void resetForm() { this.Controls.ClearControls(); }

        bool vissza = true;
        bool uj = false;
        bool modosit = false;

        public typeDeclareCtrl1()
        {
            InitializeComponent();
        }

        private void typeDeclareCtrl1_Load(object sender, EventArgs e)
        {
            comboGeneral.Items.Add("helyiség");
            comboGeneral.Items.Add("szimbólum");
            comboGeneral.Items.Add("fali csatlakozó");
            /*          comboGeneral.Items.Add("aktív eszköz");
                        comboGeneral.Items.Add("passzív eszköz");
                        comboGeneral.Items.Add("aktív port");
                        comboGeneral.Items.Add("passzív port");*/
            comboGeneral.Items.Add("port");
            comboGeneral.SelectedIndex = 0;

            btnUj.Enabled = true;
            btnMentes.Enabled = false;
            btnKeres.Enabled = true;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            comboGeneral.Enabled = true;

            txtTipus.Visible = false;

            kereses(false);
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            //resetForm();
            txtTipus.Text = "";
            comboGeneral.Enabled = false;

            btnUj.Enabled = false;
            btnMentes.Enabled = true;
            btnKeres.Enabled = false;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            txtTipus.Visible = true;
            txtTipus.Enabled = true;

            vissza = false;
            uj = true;

        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            btnUj.Enabled = true;
            btnMentes.Enabled = false;
            btnKeres.Enabled = true;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            comboGeneral.Enabled = true;

            txtTipus.Visible = false;

            if (vissza)
            {
                //resetForm();
                SendToBack();
            }

            vissza = true;
            uj = false;
            modosit = false;

            kereses(false);
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (txtTipus.Text != "")
            {
                int effectedRows = -1;
                if (uj)
                {
                    switch (comboGeneral.Text)
                    {
                        case "helyiség":
                            effectedRows = types.AddType("helyiség", txtTipus.Text);
                            break;

                        case "szimbólum":
                            effectedRows = types.AddType("szimbólum", txtTipus.Text);
                            break;

                        case "fali csatlakozó":
                            effectedRows = types.AddType("fali csatlakozó", txtTipus.Text);
                            break;
                        /*
                                        case "aktív eszköz":
                                            effectedRows = types.AddType("aktív eszköz",txtTipus.Text);
                                            break;

                                        case "passzív eszköz":
                                            effectedRows = types.AddType("passzív eszköz",txtTipus.Text);
                                            break;

                                        case "aktív port":
                                            effectedRows = types.AddType("aktív port",txtTipus.Text);
                                            break;

                                        case "passzív port":
                                            effectedRows = types.AddType("passzív port",txtTipus.Text);
                                            break;
                        */
                        case "port":
                            effectedRows = types.AddType("port", txtTipus.Text);
                            break;
                    }

                    if (effectedRows >= 0)
                    {
                        MessageBox.Show("Típus sikeresen létrehozva.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("A típust nem sikerült létrehozni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    uj = false;
                }

                if (modosit)
                {
                    switch (comboGeneral.Text)
                    {
                        case "helyiség":
                            effectedRows = types.ModType("helyiség", int.Parse(txtIndex.Text), txtTipus.Text);
                            break;

                        case "szimbólum":
                            effectedRows = types.ModType("szimbólum", int.Parse(txtIndex.Text), txtTipus.Text);
                            break;

                        case "fali csatlakozó":
                            effectedRows = types.ModType("fali csatlakozó", int.Parse(txtIndex.Text), txtTipus.Text);
                            break;
                        /*
                                        case "aktív eszköz":
                                            effectedRows = types.ModType("aktív eszköz", int.Parse(txtIndex.Text), txtTipus.Text);
                                            break;

                                        case "passzív eszköz":
                                            effectedRows = types.ModType("passzív eszköz", int.Parse(txtIndex.Text), txtTipus.Text);
                                            break;

                                        case "aktív port":
                                            effectedRows = types.ModType("aktív port", int.Parse(txtIndex.Text), txtTipus.Text);
                                            break;

                                        case "passzív port":
                                            effectedRows = types.ModType("passzív port", int.Parse(txtIndex.Text), txtTipus.Text);
                                            break;
                        */
                        case "port":
                            effectedRows = types.ModType("port", int.Parse(txtIndex.Text), txtTipus.Text);
                            break;
                    }

                    if (effectedRows >= 0)
                    {
                        MessageBox.Show("Típus sikeresen módosítva.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("A típust nem sikerült módosítani!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    modosit = false;
                }
            }
            else
            {
                MessageBox.Show("A típus neve nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            vissza = false;
            //resetForm();
            comboGeneral.SelectedIndex = 0;
            btnMegse.PerformClick();
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            btnUj.Enabled = false;
            btnMentes.Enabled = false;
            btnKeres.Enabled = true;
            btnModosit.Enabled = true;
            btnTorol.Enabled = true;
            btnMegse.Enabled = true;

            vissza = false;

            comboGeneral.Enabled = false;
            txtTipus.Visible = true;
            txtTipus.Enabled = false;

            kereses(true);
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            btnUj.Enabled = false;
            btnMentes.Enabled = true;
            btnKeres.Enabled = false;
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            btnMegse.Enabled = true;

            vissza = false;
            modosit = true;

            txtTipus.Enabled = true;
            comboGeneral.Enabled = false;

            kereses(false);
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (txtTipus.Text != "")
            {
                int effectedRows = -1;
                switch (comboGeneral.Text)
                {
                    case "helyiség":
                        effectedRows = types.DelType("helyiség", int.Parse(txtIndex.Text));
                        break;

                    case "szimbólum":
                        effectedRows = types.DelType("szimbólum", int.Parse(txtIndex.Text));
                        break;

                    case "fali csatlakozó":
                        effectedRows = types.DelType("fali csatlakozó", int.Parse(txtIndex.Text));
                        break;
                    /*
                                    case "aktív eszköz":
                                        effectedRows = types.DelType("aktív eszköz", int.Parse(txtIndex.Text));
                                        break;

                                    case "passzív eszköz":
                                        effectedRows = types.DelType("passzív eszköz", int.Parse(txtIndex.Text));
                                        break;

                                    case "aktív port":
                                        effectedRows = types.DelType("aktív port", int.Parse(txtIndex.Text));
                                        break;

                                    case "passzív port":
                                        effectedRows = types.DelType("passzív port", int.Parse(txtIndex.Text));
                                        break;
                    */
                    case "port":
                        effectedRows = types.DelType("port", int.Parse(txtIndex.Text));
                        break;
                }

                if (effectedRows >= 0)
                {
                    MessageBox.Show("Típus sikeresen törölve.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A típust nem sikerült törölni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A típus neve nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //this.Controls.ClearControls();
            btnMegse.PerformClick();
        }

        private void txtKeresNev_TextChanged(object sender, EventArgs e)
        {
            if (types.GetTypeById(comboGeneral.Text, 1).Count > 0)
            {
                List<string> sor = types.GetTypeByName(comboGeneral.Text.ToString(), txtKeresNev.Text.ToString() + "%");

                try
                {
                    txtIndex.Text = sor[0].ToString();
                    txtTipus.Text = sor[1].ToString();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Üres a(z) " + comboGeneral.Text + " tábla, nincs mit keresni benne!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kereses(bool active)
        {
            if (active)
            {
                lblKeresesNevSzerint.Visible = true;
                txtKeresNev.Visible = true;
                txtKeresNev.Focus();
            }
            else
            {
                lblKeresesNevSzerint.Visible = false;
                txtKeresNev.Visible = false;
            }
        }

    }
}
