namespace _4_işlem_hesaplama
{
    partial class Form5
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Patrick Hand", 20F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(12, 82);
            label5.Name = "label5";
            label5.Size = new Size(833, 46);
            label5.TabIndex = 34;
            label5.Text = "\"Lütfen yapmak istediğiniz bölme işlemi için sayıları giriniz.\"\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(240, 430);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(138, 430);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 32;
            label3.Text = "CEVAP:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button2.Location = new Point(2, 3);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 31;
            button2.Text = "GERİ DÖN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.Location = new Point(373, 331);
            button1.Name = "button1";
            button1.Size = new Size(147, 48);
            button1.TabIndex = 30;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(334, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 34);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(334, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 34);
            textBox1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(138, 254);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 27;
            label2.Text = "2.Sayıyı Giriniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(138, 190);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 26;
            label1.Text = "1.Sayıyı Giriniz:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 507);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}