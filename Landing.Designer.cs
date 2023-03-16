
namespace BankDynamic
{
    partial class landingForm
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
            this.landingTab = new System.Windows.Forms.TabControl();
            this.hashTab = new System.Windows.Forms.TabPage();
            this.viewEditProfileTab = new System.Windows.Forms.TabPage();
            this.welcomeMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewAccNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewFname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.viewLname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.viewGender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.viewAddress = new System.Windows.Forms.TextBox();
            this.editProfileBtn = new System.Windows.Forms.Button();
            this.ackViewProfile = new System.Windows.Forms.Label();
            this.landingTab.SuspendLayout();
            this.viewEditProfileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // landingTab
            // 
            this.landingTab.Controls.Add(this.hashTab);
            this.landingTab.Controls.Add(this.viewEditProfileTab);
            this.landingTab.Location = new System.Drawing.Point(12, 26);
            this.landingTab.Name = "landingTab";
            this.landingTab.SelectedIndex = 0;
            this.landingTab.Size = new System.Drawing.Size(395, 481);
            this.landingTab.TabIndex = 0;
            // 
            // hashTab
            // 
            this.hashTab.Location = new System.Drawing.Point(4, 22);
            this.hashTab.Name = "hashTab";
            this.hashTab.Padding = new System.Windows.Forms.Padding(3);
            this.hashTab.Size = new System.Drawing.Size(387, 455);
            this.hashTab.TabIndex = 0;
            this.hashTab.Text = "#";
            this.hashTab.UseVisualStyleBackColor = true;
            // 
            // viewEditProfileTab
            // 
            this.viewEditProfileTab.Controls.Add(this.ackViewProfile);
            this.viewEditProfileTab.Controls.Add(this.editProfileBtn);
            this.viewEditProfileTab.Controls.Add(this.viewAddress);
            this.viewEditProfileTab.Controls.Add(this.viewGender);
            this.viewEditProfileTab.Controls.Add(this.viewLname);
            this.viewEditProfileTab.Controls.Add(this.viewFname);
            this.viewEditProfileTab.Controls.Add(this.viewMobile);
            this.viewEditProfileTab.Controls.Add(this.viewEmail);
            this.viewEditProfileTab.Controls.Add(this.viewAccNum);
            this.viewEditProfileTab.Controls.Add(this.label7);
            this.viewEditProfileTab.Controls.Add(this.label6);
            this.viewEditProfileTab.Controls.Add(this.label5);
            this.viewEditProfileTab.Controls.Add(this.label4);
            this.viewEditProfileTab.Controls.Add(this.label3);
            this.viewEditProfileTab.Controls.Add(this.label2);
            this.viewEditProfileTab.Controls.Add(this.label1);
            this.viewEditProfileTab.Location = new System.Drawing.Point(4, 22);
            this.viewEditProfileTab.Name = "viewEditProfileTab";
            this.viewEditProfileTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewEditProfileTab.Size = new System.Drawing.Size(387, 455);
            this.viewEditProfileTab.TabIndex = 1;
            this.viewEditProfileTab.Text = "User Details";
            this.viewEditProfileTab.UseVisualStyleBackColor = true;
            // 
            // welcomeMsg
            // 
            this.welcomeMsg.AutoSize = true;
            this.welcomeMsg.BackColor = System.Drawing.SystemColors.Info;
            this.welcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMsg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeMsg.Location = new System.Drawing.Point(13, 7);
            this.welcomeMsg.Name = "welcomeMsg";
            this.welcomeMsg.Size = new System.Drawing.Size(0, 13);
            this.welcomeMsg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acc Num";
            // 
            // viewAccNum
            // 
            this.viewAccNum.BackColor = System.Drawing.SystemColors.Info;
            this.viewAccNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewAccNum.Cursor = System.Windows.Forms.Cursors.No;
            this.viewAccNum.Enabled = false;
            this.viewAccNum.Location = new System.Drawing.Point(86, 65);
            this.viewAccNum.Name = "viewAccNum";
            this.viewAccNum.ReadOnly = true;
            this.viewAccNum.Size = new System.Drawing.Size(251, 20);
            this.viewAccNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // viewEmail
            // 
            this.viewEmail.BackColor = System.Drawing.SystemColors.Info;
            this.viewEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewEmail.Cursor = System.Windows.Forms.Cursors.No;
            this.viewEmail.Enabled = false;
            this.viewEmail.Location = new System.Drawing.Point(86, 91);
            this.viewEmail.Name = "viewEmail";
            this.viewEmail.ReadOnly = true;
            this.viewEmail.Size = new System.Drawing.Size(251, 20);
            this.viewEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile";
            // 
            // viewMobile
            // 
            this.viewMobile.BackColor = System.Drawing.SystemColors.Info;
            this.viewMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewMobile.Cursor = System.Windows.Forms.Cursors.No;
            this.viewMobile.Enabled = false;
            this.viewMobile.Location = new System.Drawing.Point(86, 117);
            this.viewMobile.Name = "viewMobile";
            this.viewMobile.ReadOnly = true;
            this.viewMobile.Size = new System.Drawing.Size(251, 20);
            this.viewMobile.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            // 
            // viewFname
            // 
            this.viewFname.BackColor = System.Drawing.SystemColors.Info;
            this.viewFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viewFname.Location = new System.Drawing.Point(86, 143);
            this.viewFname.Name = "viewFname";
            this.viewFname.Size = new System.Drawing.Size(251, 20);
            this.viewFname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name";
            // 
            // viewLname
            // 
            this.viewLname.BackColor = System.Drawing.SystemColors.Info;
            this.viewLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viewLname.Location = new System.Drawing.Point(86, 169);
            this.viewLname.Name = "viewLname";
            this.viewLname.Size = new System.Drawing.Size(251, 20);
            this.viewLname.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            // 
            // viewGender
            // 
            this.viewGender.BackColor = System.Drawing.SystemColors.Info;
            this.viewGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewGender.Cursor = System.Windows.Forms.Cursors.No;
            this.viewGender.Enabled = false;
            this.viewGender.Location = new System.Drawing.Point(86, 195);
            this.viewGender.Name = "viewGender";
            this.viewGender.ReadOnly = true;
            this.viewGender.Size = new System.Drawing.Size(251, 20);
            this.viewGender.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // viewAddress
            // 
            this.viewAddress.BackColor = System.Drawing.SystemColors.Info;
            this.viewAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viewAddress.Location = new System.Drawing.Point(86, 221);
            this.viewAddress.Multiline = true;
            this.viewAddress.Name = "viewAddress";
            this.viewAddress.Size = new System.Drawing.Size(251, 116);
            this.viewAddress.TabIndex = 13;
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileBtn.Location = new System.Drawing.Point(86, 361);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(251, 42);
            this.editProfileBtn.TabIndex = 14;
            this.editProfileBtn.Text = "E D I T  P R O F I L E";
            this.editProfileBtn.UseVisualStyleBackColor = true;
            this.editProfileBtn.Click += new System.EventHandler(this.editProfileBtn_Click);
            // 
            // ackViewProfile
            // 
            this.ackViewProfile.AutoSize = true;
            this.ackViewProfile.ForeColor = System.Drawing.Color.Red;
            this.ackViewProfile.Location = new System.Drawing.Point(148, 29);
            this.ackViewProfile.Name = "ackViewProfile";
            this.ackViewProfile.Size = new System.Drawing.Size(0, 13);
            this.ackViewProfile.TabIndex = 15;
            // 
            // landingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 519);
            this.Controls.Add(this.welcomeMsg);
            this.Controls.Add(this.landingTab);
            this.Name = "landingForm";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.landingForm_Load);
            this.landingTab.ResumeLayout(false);
            this.viewEditProfileTab.ResumeLayout(false);
            this.viewEditProfileTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl landingTab;
        private System.Windows.Forms.TabPage hashTab;
        private System.Windows.Forms.TabPage viewEditProfileTab;
        private System.Windows.Forms.Label welcomeMsg;
        private System.Windows.Forms.Button editProfileBtn;
        private System.Windows.Forms.TextBox viewAddress;
        private System.Windows.Forms.TextBox viewGender;
        private System.Windows.Forms.TextBox viewLname;
        private System.Windows.Forms.TextBox viewFname;
        private System.Windows.Forms.TextBox viewMobile;
        private System.Windows.Forms.TextBox viewEmail;
        private System.Windows.Forms.TextBox viewAccNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ackViewProfile;
    }
}