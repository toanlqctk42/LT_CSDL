using onthicuoiky.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthicuoiky.DAO
{
    public class TableDAO
    {
        Dataprovider data = new Dataprovider();
        public List<TableDTO> tablelist()
        {
            string query = "select * from [Table]";
            DataTable table = data.executequery(query);
            List<TableDTO> ds = new List<TableDTO>();
            foreach (DataRow row in table.Rows)
            {
                int ID = Convert.ToInt32(row["ID"]);
                string name = row["Name"].ToString();
                int status = Convert.ToInt32(row["Status"]);
                int capacity = Convert.ToInt32(row["Capacity"]);
                var Bananmoi =new TableDTO(ID, name, status, capacity);
                ds.Add(Bananmoi);
            }
            return ds;
        }
        public bool Thembanan(string name ,int status , int capacity)
        {
            string query = string.Format("insert into [Table] (Name, status, capacity) " +
                "values (N'{0}' , {1} ,{2})",name,status, capacity);
            int sodong = data.executenonquery(query);
            if (sodong > 0) return true;
            return false;
        }
        public bool Capnhatbanan(int id, string name, int status, int capacity)
        {
            string query = string.Format("update [Table]" +
                "Set Name = N'{0}', " +
                "Status = {1}, " +
                "Capacity ={2} " +
                "Where ID = {3} ", name, status, capacity,id);
            int sodong = data.executenonquery(query);
            if (sodong > 0) return true;
            return false;
        }
        public bool xoaban(int id)
        {
            string query = string.Format("delete from [Table] where Id = {0}", id);
            int sodong = data.executenonquery(query);
            if (sodong > 0) return true;
            return false;
        }
    }
}
