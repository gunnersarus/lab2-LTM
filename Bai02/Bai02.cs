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

namespace Bai02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonread_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            FileStream fs = new FileStream(ofd.FileName,FileMode.OpenOrCreate);
            StreamReader rs= new StreamReader(fs);
            Richtextbox.Text=rs.ReadToEnd();

            filename.Text = ofd.SafeFileName.ToString();
            var bytes=new FileInfo(ofd.FileName).Length;
            size.Text = bytes.ToString();
            url.Text = fs.Name.ToString();
            characters.Text=fs.Length.ToString();

            string conten=Richtextbox.Text;
            conten= conten.Replace("\r\n", "\r");
            line.Text=Richtextbox.Lines.Length.ToString();
            conten=conten.Replace("\r", " ");

            string[] count = conten.Split(new char[] { '.', '!', '?', ',', ' ', ';', ':' },StringSplitOptions.RemoveEmptyEntries);
            words.Text=count.Length.ToString();
            fs.Close();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
