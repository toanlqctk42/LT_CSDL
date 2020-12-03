using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmsinhvien
{
    public class sinhvien
    {
        public string mssv { get; set; }
        public string hotenlot { get; set; }
        public string ten { get; set; }
        public DateTime ngaysinh { get; set; }
        public string lop { get; set; }
        public bool gioitinh { get; set; }
        public string cmnd { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public List<string> monhoc { get; set; }
        public sinhvien()
        {
            monhoc = new List<string>();
        }
        public sinhvien(string MSSV,string Hotenlot,string Ten, DateTime Ngaysinh,string Lop,bool gt, string Cmnd  ,string Sdt , string Diachi,List<string>Monhoc)
        {
            mssv = MSSV;
            hotenlot = Hotenlot;
            ten = Ten;
            ngaysinh = Ngaysinh;
            lop = Lop;
            gioitinh = gt;
            cmnd = Cmnd;
            sdt = Sdt;
            diachi = Diachi;
            monhoc = Monhoc;
        }
        
    }
    
}
