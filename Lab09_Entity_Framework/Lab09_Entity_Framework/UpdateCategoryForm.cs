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
    public partial class UpdateCategoryForm : Form
    {
        public UpdateCategoryForm(int? categoryID= null)
        {
            InitializeComponent();
            _dbContext = new RestaurantContext();
            _categoryID = categoryID ?? 0;
        }

        private RestaurantContext _dbContext;
        private int _categoryID;
        private Category GetCategoryByID(int CategoryID)
        {
            //Nếu ID được truyền vào là hợp lệ , ta tìm thông tin theo ID
            //Ngược lại , chỉ đơn giản trả về null, cho biết không thấy.
            return CategoryID > 0 ? _dbContext.categories.Find(CategoryID) : null;
        }
        private void ShowCategory()
        {
            var category = GetCategoryByID(_categoryID);
            if (category == null) return;
            txtCategoryID.Text = category.ID.ToString();
            txtCategoryName.Text = category.Name;
            cbbCategoryType.SelectedIndex = (int)category.Type;
        }

        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            ShowCategory();
        }
        private Category GetUpdateCategory()
        {
            var category = new Category()
            {
                Name = txtCategoryName.Text.Trim(),
                Type = (CategoryType)cbbCategoryType.SelectedIndex
            };
            if(_categoryID > 0)
            {
                category.ID = _categoryID;
            }
            return category;
        }
        private bool ValidateUserInput()
        {
            if(string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Tên nhóm thức ăn không được để trống", "Thông báo");
                return false;
            }

            if(cbbCategoryType.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn loại nhóm thức ăn", "Thông báo");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateUserInput())
            {
                var newCategory = GetUpdateCategory();
                var oldCategory = GetCategoryByID(_categoryID);

                if(oldCategory == null)
                {
                    _dbContext.categories.Add(newCategory);
                }
                else
                {
                    oldCategory.Name = newCategory.Name;
                    oldCategory.Type = newCategory.Type;
                }
                _dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
