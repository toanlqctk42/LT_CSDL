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

namespace Lab06_Basic_Command
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagenmentDataSet1.Food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.restaurantManagenmentDataSet1.Food);
            // TODO: This line of code loads data into the 'restaurantManagenmentDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.restaurantManagenmentDataSet.Category);

        }
        public void loadfood(int categoryID)
        {
            String connectionString = "server=DESKTOP-HD7SNA3; database =RestaurantManagenment;Integrated Security=True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;
            sqlConnection.Open();
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm :" + catName;
            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Food");
            da.Fill(dt);
            txtFoodCategoryID.Text = categoryID.ToString();
            dgrfood.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

       
        private void btnluu_Click(object sender, EventArgs e)
        {
            String connectionString = "server=DESKTOP-HD7SNA3; database =RestaurantManagenment;Integrated Security=True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlConnection.Open();
            loadfood(Convert.ToInt32(txtFoodCategoryID.Text));
            sqlConnection.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            String connectionString = "server=DESKTOP-HD7SNA3; database =RestaurantManagenment;Integrated Security=True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            var text = string.Format($"INSERT INTO Food (Name , Unit , FoodCategoryID , Price , Notes) VALUES (N'{txtName.Text}', N'{cboUnit.Text}', '{txtFoodCategoryID.Text}', '{txtPrice.Text}', '{txtNotes.Text}')").ToString();
            sqlCommand.CommandText = text;

            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("Đã có lỗi xảy ra , vui lòng thử lại");
            }

            btnluu.PerformClick();
            txtID.Text = "";
            txtName.Text = "";
            cboUnit.Text = "đĩa";
            txtPrice.Text = "";
            txtNotes.Text = "";
        }

        private void dgrfood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgrfood.CurrentRow.Index;
            txtID.Text = dgrfood.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgrfood.Rows[i].Cells[1].Value.ToString();
            cboUnit.Text = dgrfood.Rows[i].Cells[2].Value.ToString();
            txtFoodCategoryID.Text = dgrfood.Rows[i].Cells[3].Value.ToString(); 
            txtPrice.Text = dgrfood.Rows[i].Cells[4].Value.ToString();
            txtNotes.Text = dgrfood.Rows[i].Cells[5].Value.ToString();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            String connectionString = "server=DESKTOP-HD7SNA3; database =RestaurantManagenment;Integrated Security=True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            var text = string.Format($" UPDATE Food SET Name = N'{txtName.Text}',Unit = N'{cboUnit.Text}',FoodCategoryID = '{txtFoodCategoryID.Text}',Price = '{txtPrice.Text}',Notes = N'{txtNotes.Text}' WHERE ID = '{txtID.Text}'").ToString();
            sqlCommand.CommandText = text;

            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("Đã có lỗi xảy ra , vui lòng thử lại");
            }

            btnluu.PerformClick();
            txtID.Text = "";
            txtName.Text = "";
            cboUnit.Text = "đĩa";
            txtPrice.Text = "";
            txtNotes.Text = "";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            String connectionString = "server=DESKTOP-HD7SNA3; database =RestaurantManagenment;Integrated Security=True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            var text = string.Format($" DELETE FROM Food WHERE ID = '{txtID.Text}'").ToString();
            sqlCommand.CommandText = text;

            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("Đã có lỗi xảy ra , vui lòng thử lại");
            }

            btnluu.PerformClick();
            txtID.Text = "";
            txtName.Text = "";
            cboUnit.Text = "đĩa";
            txtPrice.Text = "";
            txtNotes.Text = "";
        }


    }
}
