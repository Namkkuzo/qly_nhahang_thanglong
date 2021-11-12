using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Module;

namespace WindowsFormsApp1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {



            LoginService loginService = new LoginService();

            string tk = txtTaiKhoan.Text, mk = txtMatKhau.Text;
            if (tk == "" || mk == "")
            {
                MessageBox.Show("Vui lòng điền thông tin");
            }
            else
            {
                SortedDictionary<String, dynamic> result = loginService.Login(Convert.ToInt32(tk), mk);
                User user = result["user"];
                if (user.id != 0)
                {
                    Main quanLy = new Main(result["user"]);
                    this.Hide();
                    quanLy.Show();
                }
                else
                {
                    errorProvider1.SetError(txtTaiKhoan, result["message"]);
                    
                }
            }

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            MessageBox.Show( PasswordHash.MD5Hash("12345678"));
        }
    }
}
