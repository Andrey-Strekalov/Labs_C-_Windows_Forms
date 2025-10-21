namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BackColor = Color.FromArgb(
                    Convert.ToInt32(toolStripTextBox1.Text),
                    Convert.ToInt32(toolStripTextBox2.Text),
                    Convert.ToInt32(toolStripTextBox3.Text)
                    );
            }
            catch
            {

                MessageBox.Show("Неверный формат данных", "Введите значение от 0 до 255");
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {

                case "белый": BackColor = Color.White; break;
                case "красный": BackColor = Color.Red; break;
                case "черный": BackColor = Color.Black; break;
                case "синий": BackColor = Color.Blue; break;
                case "желтый": BackColor = Color.Yellow; break;
                default: break;
            }
        }
    }
}
