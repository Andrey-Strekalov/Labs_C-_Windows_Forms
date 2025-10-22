namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double x, y, z, a, b;
        public Form1()
        {
            InitializeComponent();

        }

        private void toolStripComboBoxA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                y = double.Parse(toolStripComboBoxY.Text);
                z = double.Parse(toolStripComboBoxZ.Text);
                x = double.Parse(toolStripTextBoxX.Text);
                a = double.Parse(toolStripTextBoxA.Text);
                b = double.Parse(toolStripTextBoxB.Text);

            }
            catch
            {
                MessageBox.Show("Ошибка при вводе значений");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                double result = a * x + ((b * y) / Math.Log10(z)) + ((Math.Sin(z)) / (Math.Cos(y)));
                this.Text = result.ToString();
            }
            catch
            {

                MessageBox.Show("Проверьте корректность введеных данных.", "Возможно введены не все данные");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Text = "";
            toolStripComboBoxY.Text = "";
            toolStripComboBoxZ.Text = "";
            toolStripTextBoxX.Text = "";
            toolStripTextBoxA.Text = "";
            toolStripTextBoxB.Text = "";
        }
    }
}
