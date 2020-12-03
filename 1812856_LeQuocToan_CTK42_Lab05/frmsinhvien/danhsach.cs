using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace frmsinhvien
{
    public delegate int sosanh(object s1, object s2);
    public class danhsach
    {
        public List<sinhvien> ds ;
        public danhsach()
        {
            ds = new List<sinhvien>();
        }
        public void them(sinhvien sv)
        {
            ds.Add(sv);
        }
        public sinhvien this[int index]
        {
            get { return ds[index]; }
            set { ds[index] = value; }
        }
        public void xoa(object obj , sosanh ss)
        {
            for (int i = ds.Count-1; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                    this.ds.RemoveAt(i);
            }
        }
        public sinhvien tim(object obj,sosanh ss)
        {
            sinhvien svresult = null;
            foreach (sinhvien sinhvien in ds)
            {
                if(ss(obj,sinhvien)==0)
                {
                    svresult = sinhvien;
                    break;
                }
            }
            return svresult;
        }
        public bool sua(sinhvien sv, object obj , sosanh ss)
        {
            bool kq = false;
            for (int i = 0; i < ds.Count-1; i++)
            {
                if(ss(obj,this[i])==0)
                {
                    this[i] = sv;
                    kq = true;
                    break;
                }
            }
            return kq;
        }
        public void docfile()
        {
            string file = "danhsach.txt",t;
            string[] s;
            sinhvien sv;
            StreamReader sr = new StreamReader(new FileStream(file, FileMode.Open));
            while((t = sr.ReadLine())!= null )
            {
                s = t.Split('\t');
                sv = new sinhvien();
                sv.mssv = s[0].Trim();
                sv.hotenlot = s[1].Trim();
                sv.ten = s[2].Trim();
                sv.ngaysinh = DateTime.ParseExact(s[3].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                sv.lop = s[4].Trim();
                sv.gioitinh = false;
                if (s[5] == "1")
                    sv.gioitinh = true;
                sv.cmnd = s[6].Trim();
                sv.sdt = s[7].Trim();
                sv.diachi = s[8].Trim();
                string[] mon = s[9].Split(',');
                foreach (string c in mon)
                {
                    sv.monhoc.Add(c);
                }
                them(sv);
            }
            sr.Close();
        }
        public void ghifile()
        {
            string file = "danhsach.txt";
            StreamWriter sw = new StreamWriter(new FileStream(file, FileMode.OpenOrCreate));
            foreach (var sv in ds)
            {
                sw.Write(sv.mssv + '\t');
                sw.Write(sv.hotenlot + '\t');
                sw.Write(sv.ten + '\t');
                sw.Write(sv.ngaysinh.ToString("MM/dd/yyyy") + '\t');
                sw.Write(sv.lop + '\t');
                sw.Write(sv.gioitinh ? "1\t" : "0\t");
                sw.Write(sv.cmnd + '\t');
                sw.Write(sv.sdt + '\t');
                sw.Write(sv.diachi + '\t');
                sw.Write(string.Join(",", sv.monhoc) + '\n');
            }
            sw.Close();
        }
        
    }
    public interface IStudentDataStorage
    {
        string FilePath { get; }
        List<sinhvien> Load();
        void Write(List<sinhvien> sinhViens);
    }
    public class XMLDataStorage : IStudentDataStorage
    {
        public string FilePath { get; }

        public XMLDataStorage(string filePath)
        {
            FilePath = filePath;
        }

        public List<sinhvien> Load()
        {
            throw new NotImplementedException();
        }

        public void Write(List<sinhvien> sinhViens)
        {
            XDeclaration dec = new XDeclaration("1.0", "utf-8", "yes");

        }
    }
    public class QLSinhVien
    {
        private readonly List<sinhvien> dsSinhVien;
        private readonly IStudentDataStorage dataStorage;

        public QLSinhVien(IStudentDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
            dsSinhVien = dataStorage.Load();
        }


        public List<sinhvien> GetAll()
        {
            return dsSinhVien;
        }

        public sinhvien GetByID(string MSSV)
        {
            if (string.IsNullOrWhiteSpace(MSSV))
                throw new ArgumentException($"Tên sinh viên không hợp lệ!");

            sinhvien sv = null;

            sv = dsSinhVien.Find(s => s.mssv == MSSV);

            return sv;
        }

        public List<sinhvien> GetByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException($"Tên sinh viên không hợp lệ!");

            return dsSinhVien.FindAll(sv => sv.ten.ToLower() == name.ToLower());
        }

        public List<sinhvien> GetByClassName(string className)
        {
            if (string.IsNullOrWhiteSpace(className))
                throw new ArgumentException($"Lớp không hợp lệ!");

            return dsSinhVien.FindAll(sv => sv.lop.ToLower() == className.ToLower());
        }

        public void UpdateByID(string MSSV, sinhvien sinhVienMoi)
        {
            if (string.IsNullOrWhiteSpace(MSSV))
                throw new ArgumentException($"Mã số sinh viên không hợp lệ!");

            var isExist = dsSinhVien.Exists(sv => sv.mssv == MSSV);
            if (!isExist)
                throw new ArgumentException($"Sinh viên có mã số {MSSV} không tồn tại!");

            var index = dsSinhVien.FindIndex(sv => sv.mssv == MSSV);
            dsSinhVien[index] = sinhVienMoi;

            dataStorage.Write(dsSinhVien);
        }

        public void DeleteByID(string MSSV)
        {
            if (string.IsNullOrWhiteSpace(MSSV))
                throw new ArgumentException($"Mã số sinh viên không hợp lệ!");

            var sinhVien = dsSinhVien.Find(sv => sv.mssv == MSSV);
            if (sinhVien is null)
                throw new ArgumentException($"Không tồn tại sinh viên có mã số {MSSV}");

            dsSinhVien.Remove(sinhVien);
            dataStorage.Write(dsSinhVien);
        }

        public void Add(sinhvien sinhVien)
        {
            if (sinhVien is null)
                throw new ArgumentException($"Sinh viên không hợp lệ!");

            var isExist = dsSinhVien.Exists(sv => sv.mssv == sinhVien.mssv);
            if (isExist)
                throw new ArgumentException($"Sinh viên có mã số {sinhVien.mssv} đã tồn tại!");

            dsSinhVien.Add(sinhVien);
            dataStorage.Write(dsSinhVien);
        }
    }
    public class JSONDataStorage : IStudentDataStorage
    {
        public string FilePath { get; }

        public JSONDataStorage(string filePath)
        {
            FilePath = filePath;
        }

        public List<sinhvien> Load()
        {
            if (!File.Exists(FilePath))
            {
                FileStream fs = File.Create(FilePath);
                fs.Close();
            }

            using (StreamReader r = new StreamReader(FilePath))
            {
                string json = r.ReadToEnd();
                if (string.IsNullOrWhiteSpace(json))
                    return new List<sinhvien>();

                List<sinhvien> items = JsonConvert.DeserializeObject<List<sinhvien>>(json);
                return items;
            }
        }

        public void Write(List<sinhvien> sinhViens)
        {
            using (StreamWriter file = File.CreateText(FilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, sinhViens);
            }
        }
    }
}
