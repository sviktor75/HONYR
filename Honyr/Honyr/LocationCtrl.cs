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

        public addLocationCtrl()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            SendToBack();

            // If click on cancel then clear the boxes
            locationIdTextbox.Clear();
            locationNameTextbox.Clear();
            locationDescriptionRichTextBox.Clear();
            locationTypeComboBox.ResetText();
            locationSymbolComboBox.ResetText();
            LocationParentComboBox.ResetText();
        }

        private void locationSaveBtn_Click(object sender, EventArgs e)
        {
            BLocation location = new BLocation();

            int effectedRows = location.AddLocation(locationNameTextbox.Text, locationTypeComboBox.Text, long.Parse(LocationParentComboBox.Text), int.Parse(locationSymbolComboBox.Text), locationDescriptionRichTextBox.Text);

            if (effectedRows >= 0)
            {
                MessageBox.Show("Lokáció sikeresen hozzáadva.");
            }
            else
            {
                MessageBox.Show("A lokácót nem sikerült létrehozni.");
            }

        }

        private void locationModidyBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
