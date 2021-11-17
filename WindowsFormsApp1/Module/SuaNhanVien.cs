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
    public partial class SuaNhanVien : Form
    {
        User user;
        public SuaNhanVien(User user )
        {
            this.user = user;
            InitializeComponent();
            
        }
        void initView()
        {
            txtAddress.Text = user.address;
            txtCMND.Text = user.passportNumber;
            txtEmail.Text = user.email;
            txtHoten.Text = user.fullName;
            txtSDT.Text = user.phoneNumber;
            cbbGt.Text = user.gender == 1 ? "Nữ" : "Nam";
            dtNgS.Value = user.dateOfBirth;
            DataTable table = RoleService.getAllRole();
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "sName";
            comboBox1.ValueMember = "Id";

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = this.user.id;
            user.fullName = txtHoten.Text;
            user.email = txtEmail.Text;
            user.address = txtAddress.Text;
            user.dateOfBirth = dtNgS.Value;
            user.gender = cbbGt.Text == "Nam" ? 0 : 1;
            user.passportNumber = txtCMND.Text;
            user.phoneNumber = txtSDT.Text;

            bool result = UserService.editUser(user);
            bool resultRole = UserService.editRole(user.id, Convert.ToInt32(comboBox1.ValueMember));
            if (result && resultRole)
            {
                MessageBox.Show("Thay đổi thành công");
            }
            else
            {
                MessageBox.Show("Thay đổi thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            initView();
        }
    }
}
