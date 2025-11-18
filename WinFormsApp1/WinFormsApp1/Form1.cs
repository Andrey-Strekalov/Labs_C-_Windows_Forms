namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double t, a, z;
        double g = 0;
        double q = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            a = (double)e.X;
            z = (double)e.Y;
            double.TryParse(textBox2.Text, out g);
            double.TryParse(textBox3.Text, out q);

            t = (a * z) / Math.Sqrt(Math.Pow(g, 3)) + (Math.Cos(g * q)) / (a * z) - g
                + Math.Abs(Math.Sin(q) + Math.Sqrt(Math.Abs(12 - q)));

            textBox1.Text = (t).ToString();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
