using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthicuoiky.DAO
{
    public class Dataprovider
    {
        string server = "Data Source=DESKTOP-HD7SNA3;Initial Catalog=RestaurantManagement;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        public DataTable executequery(string query)
        {
            connection = new SqlConnection(server);
            command = connection.CreateCommand();
            command.CommandText = query;
            connection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
            connection.Dispose();
            return table;
        }
        public int executenonquery(string query)
        {
            connection = new SqlConnection(server);
            command = connection.CreateCommand();
            command.CommandText = query;
            connection.Open();
            int sodong = command.ExecuteNonQuery();
            connection.Close();
            connection.Dispose();
            return sodong;
        }
        public object executescalar(string query)
        {
            connection = new SqlConnection(server);
            command = connection.CreateCommand();
            command.CommandText = query;
            connection.Open();
            object kq = command.ExecuteScalar();
            connection.Close();
            connection.Dispose();
            return kq;
        }
    }
}
