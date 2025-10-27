namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double x, y, term, result;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            switch (term)
            {
                case 1:
                    {
                        result = x / (Math.Abs(y - x * x));
                        toolStripStatusLabel1.Text = result.ToString();
                    }
                    break;
                case 2:
                    {
                        result = Math.Sqrt(Math.Abs(x) - Math.Sqrt(y));
                        toolStripStatusLabel1.Text = result.ToString();
                    }
                    break;
                case 3:
                    {
                        result = Math.Cos(x) + Math.Sin(y);
                        toolStripStatusLabel1.Text = result.ToString();
                    }
                    break;
                default: break;

            }
        }

        private void toolStripMenuItem1_CheckedChanged(object sender, EventArgs e) {term = 1;}

        private void toolStripMenuItem2_CheckedChanged(object sender, EventArgs e) {term = 2;}

        private void toolStripMenuItem3_CheckedChanged(object sender, EventArgs e) {term = 3;}




    }
}
