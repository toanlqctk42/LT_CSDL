using onthicuoiky.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthicuoiky.DAO
{
    public class CTHDDAO
    {
        Dataprovider data = new Dataprovider();
        public List<ChitiethoadonDTO> dshoadontheoban(int tableid)
        {
            string query = string.Format("select [Table].ID, Food.name , Food.Unit , Billdetails.quantity , food.price ," +
                " (food.price * Billdetails.quantity) as Total " +
                "from [Table] " +
                "Join Bills ON [Table].ID = Bills.TableID " +
                "Join Billdetails ON Bills.ID = Billdetails.InvoiceID " +
                "Join Food ON Food.ID =  Billdetails.FoodID " +
                "Where [Table].Id = {0}", tableid).ToString();
            DataTable table = data.executequery(query);
            List<ChitiethoadonDTO> ds = new List<ChitiethoadonDTO>();
            foreach (DataRow row in table.Rows)
            {
                int ID = Convert.ToInt32(row["ID"]);
                string name = row["name"].ToString();
                string unit = row["unit"].ToString();
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal price = Convert.ToDecimal(row["price"]);
                decimal Total = Convert.ToDecimal(row["Total"]);
                var cthoadonmoi = new ChitiethoadonDTO(ID, name, unit, quantity, price, Total);
                ds.Add(cthoadonmoi);
            }
            return ds;
        }
    }
}
