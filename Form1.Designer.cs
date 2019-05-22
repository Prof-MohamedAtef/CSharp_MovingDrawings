namespace EX_Moving_P_If_State
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ToolStripStatusLabel_Registeration = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBL_LogIn_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Performance_PrintDialouge = new System.Windows.Forms.PrintDialog();
            this.StationSchedule_PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.StationSchedule_PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.groupBox_LogIN = new System.Windows.Forms.GroupBox();
            this.Btn_Login_Show = new System.Windows.Forms.Button();
            this.Btn_Login_Select_Admins = new System.Windows.Forms.Button();
            this.Txt_LogIn_Password = new System.Windows.Forms.TextBox();
            this.Txt_LogIn_UserName = new System.Windows.Forms.TextBox();
            this.LBL_LogIn_Password = new System.Windows.Forms.Label();
            this.LBL_LogIn_UserName = new System.Windows.Forms.Label();
            this.groupBox_Register = new System.Windows.Forms.GroupBox();
            this.Btn_Register_Show = new System.Windows.Forms.Button();
            this.Btn_Insert_Administrators = new System.Windows.Forms.Button();
            this.Txt_Regis_ConfirmPass = new System.Windows.Forms.TextBox();
            this.LBL_Register_Confirm_Pass = new System.Windows.Forms.Label();
            this.Txt_Regis_Password = new System.Windows.Forms.TextBox();
            this.Txt_Regis_UserName = new System.Windows.Forms.TextBox();
            this.LBL_Register_Password = new System.Windows.Forms.Label();
            this.LBL_Register_UserName = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox_LogIN.SuspendLayout();
            this.groupBox_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.ToolStripStatusLabel_Registeration,
            this.LBL_LogIn_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(525, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // ToolStripStatusLabel_Registeration
            // 
            this.ToolStripStatusLabel_Registeration.Name = "ToolStripStatusLabel_Registeration";
            this.ToolStripStatusLabel_Registeration.Size = new System.Drawing.Size(0, 17);
            // 
            // LBL_LogIn_Status
            // 
            this.LBL_LogIn_Status.Name = "LBL_LogIn_Status";
            this.LBL_LogIn_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // Performance_PrintDialouge
            // 
            this.Performance_PrintDialouge.UseEXDialog = true;
            // 
            // StationSchedule_PrintPreviewDialog
            // 
            this.StationSchedule_PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.StationSchedule_PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.StationSchedule_PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.StationSchedule_PrintPreviewDialog.Enabled = true;
            this.StationSchedule_PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("StationSchedule_PrintPreviewDialog.Icon")));
            this.StationSchedule_PrintPreviewDialog.Name = "StationSchedule_PrintPreviewDialog";
            this.StationSchedule_PrintPreviewDialog.Visible = false;
            // 
            // groupBox_LogIN
            // 
            this.groupBox_LogIN.Controls.Add(this.Btn_Login_Show);
            this.groupBox_LogIN.Controls.Add(this.Btn_Login_Select_Admins);
            this.groupBox_LogIN.Controls.Add(this.Txt_LogIn_Password);
            this.groupBox_LogIN.Controls.Add(this.Txt_LogIn_UserName);
            this.groupBox_LogIN.Controls.Add(this.LBL_LogIn_Password);
            this.groupBox_LogIN.Controls.Add(this.LBL_LogIn_UserName);
            this.groupBox_LogIN.Location = new System.Drawing.Point(264, 12);
            this.groupBox_LogIN.Name = "groupBox_LogIN";
            this.groupBox_LogIN.Size = new System.Drawing.Size(250, 274);
            this.groupBox_LogIN.TabIndex = 19;
            this.groupBox_LogIN.TabStop = false;
            this.groupBox_LogIN.Text = "Log IN";
            // 
            // Btn_Login_Show
            // 
            this.Btn_Login_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login_Show.Location = new System.Drawing.Point(0, 0);
            this.Btn_Login_Show.Name = "Btn_Login_Show";
            this.Btn_Login_Show.Size = new System.Drawing.Size(250, 274);
            this.Btn_Login_Show.TabIndex = 24;
            this.Btn_Login_Show.Text = "Log In";
            this.Btn_Login_Show.UseVisualStyleBackColor = true;
            this.Btn_Login_Show.Click += new System.EventHandler(this.Btn_Login_Show_Click);
            // 
            // Btn_Login_Select_Admins
            // 
            this.Btn_Login_Select_Admins.Location = new System.Drawing.Point(9, 134);
            this.Btn_Login_Select_Admins.Name = "Btn_Login_Select_Admins";
            this.Btn_Login_Select_Admins.Size = new System.Drawing.Size(233, 130);
            this.Btn_Login_Select_Admins.TabIndex = 6;
            this.Btn_Login_Select_Admins.Text = "Log In";
            this.Btn_Login_Select_Admins.UseVisualStyleBackColor = true;
            this.Btn_Login_Select_Admins.Click += new System.EventHandler(this.Btn_Login_Select_Admins_Click);
            // 
            // Txt_LogIn_Password
            // 
            this.Txt_LogIn_Password.Location = new System.Drawing.Point(78, 81);
            this.Txt_LogIn_Password.Name = "Txt_LogIn_Password";
            this.Txt_LogIn_Password.Size = new System.Drawing.Size(164, 20);
            this.Txt_LogIn_Password.TabIndex = 5;
            // 
            // Txt_LogIn_UserName
            // 
            this.Txt_LogIn_UserName.Location = new System.Drawing.Point(78, 34);
            this.Txt_LogIn_UserName.Name = "Txt_LogIn_UserName";
            this.Txt_LogIn_UserName.Size = new System.Drawing.Size(164, 20);
            this.Txt_LogIn_UserName.TabIndex = 4;
            // 
            // LBL_LogIn_Password
            // 
            this.LBL_LogIn_Password.AutoSize = true;
            this.LBL_LogIn_Password.Location = new System.Drawing.Point(6, 81);
            this.LBL_LogIn_Password.Name = "LBL_LogIn_Password";
            this.LBL_LogIn_Password.Size = new System.Drawing.Size(60, 13);
            this.LBL_LogIn_Password.TabIndex = 3;
            this.LBL_LogIn_Password.Text = "Password :";
            // 
            // LBL_LogIn_UserName
            // 
            this.LBL_LogIn_UserName.AutoSize = true;
            this.LBL_LogIn_UserName.Location = new System.Drawing.Point(6, 38);
            this.LBL_LogIn_UserName.Name = "LBL_LogIn_UserName";
            this.LBL_LogIn_UserName.Size = new System.Drawing.Size(66, 13);
            this.LBL_LogIn_UserName.TabIndex = 2;
            this.LBL_LogIn_UserName.Text = "User Name :";
            // 
            // groupBox_Register
            // 
            this.groupBox_Register.Controls.Add(this.Btn_Register_Show);
            this.groupBox_Register.Controls.Add(this.Btn_Insert_Administrators);
            this.groupBox_Register.Controls.Add(this.Txt_Regis_ConfirmPass);
            this.groupBox_Register.Controls.Add(this.LBL_Register_Confirm_Pass);
            this.groupBox_Register.Controls.Add(this.Txt_Regis_Password);
            this.groupBox_Register.Controls.Add(this.Txt_Regis_UserName);
            this.groupBox_Register.Controls.Add(this.LBL_Register_Password);
            this.groupBox_Register.Controls.Add(this.LBL_Register_UserName);
            this.groupBox_Register.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Register.Name = "groupBox_Register";
            this.groupBox_Register.Size = new System.Drawing.Size(246, 274);
            this.groupBox_Register.TabIndex = 18;
            this.groupBox_Register.TabStop = false;
            this.groupBox_Register.Text = "Register";
            // 
            // Btn_Register_Show
            // 
            this.Btn_Register_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register_Show.Location = new System.Drawing.Point(0, 0);
            this.Btn_Register_Show.Name = "Btn_Register_Show";
            this.Btn_Register_Show.Size = new System.Drawing.Size(246, 274);
            this.Btn_Register_Show.TabIndex = 23;
            this.Btn_Register_Show.Text = "Register";
            this.Btn_Register_Show.UseVisualStyleBackColor = true;
            this.Btn_Register_Show.Click += new System.EventHandler(this.Btn_Register_Show_Click);
            // 
            // Btn_Insert_Administrators
            // 
            this.Btn_Insert_Administrators.Location = new System.Drawing.Point(10, 134);
            this.Btn_Insert_Administrators.Name = "Btn_Insert_Administrators";
            this.Btn_Insert_Administrators.Size = new System.Drawing.Size(222, 130);
            this.Btn_Insert_Administrators.TabIndex = 6;
            this.Btn_Insert_Administrators.Text = "Insert";
            this.Btn_Insert_Administrators.UseVisualStyleBackColor = true;
            this.Btn_Insert_Administrators.Click += new System.EventHandler(this.Btn_Insert_Administrators_Click);
            // 
            // Txt_Regis_ConfirmPass
            // 
            this.Txt_Regis_ConfirmPass.Location = new System.Drawing.Point(79, 101);
            this.Txt_Regis_ConfirmPass.Name = "Txt_Regis_ConfirmPass";
            this.Txt_Regis_ConfirmPass.Size = new System.Drawing.Size(153, 20);
            this.Txt_Regis_ConfirmPass.TabIndex = 5;
            // 
            // LBL_Register_Confirm_Pass
            // 
            this.LBL_Register_Confirm_Pass.AutoSize = true;
            this.LBL_Register_Confirm_Pass.Location = new System.Drawing.Point(7, 85);
            this.LBL_Register_Confirm_Pass.Name = "LBL_Register_Confirm_Pass";
            this.LBL_Register_Confirm_Pass.Size = new System.Drawing.Size(100, 13);
            this.LBL_Register_Confirm_Pass.TabIndex = 4;
            this.LBL_Register_Confirm_Pass.Text = "Confirm Password :";
            // 
            // Txt_Regis_Password
            // 
            this.Txt_Regis_Password.Location = new System.Drawing.Point(79, 47);
            this.Txt_Regis_Password.Name = "Txt_Regis_Password";
            this.Txt_Regis_Password.Size = new System.Drawing.Size(153, 20);
            this.Txt_Regis_Password.TabIndex = 3;
            // 
            // Txt_Regis_UserName
            // 
            this.Txt_Regis_UserName.Location = new System.Drawing.Point(79, 17);
            this.Txt_Regis_UserName.Name = "Txt_Regis_UserName";
            this.Txt_Regis_UserName.Size = new System.Drawing.Size(153, 20);
            this.Txt_Regis_UserName.TabIndex = 2;
            // 
            // LBL_Register_Password
            // 
            this.LBL_Register_Password.AutoSize = true;
            this.LBL_Register_Password.Location = new System.Drawing.Point(7, 50);
            this.LBL_Register_Password.Name = "LBL_Register_Password";
            this.LBL_Register_Password.Size = new System.Drawing.Size(53, 13);
            this.LBL_Register_Password.TabIndex = 1;
            this.LBL_Register_Password.Text = "Password";
            // 
            // LBL_Register_UserName
            // 
            this.LBL_Register_UserName.AutoSize = true;
            this.LBL_Register_UserName.Location = new System.Drawing.Point(7, 20);
            this.LBL_Register_UserName.Name = "LBL_Register_UserName";
            this.LBL_Register_UserName.Size = new System.Drawing.Size(66, 13);
            this.LBL_Register_UserName.TabIndex = 0;
            this.LBL_Register_UserName.Text = "User Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 315);
            this.Controls.Add(this.groupBox_LogIN);
            this.Controls.Add(this.groupBox_Register);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_LogIN.ResumeLayout(false);
            this.groupBox_LogIN.PerformLayout();
            this.groupBox_Register.ResumeLayout(false);
            this.groupBox_Register.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.PrintDialog Performance_PrintDialouge;
        private System.Windows.Forms.PrintPreviewDialog StationSchedule_PrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument StationSchedule_PrintDocument;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_Registeration;
        private System.Windows.Forms.GroupBox groupBox_LogIN;
        private System.Windows.Forms.Button Btn_Login_Select_Admins;
        private System.Windows.Forms.TextBox Txt_LogIn_Password;
        private System.Windows.Forms.TextBox Txt_LogIn_UserName;
        private System.Windows.Forms.Label LBL_LogIn_Password;
        private System.Windows.Forms.Label LBL_LogIn_UserName;
        private System.Windows.Forms.GroupBox groupBox_Register;
        private System.Windows.Forms.Button Btn_Insert_Administrators;
        private System.Windows.Forms.TextBox Txt_Regis_ConfirmPass;
        private System.Windows.Forms.Label LBL_Register_Confirm_Pass;
        private System.Windows.Forms.TextBox Txt_Regis_Password;
        private System.Windows.Forms.TextBox Txt_Regis_UserName;
        private System.Windows.Forms.Label LBL_Register_Password;
        private System.Windows.Forms.Label LBL_Register_UserName;
        private System.Windows.Forms.ToolStripStatusLabel LBL_LogIn_Status;
        private System.Windows.Forms.Button Btn_Register_Show;
        private System.Windows.Forms.Button Btn_Login_Show;
    }
}

