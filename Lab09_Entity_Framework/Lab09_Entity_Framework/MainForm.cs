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
using System.Data.SqlClient;

namespace Lab09_Entity_Framework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private List<Category> GetCategories()
        {
            var dbContext = new RestaurantContext();
            return dbContext.categories.OrderBy(x => x.Name).ToList();
        }
        private void ShowCategories()
        {
            tvwCategory.Nodes.Clear();
            var cateMap = new Dictionary<CategoryType, string>()
            { 
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink]= "Thức uống"
            };
            var rootNote = tvwCategory.Nodes.Add("Tất cả");
            var categories = GetCategories();
            foreach (var cateType in cateMap)
            {
                var childNode = rootNote.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;
                foreach (var category in categories)
                {
                    if (category.Type != cateType.Key) continue;
                    var grantChildNode = childNode.Nodes.Add(category.ID.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }
            tvwCategory.ExpandAll();
            tvwCategory.SelectedNode = rootNote;

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }
        private List<FoodModel> GetFoodByCategory(int? categoryID)
        {
            var dbContext = new RestaurantContext();
            var foods = dbContext.foods.AsQueryable();
            if(categoryID != null && categoryID >0)
            {
                foods = foods.Where(x => x.FoodCategoryID == categoryID);
            }
            return foods.OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.category.Name

                }).ToList();

        }

        private List<FoodModel> GetFoodByCategoryType(CategoryType categoryType)
        {
            var dbContext = new RestaurantContext();
            return dbContext.foods.Where(x => x.category.Type == categoryType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.category.Name
                }).ToList();
        }

        private void ShowFoodsForNode(TreeNode node)
        {
            lvwFood.Items.Clear();
            if (node == null) return;
            List<FoodModel> Foods = null;
            if(node.Level == 1 )
            {
                var categoryType = (CategoryType)node.Tag;
                Foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                var category = node.Tag as Category;
                Foods = GetFoodByCategory(category?.ID);
            }
            ShowFoodsOnListView(Foods);
        }

        private void ShowFoodsOnListView(List<FoodModel> Foods)
        {
            foreach (var foodItem in Foods)
            {
                var item = lvwFood.Items.Add(foodItem.ID.ToString());
                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
               
            }
            
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if(dialog.ShowDialog(this)== DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;
            var category = e.Node.Tag as Category;
            var dialog = new UpdateCategoryForm(category?.ID);
            if(dialog.ShowDialog(this)==DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            ShowFoodsForNode(tvwCategory.SelectedNode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) return;
            var dbContext = new RestaurantContext();
            var selectedFoodID = int.Parse(lvwFood.SelectedItems[0].Text);
            var selectedFood = dbContext.foods.Find(selectedFoodID);
            if(selectedFood != null)
            {
                dbContext.foods.Remove(selectedFood);
                dbContext.SaveChanges();
                lvwFood.Items.Remove(lvwFood.SelectedItems[0]);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateFoodForm();
            if(dialog.ShowDialog(this)==DialogResult.OK)
            {
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }

        private void lvwFood_DoubleClick(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) return;
            var foodID = int.Parse(lvwFood.SelectedItems[0].Text);
            var dialog = new UpdateFoodForm(foodID);
            if(dialog.ShowDialog(this)== DialogResult.OK)
            {
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }
    }
}
