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
using WindowsFormsApp1.Model;

namespace Qly_luong.NhanVien
{
    public partial class ThongTincanhan : Form
    {

        User nhanVien;
        public ThongTincanhan(User nhanVien)
        {
            this.nhanVien = nhanVien;
            InitializeComponent();
        }
        
        private void LoadNV ()
        {
            txtmaNV.Text = nhanVien.id.ToString();
            txtHoten.Text = nhanVien.fullName.ToString();
            cbbGt.Text = nhanVien.gender == 1 ? "Nữ" : "Nam";
            dtNgS.Value =  nhanVien.dateOfBirth;
            txtSDT.Text = nhanVien.phoneNumber.ToString();
            txtmaNV.Enabled = false;
            txtHoten.Enabled = false;
            cbbGt.Enabled = false;
            dtNgS.Enabled = false;
            txtSDT.Enabled = false;
        }
        private void ThongTincanhan_Load(object sender, EventArgs e)
        {
            LoadNV();
        }
    }
}
