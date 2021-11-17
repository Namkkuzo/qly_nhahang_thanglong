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
using static WindowsFormsApp1.Helper.Constain;

namespace WindowsFormsApp1.Module
{
    public partial class Main : Form
    {
        User user { get; set; }

        public Main(User user)
        {
            this.user = user;
            InitializeComponent();
            checkQuyen();
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DangNhap().Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hosocanhan hosocanhan = new Hosocanhan(user);
            hosocanhan.MdiParent  = this;
            hosocanhan.Show();
        }

        private void danhSáchMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Foodview hosocanhan = new Foodview();
            hosocanhan.MdiParent = this;
            hosocanhan.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        void checkQuyen ()
        {
            if (!user.listRole.Contains (Role.HR))
            {
                nhanvienitem.Visible = false;
            }
            if (!user.listRole.Contains(Role.NHA_BEP))
            {
                nhabemitem.Visible = false;
            }
            if (!user.listRole.Contains(Role.THU_NGAN))
            {
                orderitem.Visible = false;
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
           
        }
    }
}
