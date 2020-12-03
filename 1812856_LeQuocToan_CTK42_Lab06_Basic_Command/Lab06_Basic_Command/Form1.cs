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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            String connectionString = "server=DESKTOP-HD7SNA3; database =RestaurantManagenment;Integrated Security=True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.DisplayCategory(sqlDataReader);
            sqlConnection.Close();
        }

        private void DisplayCategory(SqlDataReader reader)
        {
            lvCategory.Items.Clear();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                lvCategory.Items.Add(item);
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-HD7SNA3; database =RestaurantManagenment;Integrated Security=True ";


            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "INSERT INTO Category (Name,[Type])" + " VALUES(N'" + txtName.Text + "'," + txtType.Text + ")";
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm món ăn thành công ");
                btnclick.PerformClick();
                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xãy ra , vui lòng thử lại");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[1].Text=="0"?"Thức uống" : "Đồ ăn";
            btnCapnhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-HD7SNA3; database =RestaurantManagenment;Integrated Security=True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            var command = string.Format("UPDATE Category SET Name = N'{0}', [Type] = {1} WHERE ID = {2}",
                txtName.Text,
                txtType.Text == "Đồ ăn" ? "1" : "0",
                txtID.Text).ToString();

            sqlCommand.CommandText = command;
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowsEffected!=1)
            {
                MessageBox.Show("Đã có lỗi xảy ra .Vui lòng thử lại");
            }
            ListViewItem item = lvCategory.SelectedItems[0];
            item.SubItems[1].Text = txtName.Text;
            item.SubItems[2].Text = txtType.Text;

            txtID.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            btnCapnhat.Enabled = false;
            btnXoa.Enabled = false;
            MessageBox.Show("Cập nhật nhóm món ăn thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-HD7SNA3; database =RestaurantManagenment;Integrated Security=True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "DELETE FROM Category" + " WHERE ID = "+txtID.Text;
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if( numOfRowsEffected != 1)
            {
                MessageBox.Show("Đã có lỗi xảy ra , Vui lòng thử lại");

            }

            ListViewItem item = lvCategory.SelectedItems[0];
            lvCategory.Items.Remove(item);

            txtID.Text = "";
            txtName.Text = "";
            txtType.Text = "";

            btnCapnhat.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if(lvCategory.SelectedItems.Count > 0)
            {
                btnXoa.PerformClick();
            }
        }

        private void tsmViewfood_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                frmFood frm = new frmFood();
                frm.Show(this);
                frm.loadfood(Convert.ToInt32(txtID.Text));
            }
        }
    }
}
