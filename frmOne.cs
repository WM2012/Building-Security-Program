using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Building_Security_Program
{
    public partial class frmOne : Form
    {
        public frmOne()
        {
            InitializeComponent();
        }
        //DECLARED - Code Start

        //Sound of Login
        SoundPlayer Login = new SoundPlayer(Sounds.Windows_Logon);
        SoundPlayer Logout = new SoundPlayer(Sounds.Windows_Logoff_Sound);
        SoundPlayer Error = new SoundPlayer(Sounds.Windows_Error);
        SoundPlayer Locked = new SoundPlayer(Sounds.AlarmAffect);
        //Timer 
        int time;

        //Login Attempts counter
        int loginAttempts = 1;

        //DECLARED - Code End

        private void btnOk_Click(object sender, EventArgs e) //Login Button
        {   
            //Password 
            string password = txtPassword.Text.ToUpper();
            string passwordA = "password".ToUpper();
            //First Name and Last Name
            string fName = txtFirstName.Text.ToUpper();
            string lName = txtLastName.Text.ToUpper();

            if (fName == null  && lName == null)
            {
                MessageBox.Show("Please type your first and last name into First and Last Name Text Boxes.", "Missing Information"); //Propmts user for their name.
                Error.Play();
            }

            else
            {
              if (password == passwordA) //Checks Passwrod
                {
                    MessageBox.Show("Welcome security officer " + lName + " , " + fName , "Welcome");
                    Login.Play();
                    frmBSCP open = new frmBSCP();
                    open.Show();
                    btnOk.Enabled = false;
                    btnLogout.Enabled = true;
                    TimeLockOut.Enabled = false;                    
                }

                else
                {
                    if (loginAttempts < 3) //Tells user how many trys are left.
                    {
                        Error.Play();
                        MessageBox.Show("Wrong password please try again.\n You have " + loginAttempts + " login attempts left!!","Wrong Password"); //How Many Attempts are left.
                        loginAttempts++;

                    }

                    else
                    {
                        Locked.Play();
                        TimeLockOut.Stop();
                        MessageBox.Show("Head of Security Password Needed!!\n Please click the Reset button to type in Head of Security Password.", "System Locked"); // Requesting Reset
                        btnOk.Enabled = false;
                        txtPassword.Enabled = false;
                        txtReset.Enabled = true;
                        btnReset.Enabled = true;
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) //Logout Button
        {
            Logout.Play();
            txtFirstName.Text = "Enter First Name";
            txtLastName.Text = "Enter Last Name";
            txtPassword.Text = "";
            btnLogout.Enabled = false;
            btnOk.Enabled = true;
            //Closes Control Panel
            frmBSCP fTCN = (frmBSCP)Application.OpenForms["frmBSCP"];
            fTCN.Close();
            //Enables Timer
            time = 10;
            TimeLockOut.Enabled = true;

        }

        private void btnReset_Click(object sender, EventArgs e) //Reset Button
        {
            string password = txtReset.Text.ToUpper();
            string passwordA = "headofficer".ToUpper();
 
            if (password == passwordA)
            {
                txtPassword.Enabled = true;
                txtReset.Enabled = false;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                btnOk.Enabled = true;
                btnReset.Enabled = false;
                Login.Play();
            }

            else
            {
                MessageBox.Show("Try again you did not either type it in right or something is wrong. \n If you keep seeing this error please contact your I.T. Systems Administrator.","ERROR");
            }
        }

        private void TimeLockOut_Tick(object sender, EventArgs e) //Timer Lockout
        {
            time--;

            if (time == 0)
            {
                TimeLockOut.Stop();
                Locked.Play();
                MessageBox.Show("Head of Security Password Needed!!\n Please click the Reset button to type in Head of Security Password.","Timed Out");               
                btnOk.Enabled = false;
                txtPassword.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtReset.Enabled = true;
                btnReset.Enabled = true;
                
            }
        }

        private void frmOne_Load(object sender, EventArgs e) //Activates Timer
        {
            time = 10;
            TimeLockOut.Enabled = true;
        }
    }
}
