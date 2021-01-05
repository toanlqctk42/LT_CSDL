﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthicuoiky.DTO
{
    public class TableDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int Capacity { get; set; }
        public TableDTO()
        {

        }
        public TableDTO(int iD, string name, int status, int capacity)
        {
            ID = iD;
            Name = name;
            Status = status;
            Capacity = capacity;
        }
    }
}
