using onthicuoiky.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onthicuoiky
{
    public partial class Form1 : Form
    {
        BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void addBindingsourcebanan()
        {
            txtID.DataBindings.Add(new Binding("Text", dgvtable.DataSource, "ID"));
            txtName.DataBindings.Add(new Binding("Text", dgvtable.DataSource, "Name"));
            cbstatus.DataBindings.Add(new Binding("SelectedIndex", dgvtable.DataSource, "Status"));
            nmcapacity.DataBindings.Add(new Binding("Value", dgvtable.DataSource, "Capacity"));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TableDAO table = new TableDAO();
            dgvtable.DataSource = bindingSource;
            bindingSource.DataSource = table.tablelist();
            addBindingsourcebanan();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int status = 0;
            if (cbstatus.SelectedItem.ToString() == "Có Người")
                status = 1;
            int capacity = Convert.ToInt32(nmcapacity.Value);
            TableDAO table = new TableDAO();
            bool Thanhcong = table.Thembanan(name, status, capacity);
            if(Thanhcong == false)
            {
                MessageBox.Show("Thêm bàn không thành công (-_-) , vui lòng thử lại sau", "Thông báo");
                return;
            }
            MessageBox.Show("Thêm bàn thành công (^_^)", "Thông báo");
            dgvtable.DataSource = table.tablelist();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            int status = 0;
            if (cbstatus.SelectedItem.ToString() == "Có Người")
                status = 1;
            int capacity = Convert.ToInt32(nmcapacity.Value);
            TableDAO table = new TableDAO();
            bool Thanhcong = table.Capnhatbanan(ID,name, status, capacity);
            if (Thanhcong == false)
            {
                MessageBox.Show("Cập nhật bàn không thành công (-_-) , vui lòng thử lại sau", "Thông báo");
                return;
            }
            MessageBox.Show("Cập nhật bàn thành công (^_^)", "Thông báo");
            dgvtable.DataSource = table.tablelist();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            TableDAO table = new TableDAO();
            bool Thanhcong = table.xoaban(ID);
            if (Thanhcong == false)
            {
                MessageBox.Show("Xóa bàn không thành công (-_-) , vui lòng thử lại sau", "Thông báo");
                return;
            }
            MessageBox.Show("Xóa bàn thành công (^_^)", "Thông báo");
            dgvtable.DataSource = table.tablelist();
        }

        private void dgvtable_Click(object sender, EventArgs e)
        {
            if (dgvtable.SelectedRows.Count == 0) return;
            int tableid = Convert.ToInt32(dgvtable.SelectedRows[0].Cells["ID"].Value.ToString());
            CTHDDAO cthoadon = new CTHDDAO();
            dgvchitiethoadon.DataSource = cthoadon.dshoadontheoban(tableid);
        }
    }

}
