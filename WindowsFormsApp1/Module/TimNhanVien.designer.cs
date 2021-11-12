
namespace WindowsFormsApp1
{
    partial class TimNhanVien
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
            this.cbgt = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsdt = new System.Windows.Forms.CheckBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbngaysinh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbten = new System.Windows.Forms.CheckBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApDung = new System.Windows.Forms.Button();
            this.cbbGt = new System.Windows.Forms.ComboBox();
            this.dtNgS = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbgt
            // 
            this.cbgt.AutoSize = true;
            this.cbgt.Location = new System.Drawing.Point(537, 128);
            this.cbgt.Margin = new System.Windows.Forms.Padding(4);
            this.cbgt.Name = "cbgt";
            this.cbgt.Size = new System.Drawing.Size(141, 21);
            this.cbgt.TabIndex = 42;
            this.cbgt.Text = "Tìm theo Giới tính";
            this.cbgt.UseVisualStyleBackColor = true;
            this.cbgt.CheckedChanged += new System.EventHandler(this.cbgt_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Giới tính";
            // 
            // cbsdt
            // 
            this.cbsdt.AutoSize = true;
            this.cbsdt.Location = new System.Drawing.Point(131, 211);
            this.cbsdt.Margin = new System.Windows.Forms.Padding(4);
            this.cbsdt.Name = "cbsdt";
            this.cbsdt.Size = new System.Drawing.Size(170, 21);
            this.cbsdt.TabIndex = 39;
            this.cbsdt.Text = "Tìm theo số điện thoại";
            this.cbsdt.UseVisualStyleBackColor = true;
            this.cbsdt.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(222, 245);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(211, 22);
            this.txtsdt.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "SĐT";
            // 
            // cbngaysinh
            // 
            this.cbngaysinh.AutoSize = true;
            this.cbngaysinh.Location = new System.Drawing.Point(547, 221);
            this.cbngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbngaysinh.Name = "cbngaysinh";
            this.cbngaysinh.Size = new System.Drawing.Size(150, 21);
            this.cbngaysinh.TabIndex = 33;
            this.cbngaysinh.Text = "Tìm theo ngày sinh";
            this.cbngaysinh.UseVisualStyleBackColor = true;
            this.cbngaysinh.CheckedChanged += new System.EventHandler(this.cbngaysinh_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ngày sinh";
            // 
            // cbten
            // 
            this.cbten.AutoSize = true;
            this.cbten.Location = new System.Drawing.Point(124, 124);
            this.cbten.Margin = new System.Windows.Forms.Padding(4);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(129, 21);
            this.cbten.TabIndex = 30;
            this.cbten.Text = "Tìm theo họ tên";
            this.cbten.UseVisualStyleBackColor = true;
            this.cbten.CheckedChanged += new System.EventHandler(this.cbten_CheckedChanged);
            // 
            // txtten
            // 
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(222, 155);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(211, 22);
            this.txtten.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên nhân viên";
            // 
            // btnApDung
            // 
            this.btnApDung.Location = new System.Drawing.Point(427, 477);
            this.btnApDung.Margin = new System.Windows.Forms.Padding(4);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(165, 47);
            this.btnApDung.TabIndex = 43;
            this.btnApDung.Text = "Áp dụng";
            this.btnApDung.UseVisualStyleBackColor = true;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // cbbGt
            // 
            this.cbbGt.Enabled = false;
            this.cbbGt.FormattingEnabled = true;
            this.cbbGt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGt.Location = new System.Drawing.Point(628, 159);
            this.cbbGt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGt.Name = "cbbGt";
            this.cbbGt.Size = new System.Drawing.Size(204, 24);
            this.cbbGt.TabIndex = 44;
            // 
            // dtNgS
            // 
            this.dtNgS.Enabled = false;
            this.dtNgS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgS.Location = new System.Drawing.Point(628, 255);
            this.dtNgS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgS.Name = "dtNgS";
            this.dtNgS.Size = new System.Drawing.Size(204, 22);
            this.dtNgS.TabIndex = 45;
            this.dtNgS.ValueChanged += new System.EventHandler(this.dtNgS_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(379, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 31);
            this.label7.TabIndex = 46;
            this.label7.Text = "Lọc nhân viên";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(138, 382);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 21);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Tìm theo địa chỉ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(229, 416);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 419);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Địa chỉ";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(131, 295);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 21);
            this.checkBox2.TabIndex = 49;
            this.checkBox2.Text = "Tìm theo email";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(229, 326);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(537, 315);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(129, 21);
            this.checkBox3.TabIndex = 55;
            this.checkBox3.Text = "Tìm theo CMND";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(628, 349);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 22);
            this.textBox3.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "CMND";
            // 
            // TimNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 560);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNgS);
            this.Controls.Add(this.cbbGt);
            this.Controls.Add(this.btnApDung);
            this.Controls.Add(this.cbgt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbsdt);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbngaysinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbten);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimNhanVien";
            this.Text = "TimNhanVien";
            this.Load += new System.EventHandler(this.TimNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbgt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbsdt;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbngaysinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbten;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApDung;
        private System.Windows.Forms.ComboBox cbbGt;
        private System.Windows.Forms.DateTimePicker dtNgS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
    }
}