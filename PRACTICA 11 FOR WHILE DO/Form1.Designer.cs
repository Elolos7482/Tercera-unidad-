﻿namespace PRACTICA_11_FOR_WHILE_DO
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 66);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "f(x)=x/(1+x^2 )";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 150);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 150);
            label3.Name = "label3";
            label3.Size = new Size(36, 25);
            label3.TabIndex = 2;
            label3.Text = "f(x)";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(52, 222);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(170, 204);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(310, 218);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(176, 204);
            listBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(587, 210);
            button1.Name = "button1";
            button1.Size = new Size(92, 37);
            button1.TabIndex = 5;
            button1.Text = "for";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(581, 272);
            button2.Name = "button2";
            button2.Size = new Size(98, 31);
            button2.TabIndex = 6;
            button2.Text = "while";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Location = new Point(581, 328);
            button3.Name = "button3";
            button3.Size = new Size(98, 36);
            button3.TabIndex = 7;
            button3.Text = "do..while";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 128);
            button4.Location = new Point(578, 396);
            button4.Name = "button4";
            button4.Size = new Size(101, 34);
            button4.TabIndex = 8;
            button4.Text = "salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 565);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
