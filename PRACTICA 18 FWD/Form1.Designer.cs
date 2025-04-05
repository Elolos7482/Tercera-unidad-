namespace PRACTICA_18_FWD
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(751, 25);
            label1.TabIndex = 0;
            label1.Text = "Diagrma que pide los 3 lados de un triangulo y que diga si es equilatero, isosceles o escaleno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 84);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 1;
            label2.Text = "Longitud del lado A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 165);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Longitud lado B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 247);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 3;
            label4.Text = "Longitud lado C";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 31);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(81, 320);
            button1.Name = "button1";
            button1.Size = new Size(126, 33);
            button1.TabIndex = 7;
            button1.Text = "Desicion ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(296, 319);
            button2.Name = "button2";
            button2.Size = new Size(134, 34);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(516, 323);
            button3.Name = "button3";
            button3.Size = new Size(132, 30);
            button3.TabIndex = 9;
            button3.Text = "Salir ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 401);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 10;
            label5.Text = "Tipo de triangulo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(281, 398);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 31);
            textBox4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox textBox4;
    }
}
