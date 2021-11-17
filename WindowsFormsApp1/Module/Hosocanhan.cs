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
using WindowsFormsApp1.Module;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1
{
    public partial class Hosocanhan : Form
    {
        User nhanVien;
        public Hosocanhan(User nhanVien)
        {
            this.nhanVien = nhanVien;
            InitializeComponent();
        }
        public void Timnhanvien(string hoten,DateTime sinhnhat, string sdt, Boolean gioitinh,Boolean havegt, Boolean havesn,string CMND, string diachi, string email)
            {
            DataTable table = new DataTable();
                try
                {
                table = UserService.searchNhanVien(hoten,sinhnhat,sdt,gioitinh,havegt,havesn,CMND,diachi,email);
                    
                }
                
                catch { MessageBox.Show("Đã có lỗi sảy ra !"); }
                dtgNV.DataSource = table;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMK_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadDSNV()
        {
            DataTable table = UserService.getListUser();
            dtgNV.DataSource = table;
            
        }
        private void Hosocanhan_Load(object sender, EventArgs e)
        {
            LoadDSNV();
            init();


        }
        void init ()
        {
            txtmaNV.Enabled = false;
            txtHoten.Enabled = false;
            txtEmail.Enabled = false;
            cbbGt.Enabled = false;
            dtNgS.Enabled = false;
            btnsua.Enabled = false;
            btnXoa.Enabled = false;
            txtAddress.Enabled = false;
            txtCMND.Enabled = false;
            txtSDT.Enabled = false;
        }
        private void dtgNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try
            {
                txtmaNV.Text = dtgNV.Rows[index].Cells["Id"].Value.ToString();
                txtHoten.Text = dtgNV.Rows[index].Cells["sFullName"].Value.ToString();
                cbbGt.Text = dtgNV.Rows[index].Cells["bGender"].Value.ToString();
                txtEmail.Text = dtgNV.Rows[index].Cells["email"].Value.ToString();
                txtAddress.Text = dtgNV.Rows[index].Cells["sAddress"].Value.ToString();
                txtCMND.Text = dtgNV.Rows[index].Cells["sPassportNumber"].Value.ToString();
                dtNgS.Value = Convert.ToDateTime(dtgNV.Rows[index].Cells["dDateOfBirth"].Value);
                txtSDT.Text = dtgNV.Rows[index].Cells["sPhone"].Value.ToString();
                btnsua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch { }
                
           
               
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            
            User nhanVienInView = new User();

            nhanVienInView.id = Convert.ToInt32( txtmaNV.Text);
            nhanVienInView.fullName = txtHoten.Text;
            int gt;
            if (cbbGt.Text == "Nam") gt = 0;
            else gt = 1;
            nhanVienInView.gender = gt;
            nhanVienInView.dateOfBirth = dtNgS.Value;
            nhanVienInView.phoneNumber = txtSDT.Text;
            nhanVienInView.address = txtAddress.Text;
            nhanVienInView.email = txtEmail.Text;
            nhanVienInView.passportNumber = txtCMND.Text;
            SuaNhanVien themNhanVien = new SuaNhanVien(nhanVienInView);
            themNhanVien.ShowDialog();
            if (UserService.editUser(nhanVienInView))
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            } 
            LoadDSNV();
        }
        private void btnThemtextisthemmoi()
        {
            txtmaNV.Enabled = false;
            txtHoten.Enabled = true;
            btnsua.Enabled = false;
            txtSDT.Enabled = true;
            cbbGt.Enabled = true;
            dtNgS.Enabled = true;
        }
        private void btnThemtextisthem()
        {
            if ( txtHoten.Text.Trim() == "" || txtSDT.Text.Trim() == "" )
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
            else
            {
                User nhanVienInView = new User();

             
                nhanVienInView.fullName = txtHoten.Text;
                int gt;
                if (cbbGt.Text == "Nam") gt = 0;
                else gt = 1;
                nhanVienInView.gender = gt;
                nhanVienInView.dateOfBirth = dtNgS.Value;
                nhanVienInView.phoneNumber = txtSDT.Text;
                nhanVienInView.userName = "";

                if (UserService.addUser(nhanVienInView))
                {
                    MessageBox.Show("Đã có lỗi xảy ra");
                }
            }

            LoadDSNV();
            init();
            
        }
            
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            init();
            LoadDSNV();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            TimNhanVien searchForm = new TimNhanVien(this);
            searchForm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            User nhanVienInView = new User();
            
            try
            {
                nhanVienInView.id = Convert.ToInt32(txtmaNV.Text);
                if (UserService.deleteUser(nhanVienInView))
                {
                    LoadDSNV();
                init();
                }
                    
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
            

            
            
        }

        private void ht_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
        }

        private void dtgNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
