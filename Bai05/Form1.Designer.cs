using System.Drawing;
using System.Windows.Forms;

namespace Bai05
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

      
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.A_1 = new System.Windows.Forms.CheckBox();
            this.A_2 = new System.Windows.Forms.CheckBox();
            this.B_1 = new System.Windows.Forms.CheckBox();
            this.A_3 = new System.Windows.Forms.CheckBox();
            this.C_1 = new System.Windows.Forms.CheckBox();
            this.B_2 = new System.Windows.Forms.CheckBox();
            this.A_4 = new System.Windows.Forms.CheckBox();
            this.C_2 = new System.Windows.Forms.CheckBox();
            this.B_3 = new System.Windows.Forms.CheckBox();
            this.A_5 = new System.Windows.Forms.CheckBox();
            this.C_3 = new System.Windows.Forms.CheckBox();
            this.B_4 = new System.Windows.Forms.CheckBox();
            this.B_5 = new System.Windows.Forms.CheckBox();
            this.C_4 = new System.Windows.Forms.CheckBox();
            this.C_5 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Đào, Phở  và Piano",
            "Mai",
            "Tarot"});
            this.comboBox1.Location = new System.Drawing.Point(157, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn phim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đặt vé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // A_1
            // 
            this.A_1.AutoSize = true;
            this.A_1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_1.Location = new System.Drawing.Point(187, 48);
            this.A_1.Name = "A_1";
            this.A_1.Size = new System.Drawing.Size(18, 20);
            this.A_1.TabIndex = 0;
            this.A_1.Text = "1";
            this.A_1.UseVisualStyleBackColor = true;
            // 
            // A_2
            // 
            this.A_2.AutoSize = true;
            this.A_2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_2.Location = new System.Drawing.Point(214, 48);
            this.A_2.Name = "A_2";
            this.A_2.Size = new System.Drawing.Size(18, 20);
            this.A_2.TabIndex = 0;
            this.A_2.Text = "2";
            this.A_2.UseVisualStyleBackColor = true;
            // 
            // B_1
            // 
            this.B_1.AutoSize = true;
            this.B_1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_1.Location = new System.Drawing.Point(187, 75);
            this.B_1.Name = "B_1";
            this.B_1.Size = new System.Drawing.Size(18, 20);
            this.B_1.TabIndex = 0;
            this.B_1.Text = "1";
            this.B_1.UseVisualStyleBackColor = true;
            // 
            // A_3
            // 
            this.A_3.AutoSize = true;
            this.A_3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_3.Location = new System.Drawing.Point(240, 48);
            this.A_3.Name = "A_3";
            this.A_3.Size = new System.Drawing.Size(18, 20);
            this.A_3.TabIndex = 0;
            this.A_3.Text = "3";
            this.A_3.UseVisualStyleBackColor = true;
            // 
            // C_1
            // 
            this.C_1.AutoSize = true;
            this.C_1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C_1.Location = new System.Drawing.Point(187, 101);
            this.C_1.Name = "C_1";
            this.C_1.Size = new System.Drawing.Size(18, 20);
            this.C_1.TabIndex = 0;
            this.C_1.Text = "1";
            this.C_1.UseVisualStyleBackColor = true;
            // 
            // B_2
            // 
            this.B_2.AutoSize = true;
            this.B_2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_2.Location = new System.Drawing.Point(214, 75);
            this.B_2.Name = "B_2";
            this.B_2.Size = new System.Drawing.Size(18, 20);
            this.B_2.TabIndex = 0;
            this.B_2.Text = "2";
            this.B_2.UseVisualStyleBackColor = true;
            // 
            // A_4
            // 
            this.A_4.AutoSize = true;
            this.A_4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_4.Location = new System.Drawing.Point(266, 48);
            this.A_4.Name = "A_4";
            this.A_4.Size = new System.Drawing.Size(18, 20);
            this.A_4.TabIndex = 0;
            this.A_4.Text = "4";
            this.A_4.UseVisualStyleBackColor = true;
            // 
            // C_2
            // 
            this.C_2.AutoSize = true;
            this.C_2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C_2.Location = new System.Drawing.Point(214, 101);
            this.C_2.Name = "C_2";
            this.C_2.Size = new System.Drawing.Size(18, 20);
            this.C_2.TabIndex = 0;
            this.C_2.Text = "2";
            this.C_2.UseVisualStyleBackColor = true;
            // 
            // B_3
            // 
            this.B_3.AutoSize = true;
            this.B_3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_3.Location = new System.Drawing.Point(240, 75);
            this.B_3.Name = "B_3";
            this.B_3.Size = new System.Drawing.Size(18, 20);
            this.B_3.TabIndex = 0;
            this.B_3.Text = "3";
            this.B_3.UseVisualStyleBackColor = true;
            // 
            // A_5
            // 
            this.A_5.AutoSize = true;
            this.A_5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_5.Location = new System.Drawing.Point(293, 48);
            this.A_5.Name = "A_5";
            this.A_5.Size = new System.Drawing.Size(18, 20);
            this.A_5.TabIndex = 0;
            this.A_5.Text = "5";
            this.A_5.UseVisualStyleBackColor = true;
            // 
            // C_3
            // 
            this.C_3.AutoSize = true;
            this.C_3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C_3.Location = new System.Drawing.Point(240, 101);
            this.C_3.Name = "C_3";
            this.C_3.Size = new System.Drawing.Size(18, 20);
            this.C_3.TabIndex = 0;
            this.C_3.Text = "3";
            this.C_3.UseVisualStyleBackColor = true;
            // 
            // B_4
            // 
            this.B_4.AutoSize = true;
            this.B_4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_4.Location = new System.Drawing.Point(266, 75);
            this.B_4.Name = "B_4";
            this.B_4.Size = new System.Drawing.Size(18, 20);
            this.B_4.TabIndex = 0;
            this.B_4.Text = "4";
            this.B_4.UseVisualStyleBackColor = true;
            // 
            // B_5
            // 
            this.B_5.AutoSize = true;
            this.B_5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_5.Location = new System.Drawing.Point(293, 75);
            this.B_5.Name = "B_5";
            this.B_5.Size = new System.Drawing.Size(18, 20);
            this.B_5.TabIndex = 0;
            this.B_5.Text = "5";
            this.B_5.UseVisualStyleBackColor = true;
            // 
            // C_4
            // 
            this.C_4.AutoSize = true;
            this.C_4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C_4.Location = new System.Drawing.Point(266, 101);
            this.C_4.Name = "C_4";
            this.C_4.Size = new System.Drawing.Size(18, 20);
            this.C_4.TabIndex = 0;
            this.C_4.Text = "4";
            this.C_4.UseVisualStyleBackColor = true;
            // 
            // C_5
            // 
            this.C_5.AutoSize = true;
            this.C_5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C_5.Location = new System.Drawing.Point(293, 101);
            this.C_5.Name = "C_5";
            this.C_5.Size = new System.Drawing.Size(18, 20);
            this.C_5.TabIndex = 0;
            this.C_5.Text = "5";
            this.C_5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "C";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.C_5);
            this.groupBox1.Controls.Add(this.C_4);
            this.groupBox1.Controls.Add(this.B_5);
            this.groupBox1.Controls.Add(this.B_4);
            this.groupBox1.Controls.Add(this.C_3);
            this.groupBox1.Controls.Add(this.A_5);
            this.groupBox1.Controls.Add(this.B_3);
            this.groupBox1.Controls.Add(this.C_2);
            this.groupBox1.Controls.Add(this.A_4);
            this.groupBox1.Controls.Add(this.B_2);
            this.groupBox1.Controls.Add(this.C_1);
            this.groupBox1.Controls.Add(this.A_3);
            this.groupBox1.Controls.Add(this.B_1);
            this.groupBox1.Controls.Add(this.A_2);
            this.groupBox1.Controls.Add(this.A_1);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ghế";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(13, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thành tiền";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Bai4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private CheckBox A_1;
        private CheckBox A_2;
        private CheckBox B_1;
        private CheckBox A_3;
        private CheckBox C_1;
        private CheckBox B_2;
        private CheckBox A_4;
        private CheckBox C_2;
        private CheckBox B_3;
        private CheckBox A_5;
        private CheckBox C_3;
        private CheckBox B_4;
        private CheckBox B_5;
        private CheckBox C_4;
        private CheckBox C_5;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label5;
        private Button button2;
    }
}

