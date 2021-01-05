using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testflowlayout.DAO;
using testflowlayout.DTO;

namespace testflowlayout
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loadflp()
        {
            bananDAO banan = new bananDAO();
            List<bananDTO> tablelist = banan.loadbanan();
            foreach (bananDTO table in tablelist)
            {
                Button btn = new Button() { Width = 100 , Height = 100} ;
                string x = "Trống";
                if (table.Status.Equals(1))
                    x = "Có người";
                btn.Text = table.Name + '\n' + x;
                btn.Click += Btn_Click;
                btn.Tag = table;
                flptable.Controls.Add(btn);
            }
            
        }
        private void loadthongtin(int ID , string name , int status , int capacity)
        {
            txtID.Text = ID.ToString();
            txtName.Text = name;
            if (status == 0)
            {
                cbstatus.Text = "Trống";
            }
            else cbstatus.Text = "Có người";
            nbrcapacity.Value = capacity;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int TableID = (sender as bananDTO).ID;
            string name = (sender as bananDTO).Name;
            int status = (sender as bananDTO).Status;
            int capacity = (sender as bananDTO).Capacity;
            loadthongtin(TableID, name, status, capacity);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadflp();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int status = 0;
            if(cbstatus.SelectedItem.ToString() == "Có người")
                status = 1;
            int capacity = Convert.ToInt32(nbrcapacity.Value);
            bananDAO banan = new bananDAO();
            bool thanhcong = banan.Thembanan(name, status, capacity);
            if(thanhcong == false)
            {
                MessageBox.Show("Thêm bàn ăn thất bại , vui lòng thử lại sau (-_-)", "Thông báo");
                return;
            }
            MessageBox.Show("Thêm bàn ăn thành công (^_^)", "Thông báo");
            loadflp();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int Id =Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            int status = 0;
            if (cbstatus.SelectedItem.ToString() == "Có người")
                status = 1;
            int capacity = Convert.ToInt32(nbrcapacity.Value);
            bananDAO banan = new bananDAO();
            bool thanhcong = banan.Capnhatbanan(Id,name, status, capacity);
            if (thanhcong == false)
            {
                MessageBox.Show("Cập nhật bàn ăn thất bại , vui lòng thử lại sau (-_-)", "Thông báo");
                return;
            }
            MessageBox.Show("Cập nhật bàn ăn thành công (^_^)", "Thông báo");
            loadflp();
        }

        private void flptable_Click(object sender, EventArgs e)
        {
            
        }
    }
}
