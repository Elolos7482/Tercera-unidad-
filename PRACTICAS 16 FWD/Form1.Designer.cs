namespace PRACTICAS_16_FWD
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 38);
            label1.Name = "label1";
            label1.Size = new Size(266, 75);
            label1.TabIndex = 0;
            label1.Text = "Dado como un dato un numero\r\n determinar si es par o impar y \r\ndivisible por 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 201);
            label2.Name = "label2";
            label2.Size = new Size(228, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingresar numero cualquiera";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 31);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(151, 301);
            button1.Name = "button1";
            button1.Size = new Size(126, 31);
            button1.TabIndex = 3;
            button1.Text = "Determinar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(376, 300);
            button2.Name = "button2";
            button2.Size = new Size(105, 32);
            button2.TabIndex = 4;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}
