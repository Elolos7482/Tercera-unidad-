namespace Practica_6
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 96);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingresa Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 144);
            label3.Name = "label3";
            label3.Size = new Size(203, 25);
            label3.TabIndex = 2;
            label3.Text = "Opciones de conversion";
            // 
            // button1
            // 
            button1.Location = new Point(131, 188);
            button1.Name = "button1";
            button1.Size = new Size(133, 34);
            button1.TabIndex = 3;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(335, 188);
            button2.Name = "button2";
            button2.Size = new Size(148, 32);
            button2.TabIndex = 4;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(225, 269);
            button3.Name = "button3";
            button3.Size = new Size(116, 30);
            button3.TabIndex = 5;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 326);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 6;
            label4.Text = "Resultados en grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 363);
            label5.Name = "label5";
            label5.Size = new Size(178, 25);
            label5.TabIndex = 7;
            label5.Text = "Equivalente a Grados";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(327, 407);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 31);
            textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
