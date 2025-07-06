namespace _4_işlem_hesaplama
{
    partial class Form3
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
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(250, 439);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(148, 439);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 14;
            label3.Text = "CEVAP:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 13;
            button2.Text = "GERİ DÖN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.Location = new Point(383, 340);
            button1.Name = "button1";
            button1.Size = new Size(147, 48);
            button1.TabIndex = 12;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(344, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 34);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(344, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 34);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(148, 263);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 9;
            label2.Text = "2.Sayıyı Giriniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(148, 199);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 8;
            label1.Text = "1.Sayıyı Giriniz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Patrick Hand", 20F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(45, 91);
            label5.Name = "label5";
            label5.Size = new Size(858, 46);
            label5.TabIndex = 16;
            label5.Text = "\"Lütfen yapmak istediğiniz çıkarma işlemi için sayıları giriniz.\"\r\n";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 501);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}