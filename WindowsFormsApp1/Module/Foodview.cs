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
    public partial class Foodview : Form
    {
        private FoodService service = new FoodService();

        private static string idFood = string.Empty;

        public Foodview()
        {
            InitializeComponent();
        }

        private void Food_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            dgvFood.DataSource = service.getListFood();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkValidateTextBox())
            {
                if (checkFoodNameExist(txtName.Text))
                {
                    MessageBox.Show("Tên món ăn đã tồn tại");
                    txtName.Focus();
                }
                else
                {
                    Food model = new Food();
                    model.Name = txtName.Text;
                    model.Price = float.Parse(txtPrice.Text);
                    model.Description = txtDescription.Text;
                    if (service.insertFood(model) == 1)
                    {
                        MessageBox.Show("Thêm món ăn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm món ăn không thành công");
                    }
                }
            }
            LoadData();
            idFood = string.Empty;
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
        }

        private Boolean checkFoodNameExist(string name)
        {
            return service.getFoodByName(name) == 1 ? true : false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idFood == string.Empty)
            {
                MessageBox.Show("Bạn vui lòng chọn món ăn trong bảng");
            }
            if (!checkValidateTextBox()) {
                Food model = new Food();
                model.Id = Int32.Parse(idFood);
                model.Name = txtName.Text;
                model.Price = float.Parse(txtPrice.Text);
                model.Description = txtDescription.Text;

                if (checkFoodNameExist(model.Name))
                {
                    var food = service.getByName(model.Name).Rows[0]["Id"].ToString();
                    if (!food.Equals(idFood))
                    {
                        MessageBox.Show("Tên món ăn đã tồn tại");
                        txtName.Focus();
                    }
                    else
                    {
                        if (service.updateFood(model) == 1)
                        {
                            MessageBox.Show("Cập nhật món ăn thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật món ăn không thành công");
                        }
                    }
                }
                else
                {
                    if (service.updateFood(model) == 1)
                    {
                        MessageBox.Show("Cập nhật món ăn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật món ăn không thành công");
                    }
                }
            }
            LoadData();
            idFood = string.Empty;
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (idFood == string.Empty)
            {
                MessageBox.Show("Bạn vui lòng chọn món ăn trong bảng");
            }
            else
            {
                if (service.updateDelete(idFood, "Tạm ngưng") == 1)
                {
                    MessageBox.Show("Cập nhật trạng thái món ăn thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái món ăn không thành công");
                }
            }
            LoadData();
            idFood = string.Empty;
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvFood.CurrentRow.Cells["sName"].Value.ToString();
            txtPrice.Text = dgvFood.CurrentRow.Cells["fPrice"].Value.ToString();
            txtDescription.Text = dgvFood.CurrentRow.Cells["sDescription"].Value.ToString();
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idFood = dgvFood.CurrentRow.Cells["Id"].Value.ToString();
            btnUpdate.Enabled = true;
            btnRemove.Enabled = true;
            dgvFood_CellClick(sender, e);
        }

        private void dgvFood_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvFood_CellDoubleClick(sender, e);
        }

        private void dgvFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (service.updateDelete(idFood, "Đạng hoạt động") == 1)
            {
                MessageBox.Show("Cập nhật trạng thái món ăn thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái món ăn không thành công");
            }
            LoadData();
            idFood = string.Empty;
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            idFood = string.Empty;
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtSearch.Text = string.Empty;
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập từ khóa !");
                txtSearch.Focus();
            }
            else
            {
                dgvFood.DataSource = service.getSearchName(txtSearch.Text);
            }
        }

        private Boolean checkValidateTextBox()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn");
                txtName.Focus();
                return true;   
            }else if (txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mô tả");
                txtPrice.Focus();
                return true;
            }else if (txtDescription.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mô tả");
                txtDescription.Focus();
                return true;
            }

            return false;
        }
    }
}
