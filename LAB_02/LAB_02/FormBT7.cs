using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_02
{
    public partial class FormBT7 : Form
    {
        public FormBT7()
        {
            InitializeComponent();
            LoadTree();
        }

        private void LoadTree()
        {
            string[] discs = Directory.GetLogicalDrives();
            TreeNode node = new TreeNode();
            foreach (string disc in discs)
            {
                node = new TreeNode(disc);
                treeView.Nodes.Add(node);
                node.Nodes.Add("temp");
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            if (node != null)
            {
                try
                {
                    foreach (string direct in Directory.GetDirectories(node.FullPath))
                    {
                        TreeNode child_node = node.Nodes.Add(Path.GetFileName(direct));
                        child_node.Nodes.Add("temp");
                    }
                    foreach (string file in Directory.GetFiles(node.FullPath))
                    {
                        if (file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".txt"))
                        {
                            TreeNode child_node = node.Nodes.Add(Path.GetFileName(file));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = null;
            TreeNode node = e.Node;
            if (e.Node.FullPath.ToLower().EndsWith(".jpg") || e.Node.FullPath.ToLower().EndsWith(".png"))
            {
                pictureBox.Visible = true;
                pictureBox.Image = Image.FromFile(e.Node.FullPath);
            }
            if (e.Node.FullPath.ToLower().EndsWith(".txt"))
            {
                textBox.Visible = true;
                FileStream fs = new FileStream(e.Node.FullPath, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                textBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
