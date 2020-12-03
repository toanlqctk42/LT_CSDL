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
    public partial class Billdetail : Form
    {
        
        public Billdetail()
        {
            InitializeComponent();
        }

        private void Billdetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagenmentDataSet3.BillDetails' table. You can move, or remove it, as needed.
            this.billDetailsTableAdapter.Fill(this.restaurantManagenmentDataSet3.BillDetails);

        }
        public void loadform(int invoiceid)
        {
            SqlConnection sql = new SqlConnection("Data Source=DESKTOP-HD7SNA3;Initial Catalog=RestaurantManagenment;Integrated Security=True");
            SqlCommand sqlCommand = sql.CreateCommand();
            sqlCommand.CommandText = "select * from BillDetails where Invoiceid = "+invoiceid;
            SqlDataAdapter adapter;
            sql.Open();
            adapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable("BillDetails");
            adapter.Fill(data);
            dgrbiildetail.DataSource = data;
            sql.Close();
            sql.Dispose();
            adapter.Dispose();
        }

    }
}
