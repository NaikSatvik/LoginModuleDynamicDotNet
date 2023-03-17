
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
            this.accDetailsTab = new System.Windows.Forms.TabPage();
            this.balance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.accDetAccNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.viewEditProfileTab = new System.Windows.Forms.TabPage();
            this.ackViewProfile = new System.Windows.Forms.Label();
            this.editProfileBtn = new System.Windows.Forms.Button();
            this.viewAddress = new System.Windows.Forms.TextBox();
            this.viewGender = new System.Windows.Forms.TextBox();
            this.viewLname = new System.Windows.Forms.TextBox();
            this.viewFname = new System.Windows.Forms.TextBox();
            this.viewMobile = new System.Windows.Forms.TextBox();
            this.viewEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.atmTab = new System.Windows.Forms.TabPage();
            this.depositPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.depositPin = new System.Windows.Forms.TextBox();
            this.depositAmt = new System.Windows.Forms.TextBox();
            this.depositRed = new System.Windows.Forms.LinkLabel();
            this.withdrawRed = new System.Windows.Forms.LinkLabel();
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.withdrawPin = new System.Windows.Forms.TextBox();
            this.withdrawAmt = new System.Windows.Forms.TextBox();
            this.welcomeMsg = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.LinkLabel();
            this.ackAtm = new System.Windows.Forms.Label();
            this.tHistoryPanel = new System.Windows.Forms.TabPage();
            this.viewTransactionGrid = new System.Windows.Forms.DataGridView();
            this.ackTransactions = new System.Windows.Forms.Label();
            this.landingTab.SuspendLayout();
            this.accDetailsTab.SuspendLayout();
            this.viewEditProfileTab.SuspendLayout();
            this.atmTab.SuspendLayout();
            this.depositPanel.SuspendLayout();
            this.withdrawPanel.SuspendLayout();
            this.tHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTransactionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // landingTab
            // 
            this.landingTab.Controls.Add(this.accDetailsTab);
            this.landingTab.Controls.Add(this.viewEditProfileTab);
            this.landingTab.Controls.Add(this.atmTab);
            this.landingTab.Controls.Add(this.tHistoryPanel);
            this.landingTab.Location = new System.Drawing.Point(12, 26);
            this.landingTab.Name = "landingTab";
            this.landingTab.SelectedIndex = 0;
            this.landingTab.Size = new System.Drawing.Size(395, 481);
            this.landingTab.TabIndex = 0;
            // 
            // accDetailsTab
            // 
            this.accDetailsTab.BackColor = System.Drawing.Color.Silver;
            this.accDetailsTab.Controls.Add(this.balance);
            this.accDetailsTab.Controls.Add(this.label9);
            this.accDetailsTab.Controls.Add(this.accDetAccNum);
            this.accDetailsTab.Controls.Add(this.label8);
            this.accDetailsTab.Location = new System.Drawing.Point(4, 22);
            this.accDetailsTab.Name = "accDetailsTab";
            this.accDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.accDetailsTab.Size = new System.Drawing.Size(387, 455);
            this.accDetailsTab.TabIndex = 0;
            this.accDetailsTab.Text = "Account Details";
            // 
            // balance
            // 
            this.balance.BackColor = System.Drawing.SystemColors.Info;
            this.balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balance.Cursor = System.Windows.Forms.Cursors.No;
            this.balance.Enabled = false;
            this.balance.Location = new System.Drawing.Point(105, 103);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(228, 20);
            this.balance.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Balance";
            // 
            // accDetAccNum
            // 
            this.accDetAccNum.BackColor = System.Drawing.SystemColors.Info;
            this.accDetAccNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accDetAccNum.Cursor = System.Windows.Forms.Cursors.No;
            this.accDetAccNum.Enabled = false;
            this.accDetAccNum.Location = new System.Drawing.Point(105, 65);
            this.accDetAccNum.Name = "accDetAccNum";
            this.accDetAccNum.Size = new System.Drawing.Size(228, 20);
            this.accDetAccNum.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Acc Num";
            // 
            // viewEditProfileTab
            // 
            this.viewEditProfileTab.BackColor = System.Drawing.Color.Silver;
            this.viewEditProfileTab.Controls.Add(this.ackViewProfile);
            this.viewEditProfileTab.Controls.Add(this.editProfileBtn);
            this.viewEditProfileTab.Controls.Add(this.viewAddress);
            this.viewEditProfileTab.Controls.Add(this.viewGender);
            this.viewEditProfileTab.Controls.Add(this.viewLname);
            this.viewEditProfileTab.Controls.Add(this.viewFname);
            this.viewEditProfileTab.Controls.Add(this.viewMobile);
            this.viewEditProfileTab.Controls.Add(this.viewEmail);
            this.viewEditProfileTab.Controls.Add(this.label7);
            this.viewEditProfileTab.Controls.Add(this.label6);
            this.viewEditProfileTab.Controls.Add(this.label5);
            this.viewEditProfileTab.Controls.Add(this.label4);
            this.viewEditProfileTab.Controls.Add(this.label3);
            this.viewEditProfileTab.Controls.Add(this.label2);
            this.viewEditProfileTab.Location = new System.Drawing.Point(4, 22);
            this.viewEditProfileTab.Name = "viewEditProfileTab";
            this.viewEditProfileTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewEditProfileTab.Size = new System.Drawing.Size(387, 455);
            this.viewEditProfileTab.TabIndex = 1;
            this.viewEditProfileTab.Text = "User Details";
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
            // editProfileBtn
            // 
            this.editProfileBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileBtn.Location = new System.Drawing.Point(86, 340);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(251, 42);
            this.editProfileBtn.TabIndex = 14;
            this.editProfileBtn.Text = "E D I T  P R O F I L E";
            this.editProfileBtn.UseVisualStyleBackColor = false;
            this.editProfileBtn.Click += new System.EventHandler(this.editProfileBtn_Click);
            // 
            // viewAddress
            // 
            this.viewAddress.BackColor = System.Drawing.SystemColors.Info;
            this.viewAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viewAddress.Location = new System.Drawing.Point(86, 200);
            this.viewAddress.Multiline = true;
            this.viewAddress.Name = "viewAddress";
            this.viewAddress.Size = new System.Drawing.Size(251, 116);
            this.viewAddress.TabIndex = 13;
            // 
            // viewGender
            // 
            this.viewGender.BackColor = System.Drawing.SystemColors.Info;
            this.viewGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewGender.Cursor = System.Windows.Forms.Cursors.No;
            this.viewGender.Enabled = false;
            this.viewGender.Location = new System.Drawing.Point(86, 174);
            this.viewGender.Name = "viewGender";
            this.viewGender.ReadOnly = true;
            this.viewGender.Size = new System.Drawing.Size(251, 20);
            this.viewGender.TabIndex = 11;
            // 
            // viewLname
            // 
            this.viewLname.BackColor = System.Drawing.SystemColors.Info;
            this.viewLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viewLname.Location = new System.Drawing.Point(86, 148);
            this.viewLname.Name = "viewLname";
            this.viewLname.Size = new System.Drawing.Size(251, 20);
            this.viewLname.TabIndex = 9;
            // 
            // viewFname
            // 
            this.viewFname.BackColor = System.Drawing.SystemColors.Info;
            this.viewFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viewFname.Location = new System.Drawing.Point(86, 122);
            this.viewFname.Name = "viewFname";
            this.viewFname.Size = new System.Drawing.Size(251, 20);
            this.viewFname.TabIndex = 7;
            // 
            // viewMobile
            // 
            this.viewMobile.BackColor = System.Drawing.SystemColors.Info;
            this.viewMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewMobile.Cursor = System.Windows.Forms.Cursors.No;
            this.viewMobile.Enabled = false;
            this.viewMobile.Location = new System.Drawing.Point(86, 96);
            this.viewMobile.Name = "viewMobile";
            this.viewMobile.ReadOnly = true;
            this.viewMobile.Size = new System.Drawing.Size(251, 20);
            this.viewMobile.TabIndex = 5;
            // 
            // viewEmail
            // 
            this.viewEmail.BackColor = System.Drawing.SystemColors.Info;
            this.viewEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewEmail.Cursor = System.Windows.Forms.Cursors.No;
            this.viewEmail.Enabled = false;
            this.viewEmail.Location = new System.Drawing.Point(86, 70);
            this.viewEmail.Name = "viewEmail";
            this.viewEmail.ReadOnly = true;
            this.viewEmail.Size = new System.Drawing.Size(251, 20);
            this.viewEmail.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // atmTab
            // 
            this.atmTab.Controls.Add(this.ackAtm);
            this.atmTab.Controls.Add(this.depositPanel);
            this.atmTab.Controls.Add(this.depositRed);
            this.atmTab.Controls.Add(this.withdrawRed);
            this.atmTab.Controls.Add(this.withdrawPanel);
            this.atmTab.Location = new System.Drawing.Point(4, 22);
            this.atmTab.Name = "atmTab";
            this.atmTab.Size = new System.Drawing.Size(387, 455);
            this.atmTab.TabIndex = 2;
            this.atmTab.Text = "ATM";
            this.atmTab.UseVisualStyleBackColor = true;
            // 
            // depositPanel
            // 
            this.depositPanel.Controls.Add(this.label10);
            this.depositPanel.Controls.Add(this.label11);
            this.depositPanel.Controls.Add(this.depositBtn);
            this.depositPanel.Controls.Add(this.depositPin);
            this.depositPanel.Controls.Add(this.depositAmt);
            this.depositPanel.Location = new System.Drawing.Point(61, 81);
            this.depositPanel.Name = "depositPanel";
            this.depositPanel.Size = new System.Drawing.Size(265, 182);
            this.depositPanel.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "PIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Amount";
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.depositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.Location = new System.Drawing.Point(112, 133);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(75, 23);
            this.depositBtn.TabIndex = 0;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // depositPin
            // 
            this.depositPin.BackColor = System.Drawing.SystemColors.Info;
            this.depositPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depositPin.Location = new System.Drawing.Point(112, 91);
            this.depositPin.Name = "depositPin";
            this.depositPin.Size = new System.Drawing.Size(100, 20);
            this.depositPin.TabIndex = 1;
            // 
            // depositAmt
            // 
            this.depositAmt.BackColor = System.Drawing.SystemColors.Info;
            this.depositAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depositAmt.Location = new System.Drawing.Point(112, 44);
            this.depositAmt.Name = "depositAmt";
            this.depositAmt.Size = new System.Drawing.Size(100, 20);
            this.depositAmt.TabIndex = 0;
            // 
            // depositRed
            // 
            this.depositRed.AutoSize = true;
            this.depositRed.Location = new System.Drawing.Point(270, 57);
            this.depositRed.Name = "depositRed";
            this.depositRed.Size = new System.Drawing.Size(43, 13);
            this.depositRed.TabIndex = 4;
            this.depositRed.TabStop = true;
            this.depositRed.Text = "Deposit";
            this.depositRed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.depositRed_LinkClicked);
            // 
            // withdrawRed
            // 
            this.withdrawRed.AutoSize = true;
            this.withdrawRed.Location = new System.Drawing.Point(71, 57);
            this.withdrawRed.Name = "withdrawRed";
            this.withdrawRed.Size = new System.Drawing.Size(52, 13);
            this.withdrawRed.TabIndex = 3;
            this.withdrawRed.TabStop = true;
            this.withdrawRed.Text = "Withdraw";
            this.withdrawRed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.withdrawRed_LinkClicked);
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.Controls.Add(this.label1);
            this.withdrawPanel.Controls.Add(this.label);
            this.withdrawPanel.Controls.Add(this.withdrawBtn);
            this.withdrawPanel.Controls.Add(this.withdrawPin);
            this.withdrawPanel.Controls.Add(this.withdrawAmt);
            this.withdrawPanel.Location = new System.Drawing.Point(61, 81);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(265, 182);
            this.withdrawPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PIN";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Amount";
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.withdrawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBtn.Location = new System.Drawing.Point(112, 133);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(75, 23);
            this.withdrawBtn.TabIndex = 0;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // withdrawPin
            // 
            this.withdrawPin.BackColor = System.Drawing.SystemColors.Info;
            this.withdrawPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.withdrawPin.Location = new System.Drawing.Point(112, 91);
            this.withdrawPin.Name = "withdrawPin";
            this.withdrawPin.Size = new System.Drawing.Size(100, 20);
            this.withdrawPin.TabIndex = 1;
            // 
            // withdrawAmt
            // 
            this.withdrawAmt.BackColor = System.Drawing.SystemColors.Info;
            this.withdrawAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.withdrawAmt.Location = new System.Drawing.Point(112, 44);
            this.withdrawAmt.Name = "withdrawAmt";
            this.withdrawAmt.Size = new System.Drawing.Size(100, 20);
            this.withdrawAmt.TabIndex = 0;
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
            // logOut
            // 
            this.logOut.AutoSize = true;
            this.logOut.Location = new System.Drawing.Point(358, 10);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(45, 13);
            this.logOut.TabIndex = 2;
            this.logOut.TabStop = true;
            this.logOut.Text = "Log Out";
            this.logOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOut_LinkClicked);
            // 
            // ackAtm
            // 
            this.ackAtm.AutoSize = true;
            this.ackAtm.ForeColor = System.Drawing.Color.Red;
            this.ackAtm.Location = new System.Drawing.Point(161, 26);
            this.ackAtm.Name = "ackAtm";
            this.ackAtm.Size = new System.Drawing.Size(0, 13);
            this.ackAtm.TabIndex = 5;
            // 
            // tHistoryPanel
            // 
            this.tHistoryPanel.Controls.Add(this.ackTransactions);
            this.tHistoryPanel.Controls.Add(this.viewTransactionGrid);
            this.tHistoryPanel.Location = new System.Drawing.Point(4, 22);
            this.tHistoryPanel.Name = "tHistoryPanel";
            this.tHistoryPanel.Size = new System.Drawing.Size(387, 455);
            this.tHistoryPanel.TabIndex = 3;
            this.tHistoryPanel.Text = "Transaction History";
            this.tHistoryPanel.UseVisualStyleBackColor = true;
            // 
            // viewTransactionGrid
            // 
            this.viewTransactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTransactionGrid.Location = new System.Drawing.Point(3, 3);
            this.viewTransactionGrid.Name = "viewTransactionGrid";
            this.viewTransactionGrid.Size = new System.Drawing.Size(381, 449);
            this.viewTransactionGrid.TabIndex = 0;
            // 
            // ackTransactions
            // 
            this.ackTransactions.AutoSize = true;
            this.ackTransactions.ForeColor = System.Drawing.Color.Red;
            this.ackTransactions.Location = new System.Drawing.Point(71, 12);
            this.ackTransactions.Name = "ackTransactions";
            this.ackTransactions.Size = new System.Drawing.Size(0, 13);
            this.ackTransactions.TabIndex = 1;
            // 
            // landingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 519);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.welcomeMsg);
            this.Controls.Add(this.landingTab);
            this.MaximizeBox = false;
            this.Name = "landingForm";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.landingForm_Load);
            this.landingTab.ResumeLayout(false);
            this.accDetailsTab.ResumeLayout(false);
            this.accDetailsTab.PerformLayout();
            this.viewEditProfileTab.ResumeLayout(false);
            this.viewEditProfileTab.PerformLayout();
            this.atmTab.ResumeLayout(false);
            this.atmTab.PerformLayout();
            this.depositPanel.ResumeLayout(false);
            this.depositPanel.PerformLayout();
            this.withdrawPanel.ResumeLayout(false);
            this.withdrawPanel.PerformLayout();
            this.tHistoryPanel.ResumeLayout(false);
            this.tHistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTransactionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl landingTab;
        private System.Windows.Forms.TabPage accDetailsTab;
        private System.Windows.Forms.TabPage viewEditProfileTab;
        private System.Windows.Forms.Label welcomeMsg;
        private System.Windows.Forms.Button editProfileBtn;
        private System.Windows.Forms.TextBox viewAddress;
        private System.Windows.Forms.TextBox viewGender;
        private System.Windows.Forms.TextBox viewLname;
        private System.Windows.Forms.TextBox viewFname;
        private System.Windows.Forms.TextBox viewMobile;
        private System.Windows.Forms.TextBox viewEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ackViewProfile;
        private System.Windows.Forms.LinkLabel logOut;
        private System.Windows.Forms.TextBox accDetAccNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage atmTab;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.LinkLabel depositRed;
        private System.Windows.Forms.LinkLabel withdrawRed;
        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox withdrawPin;
        private System.Windows.Forms.TextBox withdrawAmt;
        private System.Windows.Forms.Panel depositPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.TextBox depositPin;
        private System.Windows.Forms.TextBox depositAmt;
        private System.Windows.Forms.Label ackAtm;
        private System.Windows.Forms.TabPage tHistoryPanel;
        private System.Windows.Forms.DataGridView viewTransactionGrid;
        private System.Windows.Forms.Label ackTransactions;
    }
}