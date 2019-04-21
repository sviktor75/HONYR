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

namespace Honyr
{
    public partial class PassiveItemCtrl : UserControl
    {

        public PassiveItemCtrl()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // If click on cancel then clear the fields and send it back
            this.Controls.ClearControls();
            SendToBack();
        }

        private void itemPassiveDeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void itemPassivePortsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
