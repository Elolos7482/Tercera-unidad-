namespace PRACTICA_1_FOR_WHILE_DO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            int x = 0;
            do
            {
                listBox1.Items.Add(x);
                x++;
            }
            while (x <= 10);
        }
    }
}
