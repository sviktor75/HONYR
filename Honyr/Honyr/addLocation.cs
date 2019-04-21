using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Operations;

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
            OLocation location = new OLocation();
            location.AddLocation(
                locationNameTextbox.Text,
                locationTypeComboBox.Text,
                LocationParentComboBox.Text,               
                locationSymbolComboBox.Text,
                locationDescriptionRichTextBox.Text
                );
        }
    }
}
