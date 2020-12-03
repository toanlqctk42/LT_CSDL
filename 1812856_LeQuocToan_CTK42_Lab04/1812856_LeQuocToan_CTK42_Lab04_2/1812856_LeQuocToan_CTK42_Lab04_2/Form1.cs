using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1812856_LeQuocToan_CTK42_Lab04_2
{
    public partial class frmexplorer : Form
    {
        public frmexplorer()
        {
            InitializeComponent();
        }
        private string ImageKeyDriver(DriveInfo drive)
        {
            string type = "";
            switch (drive.DriveType)
            {
                case DriveType.Fixed:
                    break;
                case DriveType.CDRom:
                    break;
                case DriveType.Removable:
                    break;
                case DriveType.Network:
                    break;
                default:
                    type = "HDD";
                    break;
            }
            return type;
        }
        private void loaddrive(TreeNode tn)
        {
            TreeNode tnode = new TreeNode();
            foreach (DriveInfo dr  in DriveInfo.GetDrives())
            {
                tnode = new TreeNode();
                tnode.Text = dr.Name;
                tnode.Tag = dr.ToString();
                tnode.ImageKey = ImageKeyDriver(dr);
                tnode.ImageKey = ImageKeyDriver(dr);
                tn.Nodes.Add(tnode);
            }
        }
        // phương thức thêm thư mục vào tnParent
        private void Insertfolder(TreeNode tnparent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnparent.Tag.ToString());
                foreach (DirectoryInfo dircur in dir.GetDirectories())
                {
                    TreeNode tnchild = new TreeNode(dircur.Name, 6, 6);
                    tnchild.Tag = dircur.FullName;
                    tnparent.Nodes.Add(tnchild);
                }
            }
            catch 
            {

            }
        }
        //phương thức file vào listviewfile của tnparent
        private void insertfile(TreeNode tnparent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnparent.Tag.ToString());
                this.lvds.Items.Clear();
                foreach (FileInfo filecur in dir.GetFiles())
                {
                    ListViewItem lvitem = new ListViewItem(filecur.Name);
                    lvitem.SubItems.Add(filecur.LastWriteTime.ToShortDateString());
                    lvitem.SubItems.Add(filecur.Extension);
                    lvitem.SubItems.Add((filecur.Length / 1024).ToString());
                    this.lvds.Items.Add(lvitem);
                }
                this.toolStripStatusLabel1.Text = "Tổng số file: " + this.lvds.Items.Count;
            }
            catch
            {

            }
        }
        // Phương thức thêm đĩa hoặc thư mục và file của node tnparent
        private void insertchildparent(TreeNode tnparent)
        {
            if (tnparent != null)
                if (tnparent.Level == 0)
                {
                    TreeNode tnmydocument = new TreeNode("My Documents", 2, 2);
                    tnmydocument.Tag = SpecialDirectories.MyDocuments;
                    TreeNode tnmycomputer = new TreeNode("My Computer", 1, 1);
                    tnmycomputer.Tag = " My Computer";
                    tnparent.Nodes.Insert(0, tnmydocument);
                    tnparent.Nodes.Insert(1, tnmycomputer);
                }
                else
                    if (tnparent.Nodes.Count == 0)
                    {
                        if (tnparent.Text == "My Computer")
                        {
                            loaddrive(tnparent);
                            return;
                        }
                        Insertfolder(tnparent);
                    }
                insertfile(tnparent);
        }

        private void frmexplorer_Load(object sender, EventArgs e)
        {
            TreeNode tnode = new TreeNode();
            tnode.Text = "Desktop";
            tnode.Tag = SpecialDirectories.Desktop;
            tnode.ImageKey = "Desktop";
            tnode.SelectedImageKey = "Desktop";
            int root = this.treeView1.Nodes.Add(tnode);
            string name = Application.StartupPath;
            name = name.Substring(0, name.LastIndexOf('\\'));
            name = name.Substring(0, name.LastIndexOf('\\'));

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tnparent = e.Node;
            TreeNode tncurrent = e.Node;
            insertchildparent(tnparent);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
