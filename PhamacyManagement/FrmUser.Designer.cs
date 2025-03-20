namespace PhamacyManagement
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.LbUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDashBroadM = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckValid = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_AddMedicine3 = new PhamacyManagement.Admin.UC_AddMedicine();
            this.uC_AddMedicine2 = new PhamacyManagement.Admin.UC_AddMedicine();
            this.uC_AddMedicine1 = new PhamacyManagement.Admin.UC_AddMedicine();
            this.uC_ViewUsers1 = new PhamacyManagement.Admin.UC_ViewUsers();
            this.uC_AddMedicine4 = new PhamacyManagement.Admin.UC_AddMedicine();
            this.uC_DashBoard1 = new PhamacyManagement.User_Medicine.UC_DashBoard();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.LbUser);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.BtnDashBroadM);
            this.guna2Panel1.Controls.Add(this.btnSellMedicine);
            this.guna2Panel1.Controls.Add(this.btnCheckValid);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.btnViewMedicine);
            this.guna2Panel1.Controls.Add(this.btnAddMedicine);
            this.guna2Panel1.Controls.Add(this.btnLogOut);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(239, 650);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(243, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 100);
            this.guna2Panel2.TabIndex = 1;
            // 
            // LbUser
            // 
            this.LbUser.AutoSize = true;
            this.LbUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbUser.Location = new System.Drawing.Point(94, 236);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(73, 22);
            this.LbUser.TabIndex = 7;
            this.LbUser.Text = "Dược Sĩ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(272, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_AddMedicine3);
            this.panel2.Controls.Add(this.uC_AddMedicine2);
            this.panel2.Controls.Add(this.uC_AddMedicine1);
            this.panel2.Controls.Add(this.uC_ViewUsers1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // BtnDashBroadM
            // 
            this.BtnDashBroadM.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnDashBroadM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashBroadM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashBroadM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDashBroadM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDashBroadM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.BtnDashBroadM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashBroadM.ForeColor = System.Drawing.Color.White;
            this.BtnDashBroadM.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashBroadM.Image")));
            this.BtnDashBroadM.Location = new System.Drawing.Point(0, 272);
            this.BtnDashBroadM.Name = "BtnDashBroadM";
            this.BtnDashBroadM.Size = new System.Drawing.Size(237, 45);
            this.BtnDashBroadM.TabIndex = 1;
            this.BtnDashBroadM.Text = "Dash Broad";
            this.BtnDashBroadM.Click += new System.EventHandler(this.BtnDashBroadM_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSellMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSellMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.btnSellMedicine.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMedicine.Image")));
            this.btnSellMedicine.Location = new System.Drawing.Point(0, 519);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Size = new System.Drawing.Size(237, 45);
            this.btnSellMedicine.TabIndex = 6;
            this.btnSellMedicine.Text = "Sell Medicine";
            // 
            // btnCheckValid
            // 
            this.btnCheckValid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckValid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckValid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckValid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckValid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.btnCheckValid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckValid.ForeColor = System.Drawing.Color.White;
            this.btnCheckValid.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckValid.Image")));
            this.btnCheckValid.Location = new System.Drawing.Point(6, 468);
            this.btnCheckValid.Name = "btnCheckValid";
            this.btnCheckValid.Size = new System.Drawing.Size(234, 45);
            this.btnCheckValid.TabIndex = 4;
            this.btnCheckValid.Text = "Medicine Validity Check";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.btnViewMedicine.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.Location = new System.Drawing.Point(3, 402);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(234, 45);
            this.btnViewMedicine.TabIndex = 3;
            this.btnViewMedicine.Text = "View Medicine";
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.Location = new System.Drawing.Point(3, 332);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(234, 45);
            this.btnAddMedicine.TabIndex = 2;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(0, 581);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(237, 45);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Location = new System.Drawing.Point(246, 12);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(200, 100);
            this.guna2Panel3.TabIndex = 2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.guna2Panel2;
            // 
            // uC_AddMedicine3
            // 
            this.uC_AddMedicine3.Location = new System.Drawing.Point(64, 63);
            this.uC_AddMedicine3.Name = "uC_AddMedicine3";
            this.uC_AddMedicine3.Size = new System.Drawing.Size(1111, 650);
            this.uC_AddMedicine3.TabIndex = 5;
            // 
            // uC_AddMedicine2
            // 
            this.uC_AddMedicine2.Location = new System.Drawing.Point(-41, -3);
            this.uC_AddMedicine2.Name = "uC_AddMedicine2";
            this.uC_AddMedicine2.Size = new System.Drawing.Size(1111, 650);
            this.uC_AddMedicine2.TabIndex = 4;
            // 
            // uC_AddMedicine1
            // 
            this.uC_AddMedicine1.Location = new System.Drawing.Point(-41, -3);
            this.uC_AddMedicine1.Name = "uC_AddMedicine1";
            this.uC_AddMedicine1.Size = new System.Drawing.Size(1111, 650);
            this.uC_AddMedicine1.TabIndex = 4;
            // 
            // uC_ViewUsers1
            // 
            this.uC_ViewUsers1.Location = new System.Drawing.Point(-3, 51);
            this.uC_ViewUsers1.Name = "uC_ViewUsers1";
            this.uC_ViewUsers1.Size = new System.Drawing.Size(1111, 650);
            this.uC_ViewUsers1.TabIndex = 1;
            // 
            // uC_AddMedicine4
            // 
            this.uC_AddMedicine4.Location = new System.Drawing.Point(234, 0);
            this.uC_AddMedicine4.Name = "uC_AddMedicine4";
            this.uC_AddMedicine4.Size = new System.Drawing.Size(1111, 650);
            this.uC_AddMedicine4.TabIndex = 0;
            // 
            // uC_DashBoard1
            // 
            this.uC_DashBoard1.Location = new System.Drawing.Point(234, 3);
            this.uC_DashBoard1.Name = "uC_DashBoard1";
            this.uC_DashBoard1.Size = new System.Drawing.Size(1111, 650);
            this.uC_DashBoard1.TabIndex = 3;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 650);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.uC_AddMedicine4);
            this.Controls.Add(this.uC_DashBoard1);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label LbUser;
        private Guna.UI2.WinForms.Guna2Button btnSellMedicine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Admin.UC_ViewUsers uC_ViewUsers1;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnCheckValid;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button BtnDashBroadM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private User_Medicine.UC_DashBoard uC_DashBoard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Admin.UC_AddMedicine uC_AddMedicine1;
        private Admin.UC_AddMedicine uC_AddMedicine3;
        private Admin.UC_AddMedicine uC_AddMedicine2;
        private Admin.UC_AddMedicine uC_AddMedicine4;
    }
}