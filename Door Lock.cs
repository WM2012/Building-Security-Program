using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Building_Security_Program
{
    public partial class frmDoorLock : Form
    {
        public frmDoorLock()
        {
            InitializeComponent();
        }
        public int nSelected;

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (radLock.Checked) // Locks Door
            {
                nSelected = 2;
                this.DialogResult = DialogResult.OK;
            }

            if (radUnlock.Checked) //Unlocks Door
            {
                nSelected = 1;
                this.DialogResult = DialogResult.OK;
            }           
        }

    }
}
