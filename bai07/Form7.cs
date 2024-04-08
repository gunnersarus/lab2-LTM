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
using Microsoft.Office.Interop.Word;

namespace bai07
{
    public partial class Form7 : Form
    {
       
        public Form7()
        {
            InitializeComponent();
            DirectoryInfo root = new DirectoryInfo(@"F:\");
            AddNodes(root,treeView1.Nodes);

            treeView1.NodeMouseDoubleClick += Treeview1_MouseDoubleclick;

            treeView1.AfterSelect += treeView1_AfterSelect;
        }
        private void AddNodes(DirectoryInfo directory, TreeNodeCollection nodes)
        {
            foreach(DirectoryInfo subdirectory in directory.GetDirectories())
            {
                TreeNode node= new TreeNode(subdirectory.Name);
                node.Tag = subdirectory;
                nodes.Add(node);
            }

            foreach(FileInfo file in directory.GetFiles())
            {
                TreeNode node= new TreeNode(file.Name);
                node.Tag = file.Name;
                nodes.Add(node);
            }
        }

        private void Treeview1_MouseDoubleclick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo directory)
            {
                treeView1.Nodes.Clear();
                AddNodes(directory, treeView1.Nodes);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode node = e.Node;
            FileAttributes attr = File.GetAttributes(node.Name);
            if (!attr.HasFlag(FileAttributes.Directory))
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(node.Name);
                    if (fileInfo.Extension == ".png" || fileInfo.Extension == ".jpg")
                    {
                        picPicture.Visible = true;
                        txtFile.Visible = false;
                        picPicture.Load(node.Name);
                    }
                    else if (fileInfo.Extension == ".txt")
                    {
                        picPicture.Visible = false;
                        txtFile.Visible = true;
                        FileStream fs = new FileStream(node.Name, FileMode.Open, FileAccess.Read);
                        StreamReader reader = new StreamReader(fs);
                        txtFile.Text = reader.ReadToEnd();
                        reader.Close();
                        fs.Close();
                    }
                    else if (fileInfo.Extension == ".docx" || fileInfo.Extension == ".doc")
                    {
                        picPicture.Visible = false;
                        txtFile.Visible = true;
                        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                        Document fileword = app.Documents.Open(node.Name);
                        txtFile.Text = fileword.Content.Text;
                        app.Quit();
                    }
                    else
                        MessageBox.Show("" +
                            "Định dạng được chấp nhận: '.docx', '.docx', '.txt', '.png', '.jpg'.",
                            "Lưu ý",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show(
                        "Đây không phải file ảnh!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

        }
        
    }
}
