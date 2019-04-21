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
    public partial class ItemActiveCtrl : UserControl
    {
        public ItemActiveCtrl()
        {
            InitializeComponent();
        }

        private void addPortBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // If click on cancel then clear the fields and send it back
            this.Controls.ClearControls();

            SendToBack();
            
        }
    }
}
