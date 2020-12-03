using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace _1812856_LeQuocToan_CTK42_Lab03
{
    public partial class demosv : Form
    {
        quanlysv qlsv;
        public demosv()
        {
            InitializeComponent();
        }

        private void demosv_Load(object sender, EventArgs e)
        {
            qlsv = new quanlysv();
            qlsv.doctufile();
            loadlistview();
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> chuyennganh = new List<string>();
            sv.Maso = this.mtxmasv.Text.Split(',')[1];
            sv.HoTen = this.txthoten.Text;
            sv.NgaySinh = this.dtpngaysinh.Value;
            sv.DiaChi = this.txtdiachi.Text;
            sv.Lop = this.cblop.Text;
            sv.Hinh = this.txthinh.Text;
            if (rbnu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbchuyennganh.Items.Count; i++)
            {
                if (clbchuyennganh.GetItemChecked(i))
                    chuyennganh.Add(clbchuyennganh.Items[i].ToString());
            }
            sv.ChuyenNganh = chuyennganh;
            return sv;
        }

        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.Maso = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.Hinh = lvitem.SubItems[5].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[6].Text == "Nam")
                sv.GioiTinh = true;
            List<string> chuyennganh = new List<string>();
            string[] s = lvitem.SubItems[7].Text.Split(',');
            foreach (string t in s)
            {
                chuyennganh.Add(t);
            }
            sv.ChuyenNganh = chuyennganh;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxmasv.Text = sv.Maso;
            this.txthoten.Text = sv.HoTen;
            this.dtpngaysinh.Value = sv.NgaySinh;
            this.txtdiachi.Text = sv.DiaChi;
            this.cblop.Text = sv.Lop;
            this.txthinh.Text = sv.Hinh;
            this.pictureBox1.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rbnam.Checked = true;
            else
                this.rbnu.Checked = true;

            // Xoa sach dau tick cu
            for (int i = 0; i < this.clbchuyennganh.Items.Count; i++)
            {
                this.clbchuyennganh.SetItemChecked(i, false);
            }

            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbchuyennganh.Items.Count; i++)
                {
                    if (s.Trim().CompareTo(this.clbchuyennganh.Items[i].ToString()) == 0)
                        this.clbchuyennganh.SetItemChecked(i, true);
                }
            }
        }

        private void themsv(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.Maso);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.Hinh);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            //string chuyennganh = "";
            //foreach (string s in sv.ChuyenNganh)
            //{
            //    chuyennganh += s +",";
            //    if (chuyennganh.Length > 1) chuyennganh = chuyennganh.Substring(0, chuyennganh.Length - 1);
            //    lvitem.SubItems.Add(chuyennganh);
            //}

            // ["cn1, "cn2", "cn3"] => "cn1, cn2, cn3"
            lvitem.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
            
            this.lvdssv.Items.Add(lvitem);
            qlsv.GhiFile();
        }
        private void loadlistview()
        {
            this.lvdssv.Items.Clear();
            foreach (SinhVien sv in qlsv.ds)
            {
                themsv(sv);
            }
        }





        public class SinhVien
        {
            public string Maso { get; set; }
            public string HoTen { get; set; }
            public DateTime NgaySinh { get; set; }
            public string DiaChi { get; set; }
            public string Lop { get; set; }
            public string Hinh { get; set; }
            public bool GioiTinh { get; set; }
            public List<string> ChuyenNganh { get; set; }

            public SinhVien()
            {
                ChuyenNganh = new List<string>();
            }
            public SinhVien(string maso, string hoten, DateTime ngaysinh, string diachi, string lop, string hinh, bool gioitinh, List<string> chuyennganh)
            {
                Maso = maso;
                HoTen = hoten;
                NgaySinh = ngaysinh;
                DiaChi = diachi;
                Lop = lop;
                Hinh = hinh;
                GioiTinh = gioitinh;
                ChuyenNganh = chuyennganh;
            }
        }
        public delegate int sosanh(object sv1, object vs2);
        public class quanlysv
        {
            public List<SinhVien> ds;
            public quanlysv()
            {
                ds = new List<SinhVien>();
            }
            public void add(SinhVien sv)
            {
                this.ds.Add(sv);
            }
            public SinhVien this[int index]
            {
                get { return ds[index]; }
                set { ds[index] = value; }
            }
            public void xoa(object obj, sosanh ss)
            {
                int i = ds.Count - 1;
                for (; i >= 0; i--)
                {
                    if (ss(obj, this[i]) == 0)
                    {
                        this.ds.RemoveAt(i);
                    }
                }
            }
            public SinhVien tim(object obj, sosanh ss)
            {
                SinhVien res = null;
                foreach (SinhVien sv in ds)
                {
                    if (ss(obj, sv) == 0)
                    {
                        res = sv;
                        break;
                    }
                }
                return res;
            }
            public bool sua(SinhVien svedit, object obj, sosanh ss)
            {
                int i, count;
                bool kq = false;
                count = this.ds.Count - 1;
                for (i = 0; i < count; i++)
                {
                    if (ss(obj, this[i]) == 0)
                    {
                        this[i] = svedit;
                        kq = true;
                        break;
                    }
                }
                return kq;
            }
            public void GhiFile()
            {
                string filename = "DanhSachSV_Write.txt";

                StreamWriter writer = new StreamWriter(new FileStream(filename, FileMode.OpenOrCreate));
                foreach (var sinhVien in ds)
                {
                    writer.Write(sinhVien.Maso + '\t');
                    writer.Write(sinhVien.HoTen + '\t');
                    writer.Write(sinhVien.NgaySinh.ToString("MM/dd/yyyy") + '\t');
                    writer.Write(sinhVien.DiaChi + '\t');
                    writer.Write(sinhVien.Lop + '\t');
                    writer.Write(sinhVien.Hinh + '\t');
                    writer.Write(sinhVien.GioiTinh ? "1\t" : "0\t");
                    writer.Write(String.Join(",", sinhVien.ChuyenNganh) + '\n');                    
                }
                writer.Close();
            }
            public void doctufile()
            {
                string filename = "DanhSachSV_Write.txt";
                string t;
                string[] s;
                SinhVien sv;
                StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
                while ((t = sr.ReadLine()) != null)
                {
                    s = t.Split('\t');
                    sv = new SinhVien();
                    sv.Maso = s[0].Trim();
                    sv.HoTen = s[1].Trim();
                    

                    sv.NgaySinh = DateTime.ParseExact(s[2].Trim(),"MM/dd/yyyy",null);
                    //sv.NgaySinh = new DateTime(int.Parse(numbers[2]), int.Parse(numbers[0]), int.Parse(numbers[1]));

                    sv.DiaChi = s[3].Trim();
                    sv.Lop = s[4].Trim();
                    sv.Hinh = s[5].Trim();
                    sv.GioiTinh = false;
                    if (s[6] == "1")
                        sv.GioiTinh = true;
                    string[] chuyennganh = s[7].Split(',');
                    foreach (string c in chuyennganh)
                    {
                        sv.ChuyenNganh.Add(c.Trim());
                    }
                    add(sv);
                }
                sr.Close();
            }
        }

        private void lvdssv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvdssv.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvdssv.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }
        private int sosanhtheoma(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.Maso.Trim().CompareTo(obj1.ToString().Trim());
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.tim(sv.Maso, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).Maso.CompareTo(obj1.ToString());
            });
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại !", "Lỗi Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.qlsv.add(sv);
                this.loadlistview();
                qlsv.GhiFile();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvdssv.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvdssv.Items[i];
                if (lvitem.Checked)
                    qlsv.xoa(lvitem.SubItems[0].Text, sosanhtheoma);
            }
            this.loadlistview();
            this.btndefault.PerformClick();
            qlsv.GhiFile();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.sua(sv, sv.Maso, sosanhtheoma);
            if (kqsua)
            {
                this.loadlistview();
                qlsv.GhiFile();
            }
        }

        private void btndefault_Click(object sender, EventArgs e)
        {
            this.mtxmasv.Text = "";
            this.txthoten.Text = "";
            this.dtpngaysinh.Value = DateTime.Now;
            this.txtdiachi.Text = "";
            this.cblop.Text = "";
            this.txthinh.Text = "";
            this.pictureBox1.ImageLocation = "";
            this.rbnam.Checked = true;
            for (int i = 0; i < this.clbchuyennganh.Items.Count - 1; i++)
            {
                this.clbchuyennganh.SetItemChecked(i, false);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog url = new OpenFileDialog();
            url.Title = "Chọn ảnh";
            url.Filter = "Hình ảnh (*.png;*.jpg)|*.png;*jpg|All file(*.*)|*.*";
            if (url.ShowDialog() == DialogResult.OK)
            {
                txthinh.Text = url.FileName;
                pictureBox1.ImageLocation = url.FileName;
            }
        }

        private void closefilemenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openfilemenu_Click(object sender, EventArgs e)
        {
            btnbrowse_Click(sender, e);
        }

        private void ThemStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnadd_Click(sender, e);
        }

        private void XoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btndelete_Click(sender, e);
        }

        private void SuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnedit_Click(sender, e);
        }

        private void FontStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) ;
            lvdssv.Font = fontDialog1.Font;
        }

        private void colorStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                lvdssv.ForeColor = colorDialog1.Color;
        }

        private void sapxepStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
