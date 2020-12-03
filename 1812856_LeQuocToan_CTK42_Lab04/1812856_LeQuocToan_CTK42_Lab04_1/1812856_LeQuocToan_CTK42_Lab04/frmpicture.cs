using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1812856_LeQuocToan_CTK42_Lab04
{
    public partial class frmpicture : Form
    {
        Point p = new Point();
        bool ctrlkeydown;
        public frmpicture()
        {
            InitializeComponent();
            this.MouseWheel += Frmpicture_MouseWheel ;
            this.KeyDown += Frmpicture_KeyDown; ;
            this.KeyUp += Frmpicture_KeyUp; ;
        }

        private void Frmpicture_KeyUp(object sender, KeyEventArgs e)
        {
            this.ctrlkeydown = e.Control;
        }

        private void Frmpicture_KeyDown(object sender, KeyEventArgs e)
        {
            this.ctrlkeydown = e.Control;
        }

        private void Frmpicture_MouseWheel(object sender, MouseEventArgs e)
        {
            bool isGoUp = e.Delta > 0 ? true : false;

            if (ctrlkeydown)
            {
                int hStep = (int)(this.pbHinh.Image.Width * 0.02);
                int vStep = (int)(this.pbHinh.Image.Height * 0.02);

                if (isGoUp)
                {
                    this.pbHinh.Width += hStep;
                    this.pbHinh.Height += vStep;
                }
                else
                {
                    this.pbHinh.Width -= hStep;
                    this.pbHinh.Height -= vStep;
                }
            }
            else
            {
                if (isGoUp && this.vScrollBar1.Value > 5)
                {
                    this.vScrollBar1.Value -= 5;
                }
                if (!isGoUp && this.vScrollBar1.Value < this.vScrollBar1.Maximum - 5)
                {
                    this.vScrollBar1.Value += 5;
                }

                pbHinh.Location = new Point(p.X, p.Y - this.vScrollBar1.Value);
            }

        }

        private void frmpicture_Load(object sender, EventArgs e)
        {
            p = this.pbHinh.Location;
        }
        public frmpicture(string name)
        {
            InitializeComponent();
            this.pbHinh.ImageLocation = name;
            this.toolStripStatusLabel1.Text = name;
        }

        private void reLoadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openfiledlg = new OpenFileDialog();
            DialogResult dlg = openfiledlg.ShowDialog();
            string title = "";
            if (dlg == DialogResult.OK)
            {
                title = openfiledlg.FileName;
                this.Text = title;
                this.pbHinh.ImageLocation = openfiledlg.FileName;
            }
        }

        private void zoomToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.pbHinh.Width += 50;
            this.pbHinh.Height += 50;
        }

        private void zoomToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.pbHinh.Width -= 50;
            this.pbHinh.Height -= 50;
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Process.Start("mspaint", this.pbHinh.ImageLocation);
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X, p.Y - e.NewValue);
        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X - e.NewValue, p.Y);
        }

    }
}
