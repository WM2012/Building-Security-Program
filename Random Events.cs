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
    public partial class frmRandomEvents : Form
    {
        public frmRandomEvents()
        {
            InitializeComponent();
        }

        public int sPE;
        Random re = new Random();
        

        private void btn_Click(object sender, EventArgs e)
        {
             int eventR = re.Next(1, 5);
              

            if (eventR == 1) //Fire
            {
                sPE = 1;
                this.DialogResult = DialogResult.OK;
            }

            if (eventR == 2) //Lockdown
            {
                sPE = 2;
                this.DialogResult = DialogResult.OK;
            }

            if(eventR == 3) //Hazmat
            {
                sPE = 3;
                this.DialogResult = DialogResult.OK;
            }
            
            if(eventR == 4) //Tornado
            {
                sPE = 4;
                this.DialogResult = DialogResult.OK;
            }           
        }
    }
}
