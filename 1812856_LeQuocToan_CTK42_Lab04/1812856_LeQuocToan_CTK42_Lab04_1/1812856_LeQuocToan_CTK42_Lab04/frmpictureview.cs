using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1812856_LeQuocToan_CTK42_Lab04
{
    public partial class frmpictureview : Form
    {
        int count = 0;
        public frmpictureview()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if(openfile.ShowDialog()== DialogResult.OK)
            {
                frmpicture frm = new frmpicture(openfile.FileName);
                frm.MdiParent = this;
                count++;
                frm.Text = "Picture - " + count + "-" + openfile.FileName;
                frm.Show();
            }
            this.toolStripStatusLabel1.Text = "Tổng số form con " + count.ToString();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            if(savefile.ShowDialog()==DialogResult.OK)
            {
                frmpicture frm = this.ActiveMdiChild as frmpicture;
                try
                {
                    Image img = frm.pbHinh.Image;
                    img.Save(savefile.FileName, ImageFormat.Bmp);
                }
                catch
                {
                    MessageBox.Show("Lỗi Lưu File");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = this.statusTripToolStripMenuItem.Checked;
            if(check)
            {
                this.statusStrip1.Visible = true;
            }
            this.statusStrip1.Visible = false;
        }

        private void toolStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = this.toolStripToolStripMenuItem.Checked;
            if (check)
                toolStrip1.Visible = true;
            else toolStrip1.Visible = false;
        }

        private void arrIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangehorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void arrangeVeticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void maximizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.WindowState = FormWindowState.Maximized;
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (frmpicture frm in this.MdiChildren)
            {
                frm.pbHinh.Width += 50;
                frm.pbHinh.Height += 50;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (frmpicture frm in this.MdiChildren)
            {
                frm.pbHinh.Width -= 50;
                frm.pbHinh.Height -= 50;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (frmpicture frm in this.MdiChildren)
            {
                Process.Start("mspaint", frm.pbHinh.ImageLocation);

            }
        }
    }
}
