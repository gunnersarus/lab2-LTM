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

namespace Bai03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string filepath;
        private void buttonread_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd= new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            filepath=Path.GetDirectoryName(ofd.FileName);
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader rs= new StreamReader(fs);
            richTextBox1.Text = rs.ReadToEnd();
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
                string filename = Path.Combine(filepath, "output3.txt");
                using (StreamWriter sw=new StreamWriter(filename))
                {
                    DataTable data= new DataTable();
                    for(int i=0;i<richTextBox1.Lines.Length;i++)
                    {
                        string lines = richTextBox1.Lines[i];
                        string result=data.Compute(lines,"").ToString();
                        richTextBox2.AppendText(lines+" = "+result+"\n");
                    }
                    sw.WriteLine(richTextBox2.Text);
                }
            }
        }
    }
}
