using System.Configuration;

namespace practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radius, Height;
            double BaseArea, LateralArea, TotalArea;
            double Volume;

            Radius = double.Parse(textBox5.Text);
            Height = double.Parse(textBox6.Text);

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;

            textBox1.Text = BaseArea.ToString("0.##");
            textBox2.Text = LateralArea.ToString("0.##");
            textBox3.Text = TotalArea.ToString("0.##");
            textBox4.Text = Volume.ToString("0.##");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
