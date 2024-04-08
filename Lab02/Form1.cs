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

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String filepath;
        private void buttonread_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            filepath = Path.GetDirectoryName(ofd.FileName);
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr=new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd(); 
            fs.Close();
        
        }

        private void buttonwrite_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Error!");
            }
            else
            {

               string filename = Path.Combine(filepath, "output.txt");
               using (StreamWriter sw=new StreamWriter(filename))
                {
                    richTextBox2.Text = richTextBox1.Text.ToUpper();
                    sw.WriteLine(richTextBox2.Text);
                    MessageBox.Show("Ok!");
                }
            }
   
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
