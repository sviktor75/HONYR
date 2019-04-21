using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honyr
{
    public partial class mountWall : UserControl
    {
        public mountWall()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            SendToBack();

            wallMountIdTextbox.Clear();
            wallMountNameTextbox.Clear();
            wallMountTypeComboBox.ResetText();
            wallMountFormationTextbox.Clear();
            wallMountLoctaionComboBox.ResetText();
            wallMountSymbolComboBox.ResetText();
            wallMountDescriptionRichTextBox.Clear();
        }
    }
}
