using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap1_60
{
    public partial class frmNhanVien : Form
    {
        DataNV[] dt = new DataNV[100];
        int t = 0;
        int c = 0;
        string str="";
        public void gridadd()
        {
            dataDS.Rows.Add(dt[t].MaNV, dt[t].HoTen, dt[t].NgaySinh, dt[t].Phai, 
                dt[t].DiaChi, dt[t].Email, dt[t].Sdt, dt[t].PhongBan, dt[t].HinhURL);
        }

        public void gridedit(int i)
        {
            dataDS.CurrentRow.Cells[0].Value = dt[i].MaNV;
            dataDS.CurrentRow.Cells[1].Value = dt[i].HoTen;
            dataDS.CurrentRow.Cells[2].Value = dt[i].NgaySinh;
            dataDS.CurrentRow.Cells[3].Value = dt[i].Phai;
            dataDS.CurrentRow.Cells[4].Value = dt[i].DiaChi;
            dataDS.CurrentRow.Cells[5].Value = dt[i].Email;
            dataDS.CurrentRow.Cells[6].Value = dt[i].Sdt;
            dataDS.CurrentRow.Cells[7].Value = dt[i].PhongBan;
            dataDS.CurrentRow.Cells[8].Value = dt[i].HinhURL;
        }

        public void gridview(int i)
        {
            if(dt[i] != null)
            {
                mtxtmanv.Text = dt[i].MaNV;
                txtHoTen.Text = dt[i].HoTen;
                if (dt[i].Phai == "Nam")
                {
                    rbNam.Checked = true;
                }
                else rbNam.Checked = false;
                if (dt[i].Phai == "Nữ")
                {
                    rbNu.Checked = true;
                }
                else rbNu.Checked = false;
                dtpNgaysinh.Value = dt[i].NgaySinh;
                mtxtsdt.Text = dt[i].Sdt;
                txtDiaChi.Text = dt[i].DiaChi;
                txtmail.Text = dt[i].Email;
                cbPhong.Text = dt[i].PhongBan;
                txtHinh.Text = dt[i].HinhURL;
                pictureBox1.ImageLocation = dt[i].HinhURL;
            }
        }
        public void griddelete(int i)
        {
            dataDS.Rows.RemoveAt(i);
            dt[i] = null; 
        }
        public frmNhanVien()
        {
            InitializeComponent();
        }
        
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            string[] data = { "CNTT" , "NNA" , "SP" , "LH" , "DL", "QT" , "QTKD" , "KT" , "CTXH" , "CNSH " };
            this.cbPhong.DataSource = data;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if(mtxtmanv.Text ==""||txtHoTen.Text =="" )
            {
                MessageBox.Show("Bạn không thể để trống mã nhân viên và tên","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string MaNV; string Phai = ""; string HoTen; DateTime NgaySinh; String Sdt; string DiaChi; string PhongBan; string Email; string HinhURL;

                MaNV = mtxtmanv.Text;
                if (rbNam.Checked) Phai = "Nam"; if (rbNu.Checked) Phai = "Nu";
                HoTen = txtHoTen.Text;
                NgaySinh = dtpNgaysinh.Value;
                Sdt = mtxtsdt.Text;
                DiaChi = txtDiaChi.Text;
                PhongBan = cbPhong.Text;
                Email = txtmail.Text;
                HinhURL = str;

                dt[t] = new DataNV(MaNV, Phai, HoTen, NgaySinh, Sdt, DiaChi, PhongBan, Email, HinhURL);
                gridadd();
                t++;
            }
        }
        
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            dt[c].MaNV = mtxtmanv.Text;
            if (rbNam.Checked) dt[c].Phai = "Nam"; if (rbNu.Checked) dt[c].Phai = "Nữ";
            dt[c].HoTen = txtHoTen.Text;
            dt[c].NgaySinh = dtpNgaysinh.Value;
            dt[c].Sdt = mtxtsdt.Text;
            dt[c].DiaChi = txtDiaChi.Text;
            dt[c].PhongBan = cbPhong.Text;
            dt[c].Email = txtmail.Text;
            dt[c].HinhURL = str;

            gridedit(c);
        }

        public class DataNV
        {
            public string MaNV { get; set; }
            public string Phai { get; set; }
            public string HoTen { get; set; }
            public DateTime NgaySinh { get; set; }
            public string Sdt { get; set; }
            public string DiaChi { get; set; }
            public string PhongBan { get; set; }
            public string Email { get; set; }
            public string HinhURL { get; set; }

            public DataNV(string MaNV, string Phai, string HoTen, DateTime NgaySinh, String Sdt, string DiaChi, string PhongBan, string Email, string HinhURL)
            {
                this.MaNV = MaNV;
                this.Phai = Phai;
                this.HoTen = HoTen;
                this.NgaySinh = NgaySinh;
                this.Sdt = Sdt;
                this.DiaChi = DiaChi;
                this.PhongBan = PhongBan;
                this.Email = Email;
                this.HinhURL = HinhURL;
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Url = new OpenFileDialog();
            Url.Title = "Chọn ảnh";
            Url.Filter = "hình ảnh (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (Url.ShowDialog() == DialogResult.OK)
            {
                str = Url.FileName;
                txtHinh.Text = str;
                pictureBox1.ImageLocation = str;
            }
        }

        private void dataDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c = dataDS.CurrentCell.RowIndex;
            gridview(c);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            griddelete(t);
        }

        private void btndefault_Click(object sender, EventArgs e)
        {
            reset();
        }
        public void reset()
        {
            dataDS.Rows.Clear();
            dt = null;

            txtHoTen.Text = "";
            mtxtmanv.Text = "";
            rbNu.Checked = false;
            rbNam.Checked = false;
            dtpNgaysinh.Value = DateTime.Now;
            mtxtsdt.Text = "";
            txtDiaChi.Text = "";
            cbPhong.SelectedIndex = 0;
            txtmail.Text = "";
            txtHinh.Text = "";
            pictureBox1.ImageLocation = "";
        }
    }
}
