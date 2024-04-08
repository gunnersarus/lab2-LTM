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
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

namespace demo7
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                path = drive.Name;
                TreeNode root = new TreeNode(path);
                trvTree.Nodes.Add(root);
                if (drive.Name == "D:\\")
                {
                    LoadExplorer(root);
                }
                root.Text = drive.VolumeLabel + " (" + path + ")";
                root.Name = drive.Name;
            }
        }
        void LoadExplorer(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            try
            {
                DirectoryInfo[] listFolder = new DirectoryInfo(root.Text).GetDirectories();
                string[] listFile = Directory.GetFiles(root.Text);
                foreach (string item in listFile)
                {
                    FileInfo file = new FileInfo(item);
                    TreeNode fileNode = new TreeNode(item);
                    root.Nodes.Add(fileNode);
                    fileNode.Name = item;
                    fileNode.Text = file.Name;
                }
                foreach (DirectoryInfo item in listFolder)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode folder = new TreeNode(item.FullName);
                        root.Nodes.Add(folder);
                        LoadExplorer(folder);
                        folder.Name = item.FullName;
                        folder.Text = item.Name;
                    }
                }
            }
            catch
            {
                return;
            }
        }
        private void treeDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            FileAttributes attr = File.GetAttributes(node.Name);
            while (!attr.HasFlag(FileAttributes.Directory) || node != null)
            {
                try
                {
                    attr = File.GetAttributes(node.Name);
                }
                catch (System.NullReferenceException)
                {
                    break;
                }
                node = node.NextNode;
            }
        }
        private void treeDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
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
