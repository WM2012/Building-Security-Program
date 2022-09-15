namespace Building_Security_Program
{
    partial class frmDoorLock
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
            this.btnOK = new System.Windows.Forms.Button();
            this.radLock = new System.Windows.Forms.RadioButton();
            this.radUnlock = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.Location = new System.Drawing.Point(110, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 87);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Lock/Unlock";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // radLock
            // 
            this.radLock.AutoSize = true;
            this.radLock.Location = new System.Drawing.Point(13, 27);
            this.radLock.Name = "radLock";
            this.radLock.Size = new System.Drawing.Size(49, 17);
            this.radLock.TabIndex = 2;
            this.radLock.TabStop = true;
            this.radLock.Text = "Lock";
            this.radLock.UseVisualStyleBackColor = true;
            // 
            // radUnlock
            // 
            this.radUnlock.AutoSize = true;
            this.radUnlock.Location = new System.Drawing.Point(13, 63);
            this.radUnlock.Name = "radUnlock";
            this.radUnlock.Size = new System.Drawing.Size(59, 17);
            this.radUnlock.TabIndex = 3;
            this.radUnlock.TabStop = true;
            this.radUnlock.Text = "Unlock";
            this.radUnlock.UseVisualStyleBackColor = true;
            // 
            // frmDoorLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(223, 111);
            this.Controls.Add(this.radUnlock);
            this.Controls.Add(this.radLock);
            this.Controls.Add(this.btnOK);
            this.Name = "frmDoorLock";
            this.Text = "Door_Lock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton radLock;
        private System.Windows.Forms.RadioButton radUnlock;
    }
}