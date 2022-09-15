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
    public partial class frmBSCP : Form
    {
        public frmBSCP()
        {
            InitializeComponent();
        }

        //DECLARED - Code Start
        //Random Events
        frmRandomEvents frmRandomEvents = new frmRandomEvents();
        //Authentication Form
        frmOverrideAuthentication frmOverrideAuthentication = new frmOverrideAuthentication();
        //Manual Locking and Unlocking
        frmDoorLock frmDoorLock = new frmDoorLock();
        int MEDoors;
        int LBDoors;
        int MWDoors;
        int RDoors;
        int SGate;
        //Sounds
        SoundPlayer FireA = new SoundPlayer(Sounds.Fire_Alarm);
        SoundPlayer HazmatA = new SoundPlayer(Sounds.Hazmat);
        SoundPlayer SystemTestA = new SoundPlayer(Sounds.System_Test);
        SoundPlayer LockdownA = new SoundPlayer(Sounds.Lockdown);
        SoundPlayer AllClearA = new SoundPlayer(Sounds.All_Clear);
        SoundPlayer TorndaoA = new SoundPlayer(Sounds.Tornado);
        SoundPlayer DoorBuzzer = new SoundPlayer(Sounds.DoorBuzzer);
        SoundPlayer Error = new SoundPlayer(Sounds.Windows_Error);
        //DECLARED - Code End

        //Methods - Code Start

        public void UnlockAllDoors() //Unlocks All Doors
        {
            //Main Entrance Doors
            pbEntranceDoorOne.Image = Properties.Resources.Green;
            pbLobbyDoor.Image = Properties.Resources.Green;
            //Middle Wing Doors
            pbMiddleWingDoorOne.Image = Properties.Resources.Green;
            pbMiddleWingDoorTwo.Image = Properties.Resources.Green;
            pbMiddleWingDoorThree.Image = Properties.Resources.Green;
            pbMiddleWingDoorFour.Image = Properties.Resources.Green;
            //Room Doors
            pbRoomDoorOne.Image = Properties.Resources.Green;
            pbRoomDoorTwo.Image = Properties.Resources.Green;
            pbRoomDoorThree.Image = Properties.Resources.Green;
            pbRoomDoorFour.Image = Properties.Resources.Green;
            pbRoomDoorFive.Image = Properties.Resources.Green;
            pbRoomDoorSix.Image = Properties.Resources.Green;
            pbRoomDoorSeven.Image = Properties.Resources.Green;
        }

        public void LockAllDoors() //Locks All Doors
        {
            //Main Entrance Doors
            pbEntranceDoorOne.Image = Properties.Resources.Red;
            pbLobbyDoor.Image = Properties.Resources.Red;
            //Middle Wing Doors
            pbMiddleWingDoorOne.Image = Properties.Resources.Red;
            pbMiddleWingDoorTwo.Image = Properties.Resources.Red;
            pbMiddleWingDoorThree.Image = Properties.Resources.Red;
            pbMiddleWingDoorFour.Image = Properties.Resources.Red;
            //Room Doors
            pbRoomDoorOne.Image = Properties.Resources.Red;
            pbRoomDoorTwo.Image = Properties.Resources.Red;
            pbRoomDoorThree.Image = Properties.Resources.Red;
            pbRoomDoorFour.Image = Properties.Resources.Red;
            pbRoomDoorFive.Image = Properties.Resources.Red;
            pbRoomDoorSix.Image = Properties.Resources.Red;
            pbRoomDoorSeven.Image = Properties.Resources.Red;
        }

        private void DefaultMode() //Normal Security Protocls
        {
            //Main Entrance Doors
            pbEntranceDoorOne.Image = Properties.Resources.Red;
            pbLobbyDoor.Image = Properties.Resources.Red;
            //Middle Wing Doors
            pbMiddleWingDoorOne.Image = Properties.Resources.Green;
            pbMiddleWingDoorTwo.Image = Properties.Resources.Green;
            pbMiddleWingDoorThree.Image = Properties.Resources.Green;
            pbMiddleWingDoorFour.Image = Properties.Resources.Green;
            //Room Doors
            pbRoomDoorOne.Image = Properties.Resources.Green;
            pbRoomDoorTwo.Image = Properties.Resources.Green;
            pbRoomDoorThree.Image = Properties.Resources.Green;
            pbRoomDoorFour.Image = Properties.Resources.Green;
            pbRoomDoorFive.Image = Properties.Resources.Green;
            pbRoomDoorSix.Image = Properties.Resources.Green;
            pbRoomDoorSeven.Image = Properties.Resources.Green;
        }

        public void LockSecurityGates() //Locked Security Gate
        {
            pbSecurityGateOne.Image = Properties.Resources.Red;
            pbSecurityGateTwo.Image = Properties.Resources.Red;
        }
        public void UnlockSecurityGates() //Unlocked Security Gate
        {
            pbSecurityGateOne.Image = Properties.Resources.Green;
            pbSecurityGateTwo.Image = Properties.Resources.Green;
        }

        public void LockButtonsDisabled() // Disables Manual Lock and Unlock Buttons
        {
            btnMainEntrance.Enabled = false;
            btnLobbyDoors.Enabled = false;
            btnRoomDoors.Enabled = false;
            btnMiddleWing.Enabled = false;
        }

        private void LockButtonsEnabled() //Enables Manual Lock and Unlock Buttons
        {
            btnMainEntrance.Enabled = true;
            btnLobbyDoors.Enabled = true;
            btnRoomDoors.Enabled = true;
            btnMiddleWing.Enabled = true;
        }

        private void eAllSecurityProtocols()
        {
            btnFire.Enabled = true;
            btnHazmat.Enabled = true;
            btnLockdown.Enabled = true;
            btnTornado.Enabled = true;
        }

        private void eHigherFunctions()
        {
            btnReset.Enabled = true;
            btnSecurityGate.Enabled = true;
            btnSystemTest.Enabled = true;
        }

        private void MELockProtocol() //Lock Control for Main Entrance Doors
        {
            if (frmDoorLock.ShowDialog() == DialogResult.OK)
            {
                MEDoors = frmDoorLock.nSelected;
            }

            switch (MEDoors)
            {
                case 1:
                    pbEntranceDoorOne.Image = Properties.Resources.Green;
                    DoorBuzzer.Play();
                    break;
                case 2:
                    pbEntranceDoorOne.Image = Properties.Resources.Red;
                    DoorBuzzer.Play();
                    break;
                default:
                    Error.Play();
                    MessageBox.Show("You did not select a number that can be used!!");
                    break;
            }
        }
        private void LBLockProtocol() //Lock Control for Lobby Doors
        {
            if (frmDoorLock.ShowDialog() == DialogResult.OK)
            {
                LBDoors = frmDoorLock.nSelected;
            }

            switch (LBDoors)
            {
                case 1:
                    pbLobbyDoor.Image = Properties.Resources.Green;
                    DoorBuzzer.Play();
                    break;
                case 2:
                    pbLobbyDoor.Image = Properties.Resources.Red;
                    DoorBuzzer.Play();
                    break;
            }

        }

        private void MWLockProtocol() // Lock Control for Middle Wing Doors
        {
            if (frmDoorLock.ShowDialog() == DialogResult.OK)
            {
                MWDoors = frmDoorLock.nSelected;
            }

            switch (MWDoors)
            {
                case 1:
                    pbMiddleWingDoorOne.Image = Properties.Resources.Green;
                    pbMiddleWingDoorTwo.Image = Properties.Resources.Green;
                    pbMiddleWingDoorThree.Image = Properties.Resources.Green;
                    pbMiddleWingDoorFour.Image = Properties.Resources.Green;
                    DoorBuzzer.Play();
                    break;
                case 2:
                    pbMiddleWingDoorOne.Image = Properties.Resources.Red;
                    pbMiddleWingDoorTwo.Image = Properties.Resources.Red;
                    pbMiddleWingDoorThree.Image = Properties.Resources.Red;
                    pbMiddleWingDoorFour.Image = Properties.Resources.Red;
                    DoorBuzzer.Play();
                    break;
            }
        }

        private void RDLockProtocol() // Lock Control for Room Doors
        {
            if (frmDoorLock.ShowDialog() == DialogResult.OK)
            {
                RDoors = frmDoorLock.nSelected;
            }

            switch (RDoors)
            {
                case 1:
                    pbRoomDoorOne.Image = Properties.Resources.Green;
                    pbRoomDoorTwo.Image = Properties.Resources.Green;
                    pbRoomDoorThree.Image = Properties.Resources.Green;
                    pbRoomDoorFour.Image = Properties.Resources.Green;
                    pbRoomDoorFive.Image = Properties.Resources.Green;
                    pbRoomDoorSix.Image = Properties.Resources.Green;
                    pbRoomDoorSeven.Image = Properties.Resources.Green;
                    DoorBuzzer.Play();
                    break;
                case 2:
                    pbRoomDoorOne.Image = Properties.Resources.Red;
                    pbRoomDoorTwo.Image = Properties.Resources.Red;
                    pbRoomDoorThree.Image = Properties.Resources.Red;
                    pbRoomDoorFour.Image = Properties.Resources.Red;
                    pbRoomDoorFive.Image = Properties.Resources.Red;
                    pbRoomDoorSix.Image = Properties.Resources.Red;
                    pbRoomDoorSeven.Image = Properties.Resources.Red;
                    DoorBuzzer.Play();
                    break;
            }
        }

        private void SGLockProtocol() //Lock Control for Security Gate
        {
            if (frmDoorLock.ShowDialog() == DialogResult.OK)
            {
                SGate = frmDoorLock.nSelected;
            }

            switch (SGate)
            {
                case 1:
                    pbSecurityGateOne.Image = Properties.Resources.Green;
                    pbSecurityGateTwo.Image = Properties.Resources.Green;
                    break;
                case 2:
                    pbSecurityGateOne.Image = Properties.Resources.Red;
                    pbSecurityGateTwo.Image = Properties.Resources.Red;
                    break;
            }
        }

        private void fireDoorsOPEN() //FIRE DOORS OPEN
        {
            pbEmExitOne.Image = Properties.Resources.Green;
            pbEmExitTwo.Image = Properties.Resources.Green;
        }

        private void fireDoorsClosed() // FIRE DOORS CLOSED
        {
            pbEmExitOne.Image = Properties.Resources.Red;
            pbEmExitTwo.Image = Properties.Resources.Red;
        }

        private void fireLocation() //Random Fire Events
        {
            Random fo = new Random();

            int fireRLocation = fo.Next(1, 4);

            if (fireRLocation == 1)
            {
                pbFireRoomOne.Image = Properties.Resources.fire;

                for (int i = 1; i <= 15; i++)
                {

                    if (i == 1)
                    {
                        pbFireRoomTwo.Image = Properties.Resources.fire;
                    }

                    if (i == 3)
                    {
                        pbFireRoomThree.Image = Properties.Resources.fire;
                    }

                    if (i == 5)
                    {
                        pbFireRoomFour.Image = Properties.Resources.fire;
                    }

                    if (i == 7)
                    {
                        pbFireRoomFive.Image = Properties.Resources.fire;
                    }

                    if (i == 9)
                    {
                        pbFireRoomSix.Image = Properties.Resources.fire;
                    }

                    if (i == 11)
                    {
                        pbFireRoomSeven.Image = Properties.Resources.fire;
                    }

                    if (i == 13)
                    {
                        pbFireMiddleWing.Image = Properties.Resources.fire;
                    }

                    if (i == 15)
                    {
                        pbFireEntrance.Image = Properties.Resources.fire;
                    }

                }
        

                if (fireRLocation == 2)
                {
                    pbFireEntrance.Image = Properties.Resources.fire;

                    for (int i = 1; i <= 15; i++)
                    {

                        if (i == 1)
                        {
                            pbFireRoomOne.Image = Properties.Resources.fire;
                        }

                        if (i == 3)
                        {
                            pbFireRoomThree.Image = Properties.Resources.fire;
                        }

                        if (i == 5)
                        {
                            pbFireRoomFour.Image = Properties.Resources.fire;
                        }

                        if (i == 7)
                        {
                            pbFireRoomFive.Image = Properties.Resources.fire;
                        }

                        if (i == 9)
                        {
                            pbFireRoomSix.Image = Properties.Resources.fire;
                        }

                        if (i == 11)
                        {
                            pbFireRoomSeven.Image = Properties.Resources.fire;
                        }

                        if (i == 13)
                        {
                            pbFireMiddleWing.Image = Properties.Resources.fire;
                        }

                        if (i == 15)
                        {
                            pbFireRoomTwo.Image = Properties.Resources.fire;
                        }
                    }
                
                }

                if(fireRLocation == 3) //Pulling Fire Alarm
                {
                    MessageBox.Show("The fire alarm was triggered by Fire Alarm Button on North hallway.\n Fire location was not detected.", "Fire Alarm Button");
                }
            }
        }

        private void mFireOut() //Clears Fire Pictures
        {
            pbFireEntrance.Image = null;
            pbFireMiddleWing.Image = null;
            pbFireRoomOne.Image = null;
            pbFireRoomTwo.Image = null;
            pbFireRoomThree.Image = null;
            pbFireRoomFour.Image = null;
            pbFireRoomFive.Image = null;
            pbFireRoomSix.Image = null;
            pbFireRoomSeven.Image = null;
        }

        private void sHazmatHealth() //Random List of Hazmat situations.
        {
            Random d = new Random();

            int outbreak = d.Next(1, 3);

            if(outbreak == 1) //Lab spill
            {
                MessageBox.Show("Hazmat spill in lab 189 please follow all hazmat protocols", "Chemical Alert");
            }

            if(outbreak == 2) //Diphtheria
            {
                MessageBox.Show("The air monitoring and detection devices have detected Diphtheria in the building please follow Hazmat protocols.", "Diphtheria Alert");
            }

            if(outbreak == 3) //Smallpox
            {
                MessageBox.Show("The air monitoring and detection devices have detected a form of smallpox in the air.", "Smallpox Alert ");
            }
        }

        private void sLockdown() //Random List of Lockdown situations.
        {
            Random d = new Random();

            int outbreak = d.Next(1, 3);

            if (outbreak == 1) //Lab spill
            {
                MessageBox.Show("An active shooter has been reported in the building", "Active Shooter Alert!");
            }

            if (outbreak == 2) //Diphtheria
            {
                MessageBox.Show("Front desk staff triggered alarm do to unorthized personal.", "Unorthiezed Personal Alert!");
            }

            if (outbreak == 3) //Smallpox
            {
                MessageBox.Show("Server room 169 has been breached.", "Secuirty Breach!");
            }
        }
        //Methods - Code End
        //Object - Code Start
        private void frmBSCP_Load(object sender, EventArgs e) //Program Start Up
        {
            //Default Mode
            DefaultMode();
            //Unlocked Security Gate
            UnlockSecurityGates();
        }

        private void btnMainEntrance_Click(object sender, EventArgs e) // Main Entrance Doors
        {
            MELockProtocol();      
        }

        private void btnLobbyDoors_Click(object sender, EventArgs e) //Lobby Doors
        {
            LBLockProtocol();
        }

        private void btnMiddleWing_Click(object sender, EventArgs e) // Middle Wing Doors
        {
            MWLockProtocol();
        }

        private void btnRoomDoors_Click(object sender, EventArgs e) // Room Doors
        {
            RDLockProtocol();
        }

        private void btnFire_Click(object sender, EventArgs e) //Fire Button
        {
            //Disabled Security Buttons
            btnHazmat.Enabled = false;
            btnLockdown.Enabled = false;
            btnTornado.Enabled = false;
            //Unlocks All Doors
            UnlockAllDoors();
            //Unlock Security Gate
            UnlockSecurityGates();
            //Disabled Door Buttons
            LockButtonsDisabled();
            //OPEN FIRE DOORS
            fireDoorsOPEN();
            //Alarm
            FireA.PlayLooping();
        }

        private void btnLockdown_Click(object sender, EventArgs e) //Lockdown Button
        {
            //Disabled Security Buttons
            btnFire.Enabled = false;
            btnHazmat.Enabled = false;
            btnTornado.Enabled = false;
            //Locks All Doors
            LockAllDoors();
            //Lock Security Gate
            LockSecurityGates();
            //Disabled Door Buttons
            LockButtonsDisabled();
            //Puts Out Fires
            mFireOut();
            //FIRE DOORS CLOSED
            fireDoorsClosed();
            //Alarm
            LockdownA.PlayLooping();
        }

        private void btnHazmat_Click(object sender, EventArgs e) //Hazmat Button
        {
            //Disabled Security Buttons
            btnFire.Enabled = false;
            btnLockdown.Enabled = false;
            btnTornado.Enabled = false;
            //Locks All Doors
            LockAllDoors();
            //Lock Security Gate
            LockSecurityGates();
            //Disabled Door Buttons
            LockButtonsDisabled();
            //Puts Out Fires
            mFireOut();
            //FIRE DOORS CLOSED
            fireDoorsClosed();
            //Alarm
            HazmatA.PlayLooping();
        }

        private void btnTornado_Click(object sender, EventArgs e) //Tornado Button
        {
            //Disabled Security Buttons
            btnFire.Enabled = false;
            btnLockdown.Enabled = false;
            btnHazmat.Enabled = false;
            //Locks All Doors
            LockAllDoors();
            //Unlock Security Gate
            UnlockSecurityGates();
            //Disabled Door Buttons
            LockButtonsDisabled();
            //Puts Out Fires
            mFireOut();
            //FIRE DOORS CLOSED
            fireDoorsClosed();
            //Alarm
            TorndaoA.PlayLooping();
        }

        private void btnOk_Click(object sender, EventArgs e) //Override Button
        {
            if (frmOverrideAuthentication.ShowDialog() == DialogResult.OK)
            {
                //
                string aHpassword = frmOverrideAuthentication.aHPassword.ToUpper();
                string aOpassword = frmOverrideAuthentication.aOPassword.ToUpper();
               //Set Passwords
                string oHPasswordV = "headofficer".ToUpper();
                string oOPasswordV = "officerone".ToUpper();
              
                if (oOPasswordV == aOpassword && oHPasswordV == aHpassword)
                {
                    //Enables All Manual Lock Buttons
                    LockButtonsEnabled();
                    //Enables All Security Protocols
                    eAllSecurityProtocols();
                    //Enables Higer Functions
                    eHigherFunctions();
                }

                else
                {
                    MessageBox.Show("Authentication was not unsuccessful!", "Failed Authentication"); // Faild Authentication
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e) //Reset Button
        {
            //Default Mode
            DefaultMode();
            //Enalbes All Lock Buttons
            LockButtonsEnabled();
            //Unlock Security Gate
            UnlockSecurityGates();
            //Puts Out Fires
            mFireOut();
            //Alarm
            int x = 0;
            do
            {
                if (x == 1)
                {
                    AllClearA.Play();
                }

                if(x == 18)
                {
                    AllClearA.Play();
                }

                if(x == 203)
                {
                    AllClearA.Play();
                }

                if(x == 403)
                {
                    AllClearA.Play();
                }

                x++;
            } while (x < 500); //The sound file will go off four times.
        }

        private void btnSystemTest_Click(object sender, EventArgs e) //System Test Button
        {
            //Alarm
            
            SystemTestA.PlayLooping();
        }

        private void btnSecurityGate_Click(object sender, EventArgs e) //Security Gates
        {
            SGLockProtocol();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e) // Restart Program
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Exit Control Panel
        {
            Application.Exit();
        }

        private void randomEventsToolStripMenuItemOK_Click(object sender, EventArgs e) //Random Events
        {
            if (frmRandomEvents.ShowDialog() == DialogResult.OK)
            {
               int Eventran = frmRandomEvents.sPE;

                if (Eventran == 1) //Fire
                {
                    //Disabled Security Buttons
                    btnHazmat.Enabled = false;
                    btnLockdown.Enabled = false;
                    btnTornado.Enabled = false;
                    //Unlocks All Doors
                    UnlockAllDoors();
                    //Unlock Security Gate
                    UnlockSecurityGates();
                    //Disabled Door Buttons
                    LockButtonsDisabled();
                    //Fire Location
                    fireLocation();
                    //OPEN FIRE DOORS
                    fireDoorsOPEN();
                    //Alarm
                    FireA.PlayLooping();
                }

                if (Eventran == 2) //Lockdown
                {
                    //Disabled Security Buttons
                    btnFire.Enabled = false;
                    btnHazmat.Enabled = false;
                    btnTornado.Enabled = false;
                    //Locks All Doors
                    LockAllDoors();
                    //Lock Security Gate
                    LockSecurityGates();
                    //Disabled Door Buttons
                    LockButtonsDisabled();
                    //Puts Out Fires
                    mFireOut();
                    //Random Lockdown Events
                    sLockdown();
                    //FIRE DOORS CLOSED
                    fireDoorsClosed();
                    //Alarm
                    LockdownA.PlayLooping();
                }

                if(Eventran == 3) //Hazmat
                {
                    //Disabled Security Buttons
                    btnFire.Enabled = false;
                    btnLockdown.Enabled = false;
                    btnTornado.Enabled = false;
                    //Locks All Doors
                    LockAllDoors();
                    //Lock Security Gate
                    LockSecurityGates();
                    //Disabled Door Buttons
                    LockButtonsDisabled();
                    //Puts Out Fires
                    mFireOut();
                    //Alarm
                    HazmatA.PlayLooping();
                    //FIRE DOORS CLOSED 
                    fireDoorsClosed();
                    //Hazmat Random Events
                    sHazmatHealth();
                }

                if(Eventran == 4) //Tornado
                {
                    //Disabled Security Buttons
                    btnFire.Enabled = false;
                    btnLockdown.Enabled = false;
                    btnHazmat.Enabled = false;
                    //Locks All Doors
                    LockAllDoors();
                    //Unlock Security Gate
                    UnlockSecurityGates();
                    //Disabled Door Buttons
                    LockButtonsDisabled();
                    //Puts Out Fires
                    mFireOut();
                    //FIRE DOORS CLOSED  
                    fireDoorsClosed();
                    //Alarm
                    TorndaoA.PlayLooping();
                    //Message Box
                    MessageBox.Show("The National Weather Service has issued a Tornado Warning for this area!!", "Tornado Warning!!!");
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBSCP fTCN = (frmBSCP)Application.OpenForms["frmBSCP"];
            fTCN.Hide();
        }
    }
}