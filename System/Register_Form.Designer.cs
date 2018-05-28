namespace System
{
    partial class Register_Form
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Send_Button = new System.Windows.Forms.Button();
            this.LoadIMG_Button = new System.Windows.Forms.Button();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.RetryBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OPF = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Send_Button);
            this.panel2.Controls.Add(this.LoadIMG_Button);
            this.panel2.Controls.Add(this.ImageBox);
            this.panel2.Controls.Add(this.DateTime);
            this.panel2.Controls.Add(this.RetryBox);
            this.panel2.Controls.Add(this.PassBox);
            this.panel2.Controls.Add(this.email_box);
            this.panel2.Controls.Add(this.CountryBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial", 10.8F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 565);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 41);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(3, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "*Все поля обязательны к заполнению";
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(404, 393);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(272, 51);
            this.Send_Button.TabIndex = 7;
            this.Send_Button.Text = "Отправить";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // LoadIMG_Button
            // 
            this.LoadIMG_Button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadIMG_Button.Location = new System.Drawing.Point(594, 302);
            this.LoadIMG_Button.Name = "LoadIMG_Button";
            this.LoadIMG_Button.Size = new System.Drawing.Size(221, 32);
            this.LoadIMG_Button.TabIndex = 6;
            this.LoadIMG_Button.Text = "Загрузить";
            this.LoadIMG_Button.UseVisualStyleBackColor = true;
            this.LoadIMG_Button.Click += new System.EventHandler(this.LoadIMG_Button_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBox.Location = new System.Drawing.Point(594, 49);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(221, 221);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 5;
            this.ImageBox.TabStop = false;
            // 
            // DateTime
            // 
            this.DateTime.CustomFormat = "";
            this.DateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateTime.Location = new System.Drawing.Point(293, 178);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(215, 28);
            this.DateTime.TabIndex = 4;
            this.DateTime.ValueChanged += new System.EventHandler(this.DateTime_ValueChanged);
            // 
            // RetryBox
            // 
            this.RetryBox.Location = new System.Drawing.Point(293, 306);
            this.RetryBox.Name = "RetryBox";
            this.RetryBox.PasswordChar = '*';
            this.RetryBox.Size = new System.Drawing.Size(215, 28);
            this.RetryBox.TabIndex = 3;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(293, 242);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(215, 28);
            this.PassBox.TabIndex = 3;
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(293, 114);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(215, 28);
            this.email_box.TabIndex = 3;
            // 
            // CountryBox
            // 
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Location = new System.Drawing.Point(293, 49);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(215, 29);
            this.CountryBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(12);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(12);
            this.label5.Size = new System.Drawing.Size(194, 46);
            this.label5.TabIndex = 1;
            this.label5.Text = "Повторите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(12);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(12);
            this.label4.Size = new System.Drawing.Size(87, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(37, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(12);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(12);
            this.label11.Size = new System.Drawing.Size(97, 46);
            this.label11.TabIndex = 0;
            this.label11.Text = "Страна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(12);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(12);
            this.label3.Size = new System.Drawing.Size(100, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(12);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(12);
            this.label2.Size = new System.Drawing.Size(168, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата рождения";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OPF
            // 
            this.OPF.FileName = "openFileDialog1";
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 565);
            this.Controls.Add(this.panel2);
            this.Name = "Register_Form";
            this.Text = "Register_Form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panel2;
        private Windows.Forms.Label label3;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label5;
        private Windows.Forms.Label label4;
        private Windows.Forms.Label label11;
        private Windows.Forms.Label label6;
        private Windows.Forms.Button Send_Button;
        private Windows.Forms.Button LoadIMG_Button;
        private Windows.Forms.PictureBox ImageBox;
        private Windows.Forms.DateTimePicker DateTime;
        private Windows.Forms.TextBox RetryBox;
        private Windows.Forms.TextBox PassBox;
        private Windows.Forms.TextBox email_box;
        private Windows.Forms.ComboBox CountryBox;
        private Windows.Forms.Panel panel1;
        private Windows.Forms.Label label7;
        private Windows.Forms.Timer timer1;
        private Windows.Forms.Label label1;
        private Windows.Forms.OpenFileDialog OPF;
    }
}