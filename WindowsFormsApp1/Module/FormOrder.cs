using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Module
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            FormAddOrderDetails formAddOrderDetails = new FormAddOrderDetails();
            formAddOrderDetails.Show();
        }
    }
}
