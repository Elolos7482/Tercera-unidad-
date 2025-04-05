namespace practica_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 54);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "escribe un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 127);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 1;
            label2.Text = "escribe un numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 190);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 2;
            label3.Text = "escribe un numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 257);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 3;
            label4.Text = "escribe un numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(330, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(330, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(330, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 31);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(553, 149);
            button1.Name = "button1";
            button1.Size = new Size(158, 54);
            button1.TabIndex = 8;
            button1.Text = "Invertir ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(553, 241);
            button2.Name = "button2";
            button2.Size = new Size(151, 56);
            button2.TabIndex = 9;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 345);
            label5.Name = "label5";
            label5.Size = new Size(35, 25);
            label5.TabIndex = 10;
            label5.Text = "N1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 345);
            label6.Name = "label6";
            label6.Size = new Size(35, 25);
            label6.TabIndex = 11;
            label6.Text = "N2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(420, 345);
            label7.Name = "label7";
            label7.Size = new Size(35, 25);
            label7.TabIndex = 12;
            label7.Text = "N3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(562, 345);
            label8.Name = "label8";
            label8.Size = new Size(35, 25);
            label8.TabIndex = 13;
            label8.Text = "N4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
