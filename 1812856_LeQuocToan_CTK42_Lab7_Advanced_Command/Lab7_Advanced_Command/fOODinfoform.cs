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
    public partial class fOODinfoform : Form
    {
        string server = "Data Source=DESKTOP-HD7SNA3;Initial Catalog=RestaurantManagenment;Integrated Security=True";
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public fOODinfoform()
        {
            InitializeComponent();
        }

        private void fOODinfoform_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }
        public void InitValues()
        {
            sqlConnection = new SqlConnection(server);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select ID, Name from Category";

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sqlConnection.Open();
            adapter.Fill(ds,"Category");

            cboCategoryname.DataSource = ds.Tables["Category"];
            cboCategoryname.DisplayMember = "Name";
            cboCategoryname.ValueMember = "ID";

            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        private void Resettext()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cboCategoryname.ResetText();
            nudPrice.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try {
                sqlConnection = new SqlConnection(server);
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "Execute insertfood @id output , @name , @unit , @foodcategoryId , @price , @notes ";

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                sqlCommand.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                sqlCommand.Parameters.Add("@foodcategoryId", SqlDbType.Int);
                sqlCommand.Parameters.Add("@price", SqlDbType.Int);
                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                sqlCommand.Parameters["@id"].Direction = ParameterDirection.Output;
                //truyền giá trị vào thủ tục qua tham số
                sqlCommand.Parameters["@name"].Value = txtName.Text;
                sqlCommand.Parameters["@unit"].Value = txtUnit.Text;
                sqlCommand.Parameters["@foodcategoryId"].Value = cboCategoryname.SelectedValue;
                sqlCommand.Parameters["@price"].Value = nudPrice.Value;
                sqlCommand.Parameters["@notes"].Value = txtNotes.Text;
                sqlConnection.Open();
                int numOfRowsEffec = sqlCommand.ExecuteNonQuery();

                if (numOfRowsEffec > 0)
                {
                    string foodid = sqlCommand.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Successfully adding new foood , Food ID  = " + foodid, "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding food failed");
                }

                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            catch(SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL error");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "error");
            }
        }
        public void DisplayFoodinfo(DataRowView rowView)
        {
            try
            {
               
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nudPrice.Text = rowView["Price"].ToString();
                cboCategoryname.SelectedIndex = -1;

                for (int index = 0; index < cboCategoryname.Items.Count; index++)
                {
                    DataRowView cat = cboCategoryname.Items[index] as DataRowView;
                    if(cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cboCategoryname.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                this.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(server);
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "Execute updatefood @id , @name , @unit , @foodcategoryId , @price , @notes ";

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                sqlCommand.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                sqlCommand.Parameters.Add("@foodcategoryId", SqlDbType.Int);
                sqlCommand.Parameters.Add("@price", SqlDbType.Int);
                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                sqlCommand.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
                //truyền giá trị vào thủ tục qua tham số
                sqlCommand.Parameters["@name"].Value = txtName.Text;
                sqlCommand.Parameters["@unit"].Value = txtUnit.Text;
                sqlCommand.Parameters["@foodcategoryId"].Value = cboCategoryname.SelectedValue;
                sqlCommand.Parameters["@price"].Value = nudPrice.Value;
                sqlCommand.Parameters["@notes"].Value = txtNotes.Text;
                sqlConnection.Open();
                int numOfRowsEffec = sqlCommand.ExecuteNonQuery();

                if (numOfRowsEffec > 0)
                {
                    MessageBox.Show("Successfully updating foood ","Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Updating food failed");
                }

                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "error");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            themcatefory frm = new themcatefory();
            DialogResult result = frm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                InitValues();
            }    
        }
    }
}
