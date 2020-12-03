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
    public partial class frmtimkiem : Form 
    {
        string kq;
        public string getmssv()
        {
            return kq;
        }
        danhsach qlsv,ql;
        ListView lv;
        sinhvien sv;
        public frmtimkiem()
        {
            InitializeComponent();
            qlsv = new danhsach();
        }
        internal frmtimkiem(danhsach qlsv,ListView lv):this()
        {
            this.qlsv = qlsv;
            this.lv = lv;
        }
        public void frmtimkiem_Load(object sender, EventArgs e)
        {
            txttimkiem.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0, i;
            if(txttimkiem.Text != "")
            {
                if(rdmssv.Checked == true)
                {
                    ql = new danhsach();
                    for ( i = 0; i < qlsv.ds.Count; i++)
                    {
                        if (qlsv.ds[i].mssv == txttimkiem.Text)
                        {
                            n++;
                            sv = new sinhvien();
                            sv.mssv = qlsv.ds[i].mssv;
                            sv.hotenlot = qlsv.ds[i].hotenlot;
                            sv.ten = qlsv.ds[i].ten;
                            sv.gioitinh = qlsv.ds[i].gioitinh;
                            sv.ngaysinh = qlsv.ds[i].ngaysinh;
                            sv.lop = qlsv.ds[i].lop;
                            sv.sdt = qlsv.ds[i].sdt;
                            sv.cmnd = qlsv.ds[i].cmnd;
                            sv.diachi = qlsv.ds[i].diachi;
                            sv.monhoc = qlsv.ds[i].monhoc;
                            ql.ds.Add(sv);
                        }
                    }
                }
                if (rdten.Checked == true)
                {
                    ql = new danhsach();
                    for (i = 0; i < qlsv.ds.Count; i++)
                    {
                        if (qlsv.ds[i].ten == txttimkiem.Text)
                        {
                            n++;
                            sv = new sinhvien();
                            sv.mssv = qlsv.ds[i].mssv;
                            sv.hotenlot = qlsv.ds[i].hotenlot;
                            sv.ten = qlsv.ds[i].ten;
                            sv.gioitinh = qlsv.ds[i].gioitinh;
                            sv.ngaysinh = qlsv.ds[i].ngaysinh;
                            sv.lop = qlsv.ds[i].lop;
                            sv.sdt = qlsv.ds[i].sdt;
                            sv.cmnd = qlsv.ds[i].cmnd;
                            sv.diachi = qlsv.ds[i].diachi;
                            sv.monhoc = qlsv.ds[i].monhoc;
                            ql.ds.Add(sv);
                        }
                    }
                }
                if (rdlop.Checked == true)
                {
                    ql = new danhsach();
                    for (i = 0; i < qlsv.ds.Count; i++)
                    {
                        if (qlsv.ds[i].lop == txttimkiem.Text)
                        {
                            n++;
                            sv = new sinhvien();
                            sv.mssv = qlsv.ds[i].mssv;
                            sv.hotenlot = qlsv.ds[i].hotenlot;
                            sv.ten = qlsv.ds[i].ten;
                            sv.gioitinh = qlsv.ds[i].gioitinh;
                            sv.ngaysinh = qlsv.ds[i].ngaysinh;
                            sv.lop = qlsv.ds[i].lop;
                            sv.sdt = qlsv.ds[i].sdt;
                            sv.cmnd = qlsv.ds[i].cmnd;
                            sv.diachi = qlsv.ds[i].diachi;
                            sv.monhoc = qlsv.ds[i].monhoc;
                            ql.ds.Add(sv);
                        }
                    }
                }
                lv.Items.Clear();
                for (i = 0; i < ql.ds.Count; i++)
                {
                    string gt = "Nữ", m = "";
                    ListViewItem lview = new ListViewItem(qlsv.ds[i].mssv);
                    if (qlsv.ds[i].gioitinh)
                        gt = "Nam";
                    lview.SubItems.Add(qlsv.ds[i].hotenlot);
                    lview.SubItems.Add(qlsv.ds[i].ten);
                    lview.SubItems.Add(gt);
                    lview.SubItems.Add(qlsv.ds[i].ngaysinh.ToString("dd/MM/yyyy"));
                    lview.SubItems.Add(qlsv.ds[i].lop);
                    lview.SubItems.Add(qlsv.ds[i].cmnd);
                    lview.SubItems.Add(qlsv.ds[i].sdt);
                    lview.SubItems.Add(qlsv.ds[i].diachi);
                    foreach (string mh in qlsv.ds[i].monhoc)
                        m += mh + ",";
                    lview.SubItems.Add(m);
                    lv.Items.Add(lview);
                }
                MessageBox.Show("Tìm thấy " + n + " sinh viên");
            }
            else
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    
        

        private void rdmssv_CheckedChanged(object sender, EventArgs e)
        {
            if(rdmssv.Checked)
            {
                label1.Text = rdmssv.Text + ":";
                txttimkiem.Text = "";
                txttimkiem.Enabled = true;
            }
        }

        private void rdten_CheckedChanged(object sender, EventArgs e)
        {
            if (rdten.Checked)
            {
                label1.Text = rdten.Text + ":";
                txttimkiem.Text = "";
                txttimkiem.Enabled = true;
            }
        }

        private void rdlop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdlop.Checked)
            {
                label1.Text = rdlop.Text + ":";
                txttimkiem.Text = "";
                txttimkiem.Enabled = true;
            }
        }
    }
}
