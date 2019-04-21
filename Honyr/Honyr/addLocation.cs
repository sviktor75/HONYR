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
              // If clicked on cancel then clear all the boxes
            this.Controls.ClearControls();

            SendToBack();
        }

        private void locationSaveBtn_Click(object sender, EventArgs e)
        {
            OLocation location = new OLocation();
            location.AddLocation(
                locationNameTextbox.Text,
                locationTypeComboBox.Text,
                long.Parse(LocationParentComboBox.Text),
                int.Parse(locationSymbolComboBox.Text),
                locationDescriptionRichTextBox.Text
                );
        }
    }
}
