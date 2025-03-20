namespace PhamacyManagement.Admin
{
    partial class UC_AddMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddMedicine));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSanxuat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TxtMedicineID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.TxtNameMedicine = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtMedicineNuber = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnHethan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TxtCostMedicine = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thêm Thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID thuốc";
            // 
            // BtnSanxuat
            // 
            this.BtnSanxuat.Checked = true;
            this.BtnSanxuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSanxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BtnSanxuat.Location = new System.Drawing.Point(471, 560);
            this.BtnSanxuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSanxuat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BtnSanxuat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BtnSanxuat.Name = "BtnSanxuat";
            this.BtnSanxuat.Size = new System.Drawing.Size(364, 44);
            this.BtnSanxuat.TabIndex = 10;
            this.BtnSanxuat.Value = new System.DateTime(2025, 3, 20, 4, 36, 57, 594);
            // 
            // TxtMedicineID
            // 
            this.TxtMedicineID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMedicineID.DefaultText = "";
            this.TxtMedicineID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMedicineID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMedicineID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMedicineID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMedicineID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMedicineID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtMedicineID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMedicineID.Location = new System.Drawing.Point(471, 225);
            this.TxtMedicineID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtMedicineID.Name = "TxtMedicineID";
            this.TxtMedicineID.PlaceholderText = "";
            this.TxtMedicineID.SelectedText = "";
            this.TxtMedicineID.Size = new System.Drawing.Size(364, 46);
            this.TxtMedicineID.TabIndex = 11;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BorderRadius = 19;
            this.btnAddMedicine.BorderThickness = 1;
            this.btnAddMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMedicine.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.Location = new System.Drawing.Point(949, 549);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(153, 55);
            this.btnAddMedicine.TabIndex = 12;
            this.btnAddMedicine.Text = "Thêm";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // TxtNameMedicine
            // 
            this.TxtNameMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNameMedicine.DefaultText = "";
            this.TxtNameMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNameMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNameMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNameMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNameMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNameMedicine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtNameMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNameMedicine.Location = new System.Drawing.Point(471, 341);
            this.TxtNameMedicine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNameMedicine.Name = "TxtNameMedicine";
            this.TxtNameMedicine.PlaceholderText = "";
            this.TxtNameMedicine.SelectedText = "";
            this.TxtNameMedicine.Size = new System.Drawing.Size(364, 44);
            this.TxtNameMedicine.TabIndex = 13;
            // 
            // TxtMedicineNuber
            // 
            this.TxtMedicineNuber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMedicineNuber.DefaultText = "";
            this.TxtMedicineNuber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMedicineNuber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMedicineNuber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMedicineNuber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMedicineNuber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMedicineNuber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtMedicineNuber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMedicineNuber.Location = new System.Drawing.Point(471, 454);
            this.TxtMedicineNuber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtMedicineNuber.Name = "TxtMedicineNuber";
            this.TxtMedicineNuber.PlaceholderText = "";
            this.TxtMedicineNuber.SelectedText = "";
            this.TxtMedicineNuber.Size = new System.Drawing.Size(364, 44);
            this.TxtMedicineNuber.TabIndex = 16;
            // 
            // BtnHethan
            // 
            this.BtnHethan.Checked = true;
            this.BtnHethan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnHethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BtnHethan.Location = new System.Drawing.Point(949, 225);
            this.BtnHethan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHethan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BtnHethan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BtnHethan.Name = "BtnHethan";
            this.BtnHethan.Size = new System.Drawing.Size(364, 44);
            this.BtnHethan.TabIndex = 18;
            this.BtnHethan.Value = new System.DateTime(2025, 3, 20, 3, 32, 58, 180);
            // 
            // TxtCostMedicine
            // 
            this.TxtCostMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCostMedicine.DefaultText = "";
            this.TxtCostMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCostMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCostMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCostMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCostMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCostMedicine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCostMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCostMedicine.Location = new System.Drawing.Point(949, 454);
            this.TxtCostMedicine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCostMedicine.Name = "TxtCostMedicine";
            this.TxtCostMedicine.PlaceholderText = "";
            this.TxtCostMedicine.SelectedText = "";
            this.TxtCostMedicine.Size = new System.Drawing.Size(364, 44);
            this.TxtCostMedicine.TabIndex = 22;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAmount.DefaultText = "";
            this.TxtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAmount.Location = new System.Drawing.Point(949, 341);
            this.TxtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.PlaceholderText = "";
            this.TxtAmount.SelectedText = "";
            this.TxtAmount.Size = new System.Drawing.Size(364, 44);
            this.TxtAmount.TabIndex = 19;
            // 
            // btnReload
            // 
            this.btnReload.BorderRadius = 19;
            this.btnReload.BorderThickness = 1;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.FillColor = System.Drawing.Color.SteelBlue;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(1168, 549);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(153, 55);
            this.btnReload.TabIndex = 24;
            this.btnReload.Text = "Tải lại";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 524);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngày sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(945, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(945, 415);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giá tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(945, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ngày hết hạn";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2PictureBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(45, 225);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(400, 364);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 31;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.TxtCostMedicine);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.BtnHethan);
            this.Controls.Add(this.TxtMedicineNuber);
            this.Controls.Add(this.TxtNameMedicine);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.TxtMedicineID);
            this.Controls.Add(this.BtnSanxuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_AddMedicine";
            this.Size = new System.Drawing.Size(1481, 800);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker BtnSanxuat;
        private Guna.UI2.WinForms.Guna2TextBox TxtMedicineID;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2TextBox TxtNameMedicine;
        private Guna.UI2.WinForms.Guna2TextBox TxtMedicineNuber;
        private Guna.UI2.WinForms.Guna2DateTimePicker BtnHethan;
        private Guna.UI2.WinForms.Guna2TextBox TxtCostMedicine;
        private Guna.UI2.WinForms.Guna2TextBox TxtAmount;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
