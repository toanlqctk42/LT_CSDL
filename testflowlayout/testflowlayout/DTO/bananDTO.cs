using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testflowlayout.DTO
{
    public class bananDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int Capacity { get; set; }
        public bananDTO()
        {

        }
        public bananDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = (int)row["status"];
            this.Capacity = (int)row["capacity"];
        }
        public bananDTO(int iD, string name, int status, int capacity)
        {
            ID = iD;
            Name = name;
            Status = status;
            Capacity = capacity;
        }
    }
}
