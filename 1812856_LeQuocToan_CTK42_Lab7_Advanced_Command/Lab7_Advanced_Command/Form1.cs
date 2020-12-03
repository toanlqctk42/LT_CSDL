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

namespace Lab7_Advanced_Command
{
    public partial class Form1 : Form
    {
        string server = "Data Source=DESKTOP-HD7SNA3;Initial Catalog=RestaurantManagenment;Integrated Security=True";
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        private void loadCategory()
        {
            sqlConnection = new SqlConnection(server);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select ID , Name  from Category";
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            dt = new DataTable();
            sqlConnection.Open();
            sqlData.Fill(dt);
            sqlConnection.Close();
            sqlConnection.Dispose();
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "ID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadCategory();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex == -1) return;
            sqlConnection = new SqlConnection(server);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from Food where FoodCategoryID = @categoryId";
            sqlCommand.Parameters.Add("@categoryId", SqlDbType.Int);
            if(cboCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cboCategory.SelectedValue as DataRowView;
                sqlCommand.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                sqlCommand.Parameters["@categoryId"].Value = cboCategory.SelectedValue;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            dt = new DataTable();
            sqlConnection.Open();
            adapter.Fill(dt);
            sqlConnection.Close();
            sqlConnection.Dispose();
            dgrCategory.DataSource = dt;
            lbldem.Text = "Có tất cả  : " + dt.Rows.Count.ToString();
            lblnhommonan.Text = "Món ăn thuộc nhóm : " + cboCategory.Text;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(server);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select @numSaleFood = sum (Quantity) from BillDetails where FoodID = @foodid";
            if (dgrCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dgrCategory.SelectedRows[0];
                DataRowView rowView = selectedrow.DataBoundItem as DataRowView;

                sqlCommand.Parameters.Add("@foodid", SqlDbType.Int);
                sqlCommand.Parameters["@foodid"].Value = rowView["ID"];
                sqlCommand.Parameters.Add("@numSaleFood", SqlDbType.Int);
                sqlCommand.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                string result = sqlCommand.Parameters["@numSaleFood"].Value.ToString();
                if(result == "")
                {
                    result = "0"; 
                }
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là : " + result + " " + rowView["Unit"]);

                sqlConnection.Close();
            
            }
            sqlCommand.Dispose();
            sqlConnection.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            fOODinfoform foodform = new fOODinfoform();
            foodform.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            foodform.Show(this);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cboCategory.SelectedIndex;
            cboCategory.SelectedIndex = -1;
            cboCategory.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if(dgrCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dgrCategory.SelectedRows[0];
                DataRowView rowView = selectedrow.DataBoundItem as DataRowView;

                fOODinfoform foodform = new fOODinfoform();
                foodform.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

                foodform.Show(this);
                foodform.DisplayFoodinfo(rowView);
            }
        }

        private void txtseach_TextChanged(object sender, EventArgs e)
        {
            if (dt == null) return;
            string filteExpression = "Name like '%" + txtseach.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

            DataView foodview = new DataView(dt, filteExpression, sortExpression, rowStateFilter);
            dgrCategory.DataSource = foodview;
        }
    }
}
