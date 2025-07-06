namespace _4_işlem_hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(364, 126);
            button1.Name = "button1";
            button1.Size = new Size(171, 73);
            button1.TabIndex = 0;
            button1.Text = "TOPLAMA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(364, 233);
            button2.Name = "button2";
            button2.Size = new Size(171, 73);
            button2.TabIndex = 1;
            button2.Text = "ÇIKARMA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(364, 346);
            button3.Name = "button3";
            button3.Size = new Size(171, 73);
            button3.TabIndex = 2;
            button3.Text = "ÇARPMA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(364, 453);
            button4.Name = "button4";
            button4.Size = new Size(171, 73);
            button4.TabIndex = 3;
            button4.Text = "BÖLME\r\n";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Patrick Hand", 24F, FontStyle.Bold);
            label1.Location = new Point(135, 35);
            label1.Name = "label1";
            label1.Size = new Size(647, 54);
            label1.TabIndex = 4;
            label1.Text = "\"Lütfen yapmak istediğiniz işlemi seçin.\"\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(937, 532);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}
