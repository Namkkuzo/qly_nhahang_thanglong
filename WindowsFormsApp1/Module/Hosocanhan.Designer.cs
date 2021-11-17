
namespace WindowsFormsApp1
{
    partial class Hosocanhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtQuanly = new System.Windows.Forms.Label();
            this.ma = new System.Windows.Forms.Label();
            this.gt = new System.Windows.Forms.Label();
            this.ngs = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cbbGt = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtNgS = new System.Windows.Forms.DateTimePicker();
            this.dtgNV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPassportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ht = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuanly
            // 
            this.txtQuanly.AutoSize = true;
            this.txtQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuanly.ForeColor = System.Drawing.Color.Maroon;
            this.txtQuanly.Location = new System.Drawing.Point(209, 20);
            this.txtQuanly.Name = "txtQuanly";
            this.txtQuanly.Size = new System.Drawing.Size(269, 29);
            this.txtQuanly.TabIndex = 0;
            this.txtQuanly.Text = "QUẢN LÝ NHÂN VIÊN";
            this.txtQuanly.Click += new System.EventHandler(this.label1_Click);
            // 
            // ma
            // 
            this.ma.AutoSize = true;
            this.ma.Location = new System.Drawing.Point(99, 69);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(93, 17);
            this.ma.TabIndex = 1;
            this.ma.Text = "Mã nhân viên";
            // 
            // gt
            // 
            this.gt.AutoSize = true;
            this.gt.Location = new System.Drawing.Point(99, 153);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(60, 17);
            this.gt.TabIndex = 3;
            this.gt.Text = "Giới tính";
            // 
            // ngs
            // 
            this.ngs.AutoSize = true;
            this.ngs.Location = new System.Drawing.Point(99, 200);
            this.ngs.Name = "ngs";
            this.ngs.Size = new System.Drawing.Size(71, 17);
            this.ngs.TabIndex = 4;
            this.ngs.Text = "Ngày sinh";
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Location = new System.Drawing.Point(99, 243);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(36, 17);
            this.dt.TabIndex = 5;
            this.dt.Text = "SĐT";
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(214, 69);
            this.txtmaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(191, 22);
            this.txtmaNV.TabIndex = 10;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(214, 106);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(191, 22);
            this.txtHoten.TabIndex = 11;
            // 
            // cbbGt
            // 
            this.cbbGt.FormattingEnabled = true;
            this.cbbGt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGt.Location = new System.Drawing.Point(214, 150);
            this.cbbGt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGt.Name = "cbbGt";
            this.cbbGt.Size = new System.Drawing.Size(191, 24);
            this.cbbGt.TabIndex = 12;
            this.cbbGt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(214, 238);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 22);
            this.txtSDT.TabIndex = 13;
            // 
            // dtNgS
            // 
            this.dtNgS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgS.Location = new System.Drawing.Point(214, 200);
            this.dtNgS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgS.Name = "dtNgS";
            this.dtNgS.Size = new System.Drawing.Size(191, 22);
            this.dtNgS.TabIndex = 16;
            // 
            // dtgNV
            // 
            this.dtgNV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.sFullName,
            this.bGender,
            this.dDateOfBirth,
            this.sPhone,
            this.sPassportNumber,
            this.email,
            this.sAddress});
            this.dtgNV.Location = new System.Drawing.Point(12, 326);
            this.dtgNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgNV.Name = "dtgNV";
            this.dtgNV.RowHeadersWidth = 51;
            this.dtgNV.RowTemplate.Height = 24;
            this.dtgNV.Size = new System.Drawing.Size(1328, 363);
            this.dtgNV.TabIndex = 17;
            this.dtgNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNV_CellClick);
            this.dtgNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNV_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Mã nhân viên";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // sFullName
            // 
            this.sFullName.DataPropertyName = "sFullName";
            this.sFullName.Frozen = true;
            this.sFullName.HeaderText = "Họ tên";
            this.sFullName.MinimumWidth = 6;
            this.sFullName.Name = "sFullName";
            this.sFullName.Width = 125;
            // 
            // bGender
            // 
            this.bGender.DataPropertyName = "bGender";
            this.bGender.Frozen = true;
            this.bGender.HeaderText = "Giới tính";
            this.bGender.MinimumWidth = 6;
            this.bGender.Name = "bGender";
            this.bGender.Width = 80;
            // 
            // dDateOfBirth
            // 
            this.dDateOfBirth.DataPropertyName = "dDateOfBirth";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dDateOfBirth.DefaultCellStyle = dataGridViewCellStyle1;
            this.dDateOfBirth.Frozen = true;
            this.dDateOfBirth.HeaderText = "Ngày Sinh";
            this.dDateOfBirth.MinimumWidth = 6;
            this.dDateOfBirth.Name = "dDateOfBirth";
            this.dDateOfBirth.Width = 125;
            // 
            // sPhone
            // 
            this.sPhone.DataPropertyName = "sPhone";
            this.sPhone.Frozen = true;
            this.sPhone.HeaderText = "Số Điện Thoại";
            this.sPhone.MinimumWidth = 6;
            this.sPhone.Name = "sPhone";
            this.sPhone.Width = 125;
            // 
            // sPassportNumber
            // 
            this.sPassportNumber.DataPropertyName = "sPassportNumber";
            this.sPassportNumber.Frozen = true;
            this.sPassportNumber.HeaderText = "CMND";
            this.sPassportNumber.MinimumWidth = 6;
            this.sPassportNumber.Name = "sPassportNumber";
            this.sPassportNumber.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.Frozen = true;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // sAddress
            // 
            this.sAddress.DataPropertyName = "sAddress";
            this.sAddress.Frozen = true;
            this.sAddress.HeaderText = "Address";
            this.sAddress.MinimumWidth = 6;
            this.sAddress.Name = "sAddress";
            this.sAddress.Width = 125;
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Location = new System.Drawing.Point(911, 67);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(127, 26);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntim.Location = new System.Drawing.Point(911, 168);
            this.btntim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(127, 26);
            this.btntim.TabIndex = 23;
            this.btntim.Text = "Lọc nhân viên";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCyan;
            this.btnReset.Location = new System.Drawing.Point(911, 253);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 28);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(911, 119);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 26);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(586, 106);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(216, 22);
            this.txtCMND.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(586, 69);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(586, 153);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 107);
            this.txtAddress.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "CMTND";
            // 
            // ht
            // 
            this.ht.AutoSize = true;
            this.ht.Location = new System.Drawing.Point(99, 109);
            this.ht.Name = "ht";
            this.ht.Size = new System.Drawing.Size(50, 17);
            this.ht.TabIndex = 2;
            this.ht.Text = "Họ tên";
            this.ht.Click += new System.EventHandler(this.ht_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(911, 213);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 26);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm nhân viên mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // Hosocanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 697);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.dtgNV);
            this.Controls.Add(this.dtNgS);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.cbbGt);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtmaNV);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.ngs);
            this.Controls.Add(this.gt);
            this.Controls.Add(this.ht);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.txtQuanly);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hosocanhan";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Hosocanhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtQuanly;
        private System.Windows.Forms.Label ma;
        private System.Windows.Forms.Label gt;
        private System.Windows.Forms.Label ngs;
        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cbbGt;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dtNgS;
        private System.Windows.Forms.DataGridView dtgNV;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPassportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddress;
        private System.Windows.Forms.Button btnThem;
    }
}