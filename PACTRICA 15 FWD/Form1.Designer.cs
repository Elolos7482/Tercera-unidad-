namespace PACTRICA_15_FWD
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
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 51);
            label1.Name = "label1";
            label1.Size = new Size(382, 75);
            label1.TabIndex = 0;
            label1.Text = "Dado coomo dato el sueldo de un trabajador, \r\nel programa aplica un aumento del 15% \r\nsi el sueldo es inferior a 400000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 196);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingresar Sueldo";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 31);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(76, 269);
            button1.Name = "button1";
            button1.Size = new Size(166, 44);
            button1.TabIndex = 3;
            button1.Text = "Calcular ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(307, 269);
            button2.Name = "button2";
            button2.Size = new Size(120, 44);
            button2.TabIndex = 4;
            button2.Text = "Borrar ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 357);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 31);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 450);
            Controls.Add(textBox2);
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
        private TextBox textBox2;
    }
}
