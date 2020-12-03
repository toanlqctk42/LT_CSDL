using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Table
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int Capacity { get; set; }

    }
    /*public class TableDA
    {
        public List<Table> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Ultilities.Table_GetAll;
            sqlda
        }
    }*/
}
