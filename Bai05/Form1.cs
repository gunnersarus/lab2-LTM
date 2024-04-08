using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        int tongtien = 0;
        class Phim
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public int[] PhongChieu { get; set; }
        }
        public Form1()
        {
            InitializeComponent();

            Phim phim1 = new Phim()
            {
                TenPhim = "Đào, phở và piano",
                GiaVeChuan = 45000,
              
            };
            Phim phim2 = new Phim()
            {
                TenPhim = "Mai",
                GiaVeChuan = 100000,
              
            };
            Phim phim3 = new Phim()
            {
                TenPhim = "Tarot",
                GiaVeChuan = 90000,
               
            };

            List<Phim> phims = new List<Phim>();

            phims.Add(phim1);
            phims.Add(phim2);
            phims.Add(phim3);

            comboBox1.DataSource = phims;
            comboBox1.DisplayMember = "TenPhim";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phim selectedPhim = comboBox1.SelectedItem as Phim;

            List<CheckBox> checkBoxes = groupBox1.Controls.OfType<CheckBox>().ToList();
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    string hangGhe = checkBox.Name.Split('_')[0];
                    int soTTGhe = int.Parse(checkBox.Name.Split('_')[1]);
                    int giaVeChuan = selectedPhim.GiaVeChuan;

                    // tinh tien
                    if(soTTGhe==1|| soTTGhe==5)
                    {
                        tongtien = tongtien + (giaVeChuan / 4);
                    }
                    if(soTTGhe>=2 && soTTGhe<=4&& hangGhe=="B")
                    {
                        tongtien = tongtien + (giaVeChuan * 2);
                    }
                    else
                    {
                        tongtien += giaVeChuan;
                    }
                }
            }
            textBox1.Text = tongtien.ToString();
            
        }

       
       
    }
}
