using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TimNhanVien : Form
    {
        Hosocanhan formcha;
        public TimNhanVien(Hosocanhan formcha)
        {
            this.formcha = formcha;
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsdt.Checked)
                txtsdt.Enabled = true;
            else txtsdt.Enabled = false;
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                cbten.Checked = false;
                cbngaysinh.Checked = false;
                cbsdt.Checked = false;
                cbgt.Checked = false;
        }

        private void cbdiachi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbten_CheckedChanged(object sender, EventArgs e)
        {
            if (cbten.Checked)
                txtten.Enabled = true;
            else txtten.Enabled = false;
            
        }

        private void TimNhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void cbngaysinh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbngaysinh.Checked)
                
            dtNgS.Enabled = true;
            else dtNgS.Enabled = false;

        }

        private void cbgt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbgt.Checked)
                cbbGt.Enabled = true;
            else cbbGt.Enabled = false;
        }

        private void dtNgS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            string hoten;
            DateTime sinhnhat= DateTime.Now;
            Boolean havesinhnhat = true;
            Boolean havegt = true;
            string sdt;
            Boolean gt=true;
            if (cbten.Checked) hoten = txtten.Text; else hoten = "";
            if (cbngaysinh.Checked) sinhnhat = dtNgS.Value; else havesinhnhat = false;
            if (cbsdt.Checked) sdt = txtsdt.Text; else sdt = "";
            if (cbgt.Checked)
            {
                if (cbbGt.Text == "Nam") gt = false;
                else if (cbbGt.Text == "Nữ") gt = true;
                else havegt = false;
            }
            else havegt = false;
            formcha.Timnhanvien(hoten,sinhnhat,sdt,gt,havegt,havesinhnhat,textBox3.Text, textBox1.Text,textBox2.Text);
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                textBox2.Enabled = true;
            else textBox2.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                textBox3.Enabled = true;
            else textBox3.Enabled = false;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox1.Enabled = true;
            else textBox1.Enabled = false;
        }
    }
}
