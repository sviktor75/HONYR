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

        bool vissza = false;
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
                SendToBack();
                //resetForm();
            }

            vissza = true;
            uj = false;
            modosit = false;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (txtTipus.Text != "")
            {
                int effectedRows = -1;
                if (uj)
                {
                    switch (comboGeneral.SelectedValue)
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
                    switch (comboGeneral.SelectedValue)
                    {
                        case "helyiség":
                            effectedRows = types.ModType("helyiség", txtTipus.Text);
                            break;

                        case "szimbólum":
                            effectedRows = types.ModType("szimbólum", txtTipus.Text);
                            break;

                        case "fali csatlakozó":
                            effectedRows = types.ModType("fali csatlakozó", txtTipus.Text);
                            break;
                        /*
                                        case "aktív eszköz":
                                            effectedRows = types.ModType("aktív eszköz",txtTipus.Text);
                                            break;

                                        case "passzív eszköz":
                                            effectedRows = types.ModType("passzív eszköz",txtTipus.Text);
                                            break;

                                        case "aktív port":
                                            effectedRows = types.ModType("aktív port",txtTipus.Text);
                                            break;

                                        case "passzív port":
                                            effectedRows = types.ModType("passzív port",txtTipus.Text);
                                            break;
                        */
                        case "port":
                            effectedRows = types.ModType("port", txtTipus.Text);
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
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            vissza = false;
            modosit = true;

            txtTipus.Enabled = true;
            comboGeneral.Enabled = false;
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            //this.Controls.ClearControls();
            btnMegse.PerformClick();
        }
    }
}
