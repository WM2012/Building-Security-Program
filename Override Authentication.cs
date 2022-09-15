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
    public partial class frmOverrideAuthentication : Form
    {
        public frmOverrideAuthentication()
        {
            InitializeComponent();
        }
        //Pulbic Delcare
        public string aHPassword;
        public string aOPassword;

        private void btnOK_Click(object sender, EventArgs e) //Authenticate Button
        {
            aHPassword = txtHeadOfSecurity.Text;
            aOPassword = txtOfficer.Text;
            this.DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e) //Cancel Button
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmOverrideAuthentication_Load(object sender, EventArgs e)
        {

        }
    }
}
