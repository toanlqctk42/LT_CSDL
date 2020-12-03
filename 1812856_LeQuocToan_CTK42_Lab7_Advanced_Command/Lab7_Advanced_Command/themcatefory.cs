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
    public partial class themcatefory : Form
    {
        string server = "Data Source=DESKTOP-HD7SNA3;Initial Catalog=RestaurantManagenment;Integrated Security=True";
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public themcatefory()
        {
            InitializeComponent();
        }

        private void themcatefory_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(server);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "insert into category(Name,type) values (N'"+txtname.Text+"' , '"+txttype.Text+"')";
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(num != 1)
            {
                MessageBox.Show("Lỗi thêm dữ liệu ");
            }
            sqlConnection.Dispose();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
