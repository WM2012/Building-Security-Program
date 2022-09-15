namespace Building_Security_Program
{
    partial class frmOverrideAuthentication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHeadOfSecurity = new System.Windows.Forms.TextBox();
            this.txtOfficer = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHOSPassword = new System.Windows.Forms.Label();
            this.lblPropmtSOPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHeadOfSecurity
            // 
            this.txtHeadOfSecurity.Location = new System.Drawing.Point(125, 32);
            this.txtHeadOfSecurity.Name = "txtHeadOfSecurity";
            this.txtHeadOfSecurity.Size = new System.Drawing.Size(164, 20);
            this.txtHeadOfSecurity.TabIndex = 0;
            this.txtHeadOfSecurity.UseSystemPasswordChar = true;
            // 
            // txtOfficer
            // 
            this.txtOfficer.Location = new System.Drawing.Point(125, 70);
            this.txtOfficer.Name = "txtOfficer";
            this.txtOfficer.Size = new System.Drawing.Size(164, 20);
            this.txtOfficer.TabIndex = 1;
            this.txtOfficer.UseSystemPasswordChar = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(15, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 41);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Authenticate";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(174, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblHOSPassword
            // 
            this.lblHOSPassword.AutoSize = true;
            this.lblHOSPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHOSPassword.Location = new System.Drawing.Point(12, 35);
            this.lblHOSPassword.Name = "lblHOSPassword";
            this.lblHOSPassword.Size = new System.Drawing.Size(107, 13);
            this.lblHOSPassword.TabIndex = 4;
            this.lblHOSPassword.Text = "H.O.S. Password:";
            // 
            // lblPropmtSOPassword
            // 
            this.lblPropmtSOPassword.AutoSize = true;
            this.lblPropmtSOPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropmtSOPassword.Location = new System.Drawing.Point(25, 73);
            this.lblPropmtSOPassword.Name = "lblPropmtSOPassword";
            this.lblPropmtSOPassword.Size = new System.Drawing.Size(94, 13);
            this.lblPropmtSOPassword.TabIndex = 5;
            this.lblPropmtSOPassword.Text = "S.O. Password:";
            // 
            // frmOverrideAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(312, 160);
            this.Controls.Add(this.lblPropmtSOPassword);
            this.Controls.Add(this.lblHOSPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtOfficer);
            this.Controls.Add(this.txtHeadOfSecurity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmOverrideAuthentication";
            this.Text = "Override Authentication";
            this.Load += new System.EventHandler(this.FrmOverrideAuthentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeadOfSecurity;
        private System.Windows.Forms.TextBox txtOfficer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHOSPassword;
        private System.Windows.Forms.Label lblPropmtSOPassword;
    }
}