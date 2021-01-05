using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testflowlayout.DTO;

namespace testflowlayout.DAO
{
    public class bananDAO
    {

        dataprovider provider = new dataprovider();
        public List<bananDTO> loadbanan()
        {
            string query = "Select * from [Table]";
            List<bananDTO> tablelist = new List<bananDTO>();
            DataTable data = provider.executequery(query);
            foreach (DataRow row in data.Rows)
            {
                bananDTO table = new bananDTO(row);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public bool Thembanan(string name, int status , int capacity)
        {
            string query = string.Format("Insert into [Table] (name , status , capacity )" +
                " values (N'{0}' ,{1} , {2}) ", name, status, capacity).ToString();
            int sodong = provider.executenonquery(query);
            if (sodong > 0) return true;
            return false;
        }
        public bool Capnhatbanan(int Id, string name, int status, int capacity)
        {
            string query = string.Format("update [table]"
                +"set name = N'{0}' " +
                "status = {1} " +
                "capacity = {2} " +
                "where id = {3} ", name, status, capacity,Id).ToString();
            int sodong = provider.executenonquery(query);
            if (sodong > 0) return true;
            return false;
        }
    }
}
