using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bai04
{
    public partial class Formbai4 : Form
    {
        public class Hocvien
        {
            private string name, mssv, phone;
            private float toan, ly, hoa;
            public string Name { get => name; set => name = value; }
            public string Mssv { get => mssv; set => mssv = value; }

            public string Phone { get => phone; set => phone = value; }

            public float Math { get => toan; set => toan = value; }
            public float Physics { get => ly; set => ly = value; }
            public float Chemistry { get => hoa; set => hoa = value; }

            public float Average()
            {
                return (toan + ly + hoa) / 3;
            }
        }
        private List<Hocvien> hv = new List<Hocvien>();
        string filepath;
        public Formbai4()
        {
            InitializeComponent();
        }

        private void Formbai4_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if(mssv.Text.Length!=8)
            {
                MessageBox.Show("MSSV không hợp lệ!");
            }
            if (phone.Text.Length != 10)
            {
                MessageBox.Show("SDT không hợp lệ!");
            }
            else
            {
                richTextBox1.Text += string.Format("{0};{1};{2}", name.Text, mssv.Text, phone.Text) + Environment.NewLine; ;
                richTextBox1.Text += subject1.Text + "\n";
                richTextBox1.Text += subject2.Text + "\n";
                richTextBox1.Text += subject3.Text + "\n";
                hv.Add(new Hocvien()
                {
                    Name = name.Text,
                    Mssv= mssv.Text,
                    Phone= phone.Text,
                    Math= float.Parse(subject1.Text),
                    Physics=float.Parse(subject2.Text),
                    Chemistry=float.Parse(subject3.Text) 
                }
                );

            }
        }

        private void mssv_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            name.Text = "";
            mssv.Text = "";
            phone.Text = "";
            subject1.Text = "";
            subject2.Text = "";
            subject3.Text = "";
        }

        private void buttonwrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                string filename = ofd.FileName;
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.WriteLine(richTextBox1.Text);
                }
            }
            filepath= ofd.FileName;

        }

        private void buttonread_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(richTextBox1.Text))
           {
                MessageBox.Show("Error!");
           }
           else
           {
                using (StreamReader sr=new StreamReader(filepath))
                {
                    foreach(Hocvien sinhvien in hv)
                    {
                        textBoxname.Text = sinhvien.Name;
                        textBoxmssv.Text=sinhvien.Mssv;
                        textBoxphone.Text= sinhvien.Phone;
                        textBoxmath.Text = sinhvien.Math.ToString();
                        textBoxly.Text = sinhvien.Physics.ToString();
                        textBoxhoa.Text = sinhvien.Chemistry.ToString();
                        average.Text=sinhvien.Average().ToString();

                    }

                }
           }



        }
    }
}
