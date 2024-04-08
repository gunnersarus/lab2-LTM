namespace Bai02
{
    partial class Bai02
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonread = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.line = new System.Windows.Forms.TextBox();
            this.words = new System.Windows.Forms.TextBox();
            this.characters = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Richtextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonread
            // 
            this.buttonread.Location = new System.Drawing.Point(12, 24);
            this.buttonread.Name = "buttonread";
            this.buttonread.Size = new System.Drawing.Size(355, 39);
            this.buttonread.TabIndex = 0;
            this.buttonread.Text = "Read";
            this.buttonread.UseVisualStyleBackColor = true;
            this.buttonread.Click += new System.EventHandler(this.buttonread_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(17, 372);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(355, 39);
            this.buttonexit.TabIndex = 1;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(140, 86);
            this.filename.Multiline = true;
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(227, 33);
            this.filename.TabIndex = 2;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(140, 170);
            this.url.Multiline = true;
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(227, 33);
            this.url.TabIndex = 3;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(140, 127);
            this.size.Multiline = true;
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(227, 33);
            this.size.TabIndex = 3;
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(140, 209);
            this.line.Multiline = true;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(227, 33);
            this.line.TabIndex = 4;
            this.line.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // words
            // 
            this.words.Location = new System.Drawing.Point(140, 250);
            this.words.Multiline = true;
            this.words.Name = "words";
            this.words.Size = new System.Drawing.Size(227, 33);
            this.words.TabIndex = 5;
            this.words.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // characters
            // 
            this.characters.Location = new System.Drawing.Point(140, 293);
            this.characters.Multiline = true;
            this.characters.Name = "characters";
            this.characters.Size = new System.Drawing.Size(227, 33);
            this.characters.TabIndex = 6;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelname.ForeColor = System.Drawing.Color.Blue;
            this.labelname.Location = new System.Drawing.Point(12, 86);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(118, 29);
            this.labelname.TabIndex = 7;
            this.labelname.Text = "Filename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Words ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(12, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Characters";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // Richtextbox
            // 
            this.Richtextbox.Location = new System.Drawing.Point(373, 24);
            this.Richtextbox.Name = "Richtextbox";
            this.Richtextbox.Size = new System.Drawing.Size(415, 387);
            this.Richtextbox.TabIndex = 13;
            this.Richtextbox.Text = "";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Richtextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.characters);
            this.Controls.Add(this.words);
            this.Controls.Add(this.line);
            this.Controls.Add(this.size);
            this.Controls.Add(this.url);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonread);
            this.Name = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonread;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox line;
        private System.Windows.Forms.TextBox words;
        private System.Windows.Forms.TextBox characters;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox Richtextbox;
    }
}

