namespace PasswordGenerator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.seedbox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password1box = new System.Windows.Forms.TextBox();
            this.password2box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password3box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password4box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password5box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password6box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.password7box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.password8box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.password9box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.password10box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.password11box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.password12box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seed:";
            // 
            // seedbox
            // 
            this.seedbox.Location = new System.Drawing.Point(54, 10);
            this.seedbox.MaxLength = 19;
            this.seedbox.Name = "seedbox";
            this.seedbox.PasswordChar = '•';
            this.seedbox.Size = new System.Drawing.Size(108, 20);
            this.seedbox.TabIndex = 1;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(168, 8);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password 1:";
            // 
            // password1box
            // 
            this.password1box.Location = new System.Drawing.Point(83, 46);
            this.password1box.Name = "password1box";
            this.password1box.ReadOnly = true;
            this.password1box.Size = new System.Drawing.Size(154, 20);
            this.password1box.TabIndex = 4;
            // 
            // password2box
            // 
            this.password2box.Location = new System.Drawing.Point(83, 72);
            this.password2box.Name = "password2box";
            this.password2box.ReadOnly = true;
            this.password2box.Size = new System.Drawing.Size(154, 20);
            this.password2box.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password 3:";
            // 
            // password3box
            // 
            this.password3box.Location = new System.Drawing.Point(83, 98);
            this.password3box.Name = "password3box";
            this.password3box.ReadOnly = true;
            this.password3box.Size = new System.Drawing.Size(154, 20);
            this.password3box.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password 4:";
            // 
            // password4box
            // 
            this.password4box.Location = new System.Drawing.Point(83, 124);
            this.password4box.Name = "password4box";
            this.password4box.ReadOnly = true;
            this.password4box.Size = new System.Drawing.Size(154, 20);
            this.password4box.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password 5:";
            // 
            // password5box
            // 
            this.password5box.Location = new System.Drawing.Point(83, 148);
            this.password5box.Name = "password5box";
            this.password5box.ReadOnly = true;
            this.password5box.Size = new System.Drawing.Size(154, 20);
            this.password5box.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Password 6:";
            // 
            // password6box
            // 
            this.password6box.Location = new System.Drawing.Point(83, 174);
            this.password6box.Name = "password6box";
            this.password6box.ReadOnly = true;
            this.password6box.Size = new System.Drawing.Size(154, 20);
            this.password6box.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password 7:";
            // 
            // password7box
            // 
            this.password7box.Location = new System.Drawing.Point(83, 200);
            this.password7box.Name = "password7box";
            this.password7box.ReadOnly = true;
            this.password7box.Size = new System.Drawing.Size(154, 20);
            this.password7box.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Password 8:";
            // 
            // password8box
            // 
            this.password8box.Location = new System.Drawing.Point(83, 226);
            this.password8box.Name = "password8box";
            this.password8box.ReadOnly = true;
            this.password8box.Size = new System.Drawing.Size(154, 20);
            this.password8box.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Password 9:";
            // 
            // password9box
            // 
            this.password9box.Location = new System.Drawing.Point(83, 252);
            this.password9box.Name = "password9box";
            this.password9box.ReadOnly = true;
            this.password9box.Size = new System.Drawing.Size(154, 20);
            this.password9box.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Password 10:";
            // 
            // password10box
            // 
            this.password10box.Location = new System.Drawing.Point(83, 278);
            this.password10box.Name = "password10box";
            this.password10box.ReadOnly = true;
            this.password10box.Size = new System.Drawing.Size(154, 20);
            this.password10box.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Password 11:";
            // 
            // password11box
            // 
            this.password11box.Location = new System.Drawing.Point(83, 304);
            this.password11box.Name = "password11box";
            this.password11box.ReadOnly = true;
            this.password11box.Size = new System.Drawing.Size(154, 20);
            this.password11box.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Password 12:";
            // 
            // password12box
            // 
            this.password12box.Location = new System.Drawing.Point(83, 330);
            this.password12box.Name = "password12box";
            this.password12box.ReadOnly = true;
            this.password12box.Size = new System.Drawing.Size(154, 20);
            this.password12box.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 361);
            this.Controls.Add(this.password12box);
            this.Controls.Add(this.password11box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.password10box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.password9box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.password8box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.password7box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.password6box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.password5box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.password4box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password3box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password2box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password1box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.seedbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seedbox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password1box;
        private System.Windows.Forms.TextBox password2box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password3box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password4box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password5box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password6box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox password7box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox password8box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox password9box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox password10box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox password11box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox password12box;
    }
}