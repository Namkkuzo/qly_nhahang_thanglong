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

namespace WindowsFormsApp1.Module
{
    public partial class Main : Form
    {
        User user { get; set; }

        public Main(User user)
        {
            this.user = user;
            InitializeComponent();
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
    }
}
