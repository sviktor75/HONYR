using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
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
            ELocation location = new ELocation();
            OLocation locationOP = new OLocation();

            location.Name = locationNameTextbox.Text;
            location.LocationType = locationTypeComboBox.Text;
            location.ParentId = long.Parse(LocationParentComboBox.Text); // ezt át kell majd írni
            location.SymbolId = int.Parse(locationSymbolComboBox.Text); // ezt át kell majd írni
            location.Description = locationDescriptionRichTextBox.Text;

            int effectedRows = locationOP.AddLocation(location);

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
