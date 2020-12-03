using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmsinhvien
{
    public partial class frmsinhvien : Form
    {
        danhsach qlsv;
        public frmsinhvien()
        {
            InitializeComponent();
            
        }
        private void frmsinhvien_Load(object sender, EventArgs e)
        {
            qlsv = new danhsach();
            qlsv.docfile();
            loadlistview();
            toolStripTextBox1.Enabled = false;
            
        }
        public sinhvien GetSinhvien()
        {
            sinhvien sv = new sinhvien();
            bool gt = true;
            List<string> monhoc = new List<string>();
            sv.mssv = this.mtxtmssv.Text;
            sv.hotenlot = this.txthotenlot.Text;
            sv.ten = this.txtten.Text;
            sv.ngaysinh = this.dtpngaysinh.Value;
            sv.lop = this.cblop.Text;
            if (this.rdNu.Checked)
                gt = false;
            sv.gioitinh = gt;
            sv.cmnd = this.mtxtcmnd.Text;
            sv.sdt = mtxtsdt.Text;
            sv.sdt = sv.sdt.Replace(",", string.Empty);
            sv.sdt = sv.sdt.Replace(".", string.Empty);
            sv.diachi = this.txtdiachi.Text;
            for (int i = 0; i < clbmonhoc.Items.Count; i++)
            {
                if(clbmonhoc.GetItemChecked(i))
                {
                    monhoc.Add(clbmonhoc.Items[i].ToString());
                }
            }
            sv.monhoc = monhoc;
            return sv;
        }
        private bool kiemtra()
        {
            try
            {
                StringValidator.CheckLengthEqualTo(mtxtmssv.Text, 7, "vui lòng nhập đủ mã số sinh viên");
                StringValidator.CheckRequire(txthotenlot.Text, "vui lòng nhập tên");
                StringValidator.CheckRequire(txtten.Text, "Vui lòng nhập tên");
                if(rdNam.Checked == false && rdNu.Checked== false)
                {
                    throw new Exception("vui lòng chọn giới tính");

                }
                StringValidator.CheckRequire(cblop.Text, "Vui lòng chọn lớp");
                StringValidator.CheckLengthEqualTo(mtxtcmnd.Text, 9, "vui lòng nhập đủ CMND");
                StringValidator.CheckLengthEqualTo(mtxtsdt.Text, 10, "Vui lòng nhập số điện thoại hợp lệ");
                StringValidator.CheckRequire(txtdiachi.Text, "vui lòng nhập địa chỉ");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public sinhvien GetSinhvienLV(ListViewItem lvitem)
        {
            sinhvien sv = new sinhvien();
            sv.mssv = lvitem.SubItems[0].Text;
            sv.hotenlot = lvitem.SubItems[1].Text;
            sv.ten = lvitem.SubItems[2].Text;
            sv.ngaysinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.lop = lvitem.SubItems[4].Text;
            sv.gioitinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.gioitinh = true;
            sv.cmnd = lvitem.SubItems[6].Text;
            sv.sdt = lvitem.SubItems[7].Text;

            sv.sdt = sv.sdt.Replace(",", string.Empty);
            sv.sdt = sv.sdt.Replace(".", string.Empty);

            sv.diachi = lvitem.SubItems[8].Text;
            List<string> monhoc = new List<string>();
            string[] s = lvitem.SubItems[9].Text.Split(',');
            foreach (string c in s)
            {
                monhoc.Add(c);
            }
            sv.monhoc = monhoc;
            return sv;
        }
        public void thietlapthongtin(sinhvien sv)
        {
            this.mtxtmssv.Text = sv.mssv;
            this.txthotenlot.Text = sv.hotenlot;
            this.txtten.Text = sv.ten;
            this.dtpngaysinh.Value = sv.ngaysinh;
            this.cblop.Text = sv.lop;
            if (sv.gioitinh)
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            this.mtxtcmnd.Text = sv.cmnd;
            this.mtxtsdt.Text = sv.sdt;
            this.txtdiachi.Text = sv.diachi;
            for (int i = 0; i < clbmonhoc.Items.Count; i++)
            {
                this.clbmonhoc.SetItemChecked(i, false);
            }
            foreach (string s in sv.monhoc)
            {
                for (int i = 0; i < clbmonhoc.Items.Count; i++)
                {
                    if(s.Trim().CompareTo(this.clbmonhoc.Items[i].ToString())==0)
                    {
                        this.clbmonhoc.SetItemChecked(i, true);
                    }
                }
            }

        }
        public void themsv(sinhvien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.mssv);
            lvitem.SubItems.Add(sv.hotenlot);
            lvitem.SubItems.Add(sv.ten);
            lvitem.SubItems.Add(sv.ngaysinh.ToShortDateString());
            lvitem.SubItems.Add(sv.lop);
            string gt = "Nữ";
            if (sv.gioitinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.cmnd);
            lvitem.SubItems.Add(sv.sdt);
            lvitem.SubItems.Add(sv.diachi);
            lvitem.SubItems.Add(string.Join(",", sv.monhoc));
            this.lvdssv.Items.Add(lvitem);
            qlsv.ghifile();
        }
        public void loadlistview()
        {
            this.lvdssv.Items.Clear();
            foreach (sinhvien sv in qlsv.ds)
            {
                themsv(sv);
            }
        }

        private void lvdssv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvdssv.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvdssv.SelectedItems[0];
                sinhvien sv =  GetSinhvienLV(lvitem);
                thietlapthongtin(sv);
            }
        }
        public int sstheoma(object ob1 , object ob2)
        {
            sinhvien sv = ob2 as sinhvien;
            return sv.mssv.Trim().CompareTo(ob1.ToString().Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv = GetSinhvien();
            if (kiemtra())
            {


                sinhvien kq = qlsv.tim(sv.mssv, delegate (object ob1, object ob2)
                {
                    return (ob2 as sinhvien).mssv.CompareTo(ob1.ToString());
                });
                if (kq != null)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại , vui lòng nhập Mã sinh viên mới !!", "Lỗi Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    qlsv.them(sv);
                    this.loadlistview();
                    qlsv.ghifile();
                }
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            if (kiemtra())
            {
                sinhvien sv = new sinhvien();
                sv = GetSinhvien();
                bool kqsua = qlsv.sua(sv, sv.mssv, sstheoma);
                if (kqsua)
                {
                    this.loadlistview();
                    qlsv.ghifile();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát ra","Thông báo", MessageBoxButtons.OKCancel)==DialogResult.OK)
                Application.Exit();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            frmtimkiem frm = new frmtimkiem(qlsv,lvdssv);
            frm.Show();           
        }


        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbmonhoc.Items.Count; i++)
            {
                if(clbmonhoc.GetItemChecked(i))
                {
                    if(MessageBox.Show("Bạn có chắc chắn muốn xóa","Thông Báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
                        clbmonhoc.Items.RemoveAt(i);
                }
            }
        }
        
       
        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Enabled = true;
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {              
                clbmonhoc.Items.Add(toolStripTextBox1.Text);
                this.contextMenuStrip1.Close();
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvdssv.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvdssv.Items[i];
                if (lvitem.Checked)
                    qlsv.xoa(lvitem.SubItems[0].Text, sstheoma);
            }
            this.loadlistview();
            qlsv.ghifile();
        }

    }
}
