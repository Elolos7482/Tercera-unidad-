namespace PRACTICA_1_FOR_WHILE_DO
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
            listBox1 = new ListBox();
            Listar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 54);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 0;
            label1.Text = "Escribe los numeros del 0 al 10";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(253, 148);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(118, 229);
            listBox1.TabIndex = 1;
            // 
            // Listar
            // 
            Listar.Location = new Point(468, 234);
            Listar.Name = "Listar";
            Listar.Size = new Size(134, 33);
            Listar.TabIndex = 2;
            Listar.Text = "Listar";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += Listar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Listar);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button Listar;
    }
}
