
namespace WindowsFormsApp1.Module
{
    partial class ThemNhanVien
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.txtQuanly = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgS = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbbGt = new System.Windows.Forms.ComboBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.Label();
            this.ngs = new System.Windows.Forms.Label();
            this.gt = new System.Windows.Forms.Label();
            this.ht = new System.Windows.Forms.Label();
            this.btnThemQuyen = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(519, 396);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(83, 26);
            this.btnHuy.TabIndex = 41;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Location = new System.Drawing.Point(403, 396);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 26);
            this.btnsua.TabIndex = 39;
            this.btnsua.Text = "Thêm";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // txtQuanly
            // 
            this.txtQuanly.AutoSize = true;
            this.txtQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuanly.ForeColor = System.Drawing.Color.Maroon;
            this.txtQuanly.Location = new System.Drawing.Point(351, 44);
            this.txtQuanly.Name = "txtQuanly";
            this.txtQuanly.Size = new System.Drawing.Size(231, 29);
            this.txtQuanly.TabIndex = 43;
            this.txtQuanly.Text = "THÊM NHÂN VIÊN";
            this.txtQuanly.Click += new System.EventHandler(this.txtQuanly_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(631, 202);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 107);
            this.txtAddress.TabIndex = 59;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(631, 155);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(216, 22);
            this.txtCMND.TabIndex = 57;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(631, 118);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 56;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "CMTND";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtNgS
            // 
            this.dtNgS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgS.Location = new System.Drawing.Point(259, 220);
            this.dtNgS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgS.Name = "dtNgS";
            this.dtNgS.Size = new System.Drawing.Size(191, 22);
            this.dtNgS.TabIndex = 53;
            this.dtNgS.ValueChanged += new System.EventHandler(this.dtNgS_ValueChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(259, 258);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 22);
            this.txtSDT.TabIndex = 52;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // cbbGt
            // 
            this.cbbGt.FormattingEnabled = true;
            this.cbbGt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGt.Location = new System.Drawing.Point(259, 170);
            this.cbbGt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGt.Name = "cbbGt";
            this.cbbGt.Size = new System.Drawing.Size(191, 24);
            this.cbbGt.TabIndex = 51;
            this.cbbGt.SelectedIndexChanged += new System.EventHandler(this.cbbGt_SelectedIndexChanged);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(259, 115);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(191, 22);
            this.txtHoten.TabIndex = 50;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Location = new System.Drawing.Point(144, 263);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(36, 17);
            this.dt.TabIndex = 48;
            this.dt.Text = "SĐT";
            this.dt.Click += new System.EventHandler(this.dt_Click);
            // 
            // ngs
            // 
            this.ngs.AutoSize = true;
            this.ngs.Location = new System.Drawing.Point(144, 220);
            this.ngs.Name = "ngs";
            this.ngs.Size = new System.Drawing.Size(71, 17);
            this.ngs.TabIndex = 47;
            this.ngs.Text = "Ngày sinh";
            this.ngs.Click += new System.EventHandler(this.ngs_Click);
            // 
            // gt
            // 
            this.gt.AutoSize = true;
            this.gt.Location = new System.Drawing.Point(144, 173);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(60, 17);
            this.gt.TabIndex = 46;
            this.gt.Text = "Giới tính";
            this.gt.Click += new System.EventHandler(this.gt_Click);
            // 
            // ht
            // 
            this.ht.AutoSize = true;
            this.ht.Location = new System.Drawing.Point(144, 120);
            this.ht.Name = "ht";
            this.ht.Size = new System.Drawing.Size(50, 17);
            this.ht.TabIndex = 45;
            this.ht.Text = "Họ tên";
            this.ht.Click += new System.EventHandler(this.ht_Click);
            // 
            // btnThemQuyen
            // 
            this.btnThemQuyen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemQuyen.Location = new System.Drawing.Point(244, 396);
            this.btnThemQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemQuyen.Name = "btnThemQuyen";
            this.btnThemQuyen.Size = new System.Drawing.Size(126, 26);
            this.btnThemQuyen.TabIndex = 60;
            this.btnThemQuyen.Text = "Thêm quyền";
            this.btnThemQuyen.UseVisualStyleBackColor = false;
            this.btnThemQuyen.Click += new System.EventHandler(this.btnThemQuyen_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(259, 302);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(191, 22);
            this.txtpass.TabIndex = 62;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 608);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThemQuyen);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtNgS);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.cbbGt);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.ngs);
            this.Controls.Add(this.gt);
            this.Controls.Add(this.ht);
            this.Controls.Add(this.txtQuanly);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnsua);
            this.Name = "ThemNhanVien";
            this.Text = "ThemNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label txtQuanly;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgS;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cbbGt;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.Label ngs;
        private System.Windows.Forms.Label gt;
        private System.Windows.Forms.Label ht;
        private System.Windows.Forms.Button btnThemQuyen;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
    }
}