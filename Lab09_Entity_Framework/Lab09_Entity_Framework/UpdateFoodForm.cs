using Lab09_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Entity_Framework
{
    public partial class UpdateFoodForm : Form
    {
        public UpdateFoodForm(int? foodID = null)
        {
            InitializeComponent();
            _dbContext = new RestaurantContext();
            _foodID = foodID ?? 0;
        }
        private RestaurantContext _dbContext;
        private int _foodID;
        private void LoadCategoriesToCombobox()
        {
            var categories = _dbContext.categories
                .OrderBy(x => x.Name).ToList();
            cbbFoodCategory.DisplayMember = "Name";
            cbbFoodCategory.ValueMember = "ID";
            cbbFoodCategory.DataSource = categories;
        }

        private void UpdateFoodForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToCombobox();

            ShowFoodInformation();
        }
        private Food GetFoodByID(int foodID)
        {
            return foodID > 0 ? _dbContext.foods.Find(foodID) : null;
        }
        private void ShowFoodInformation()
        {
            var food = GetFoodByID(_foodID);
            if (food == null) return;
            txtFoodID.Text = food.ID.ToString();
            txtFoodName.Text = food.Name;
            cbbFoodCategory.SelectedValue = food.FoodCategoryID;
            txtFoodUnit.Text = food.Unit;
            nudFoodPrice.Value = food.Price;
            txtFoodNotes.Text = food.Notes;
        }

        private bool ValidateUserInput()
        {
            if(string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Tên món ăn, đồ uống không được để trống ", "Thông báo");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtFoodUnit.Text))
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thông báo");
                return false;
            }
            if (nudFoodPrice.Value.Equals(0))
            {
                MessageBox.Show("Giá thức ăn phải lớn hơn 0", "Thông báo");
                return false;
            }
            if (cbbFoodCategory.SelectedIndex<0)
            {
                MessageBox.Show("Bạn chưa chọn nhóm thức ăn", "Thông báo");
                return false;
            }
            return true;
        }

        private Food GetUpdateFood()
        {
            var food = new Food()
            {
                Name = txtFoodName.Text.Trim(),
                FoodCategoryID = (int)cbbFoodCategory.SelectedValue,
                Unit = txtFoodUnit.Text,
                Price = (int)nudFoodPrice.Value,
                Notes = txtFoodNotes.Text
            };
            if(_foodID > 0)
            {
                food.ID = _foodID;
            }
            return food;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateUserInput())
            {
                var newFood = GetUpdateFood();
                var oldFood = GetFoodByID(_foodID);
                if(oldFood == null)
                {
                    _dbContext.foods.Add(newFood);
                }
                else
                {
                    oldFood.Name = newFood.Name;
                    oldFood.FoodCategoryID = newFood.FoodCategoryID;
                    oldFood.Unit = newFood.Unit;
                    oldFood.Price = newFood.Price;
                    oldFood.Notes = newFood.Notes;
                }
                _dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
