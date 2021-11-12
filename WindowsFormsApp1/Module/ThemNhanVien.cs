using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1.Module
{
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void txtQuanly_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.fullName = txtHoten.Text;
            user.email = txtEmail.Text;
            user.address = txtAddress.Text;
            user.dateOfBirth = dtNgS.Value;
            user.gender =  cbbGt.Text == "Nam" ? 0 : 1;
            user.passportNumber = txtCMND.Text;
            user.phoneNumber = txtSDT.Text;
            user.password = txtpass.Text;
           
            bool result = UserService.addUser(user);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThemQuyen_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtNgS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbGt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_Click(object sender, EventArgs e)
        {

        }

        private void ngs_Click(object sender, EventArgs e)
        {

        }

        private void gt_Click(object sender, EventArgs e)
        {

        }

        private void ht_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
