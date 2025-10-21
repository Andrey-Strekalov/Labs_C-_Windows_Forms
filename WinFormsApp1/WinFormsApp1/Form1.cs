namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                default: BackColor = SystemColors.Control; break;
            }
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
                MessageBox.Show("Необходимо ввести целое число от 0 до 255", "Ошибка в задании цвета");
            }
        }


    }
}
