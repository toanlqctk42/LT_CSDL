using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthicuoiky.DTO
{
    public class ChitiethoadonDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string unit { get; set; }
        public int quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public ChitiethoadonDTO()
        {

        }

        public ChitiethoadonDTO(int iD, string name, string unit, int quantity, decimal price, decimal total)
        {
            ID = iD;
            Name = name;
            this.unit = unit;
            this.quantity = quantity;
            Price = price;
            Total = total;
        }
    }
}
