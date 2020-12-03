using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace RestaurantManagementProject
{

    public partial class formfood : Form
    {
        List<Category> listCategory = new List<Category>();
        List<Food> listFood = new List<Food>();
        Food foodCurrent = new Food();
        public formfood()
        {
            InitializeComponent();
        }

        private void cmdexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "0";
            txtUnit.Text = "";
            txtNotes.Text = "";
            if (cbCategory.Items.Count > 0)
                cbCategory.SelectedIndex = 0;
        }

        private void formfood_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodDataToListView();
        }

        private void LoadFoodDataToListView()
        {
            FoodBL foodBL = new FoodBL();
            listFood = foodBL.GetAll();
            int count = 1;
            lvfood.Items.Clear();
            foreach (var food in listFood)
            {
                ListViewItem item = lvfood.Items.Add(count.ToString());
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());
                string foodname = listCategory.Find(x => x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(foodname);
                item.SubItems.Add(food.Notes);
                count++;
            }

        }

        private void LoadCategory()
        {
            CategoryBL categoryBL = new CategoryBL();
            listCategory = categoryBL.GetALL();

            cbCategory.DataSource = listCategory;
            cbCategory.ValueMember = "ID";
            cbCategory.DisplayMember = "Name";
        }

        private void lvfood_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvfood.Items.Count; i++)
            {
                if (lvfood.Items[i].Selected)
                {
                    foodCurrent = listFood[i];
                    txtName.Text = foodCurrent.Name;
                    txtUnit.Text = foodCurrent.Unit;
                    txtPrice.Text = foodCurrent.Price.ToString();
                    txtNotes.Text = foodCurrent.Notes;
                    cbCategory.SelectedIndex = listCategory.FindIndex(x => x.ID == foodCurrent.FoodCategoryID);
                }
            }
        }

        public int InsertFood()
        {
            Food food = new Food();
            food.ID = 0;
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa cập nhật dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {

                    price = 0;
                }
                food.Price = price;
                food.FoodCategoryID = int.Parse(cbCategory.SelectedValue.ToString());
                FoodBL foodBL = new FoodBL();
                return foodBL.Insert(food);
            }
            return -1;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            int result = InsertFood();
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công ");
                LoadFoodDataToListView();
            }
            else MessageBox.Show("Thêm dữ liệu không thành công . Vui lòng kiểm tra lại dữ liệu nhập");
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa mẫu tin này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                FoodBL foodBL = new FoodBL();
                if (foodBL.Delete(foodCurrent) > 0)
                {
                    MessageBox.Show("Xóa thực phẩm thành công ");
                    LoadFoodDataToListView();
                }
                else MessageBox.Show("Xóa không thành công ");
            }
        }
        public int UpdateFood()
        {
            Food food = foodCurrent;
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch 
                {

                    price = 0;
                }
                food.Price = price;
                food.FoodCategoryID = int.Parse(cbCategory.SelectedValue.ToString());
                FoodBL foodBL = new FoodBL();
                return foodBL.Update(food);
            }
            return -1;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateFood();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadFoodDataToListView();
            }
            else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }
    }
}
