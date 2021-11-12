using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1.Module
{
    public partial class BillView : Form
    {

        private BillService service = new BillService();

        public BillView()
        {
            InitializeComponent();
        }

        private void BillView_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            dgvBill.DataSource = service.getListBill();
        }

        private void loadDataDetailbill(string idBill)
        {
            dgvCTHD.DataSource = service.getListBillDetail(idBill);
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var idBill = dgvBill.CurrentRow.Cells["Id"].Value.ToString();
                loadDataDetailbill(idBill);
            }
            catch { }
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvBill_CellClick(sender, e);
            } catch { }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            dgvBill.DataSource = service.getListBillDetailByDate(dtpFrom.Value.ToString(), dtpTo.Value.ToString());
            dgvCTHD.DataSource = new DataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập từ khóa");
                txtSearch.Focus();
            }
            else
            {
                dgvBill.DataSource = service.getListBillDetailByUserName(txtSearch.Text);
            }
            dgvCTHD.DataSource = new DataTable();
        }
    }
}
