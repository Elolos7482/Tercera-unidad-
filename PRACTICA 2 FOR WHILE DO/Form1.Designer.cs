﻿namespace PRACTICA_2_FOR_WHILE_DO
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 34);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 0;
            label1.Text = "Tabla de multiplicacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(349, 25);
            label2.TabIndex = 1;
            label2.Text = "Introduce el valor de la tabla de multiplicar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 105);
            label3.Name = "label3";
            label3.Size = new Size(365, 25);
            label3.TabIndex = 2;
            label3.Text = "limite maximo para la tabla de multiplicacion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(569, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 31);
            textBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 128, 128);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(319, 170);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 279);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(616, 411);
            button1.Name = "button1";
            button1.Size = new Size(138, 51);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 507);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
    }
}
