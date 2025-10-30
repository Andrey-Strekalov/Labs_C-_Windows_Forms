using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x, y, U;
        int n;
        string inputFile, outputFile;

        private void textBoxInputN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(textBoxInputN.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите целочисленное значение.");
            }
        }


        private void readXY()
        {
            string[] lines = File.ReadAllLines(inputFile);
            try
            {
                if (lines.Length >= 2)
                {
                    x = Convert.ToDouble(lines[0]);
                    y = Convert.ToDouble(lines[1]);

                }
                else
                {
                    MessageBox.Show("Файл должен содержать минимум 2 строки");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
            }
        }

        private void saveResultToFile()
        {
            string filePath = Path.Combine(outputFile, "output.txt");
            File.WriteAllText(filePath, U.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }

        private void Calc()
        {
            readXY();
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    result -= ((Math.Pow(Math.Sin(x), i + 1)) * Math.Pow(y, 2 * i - 1)) / i + 1;
                }
                else
                {
                    result += ((Math.Pow(Math.Sin(x), i + 1)) * y) / 2;
                }
            }
            U = result;
        }

        private void btnCalcU_Click(object sender, EventArgs e)
        {
            Calc();
            txtResultU.Text = U.ToString();
            saveResultToFile();

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChooseFileWithData_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "Текстовые файлы (*.txt)|*.txt";
            dlg.FilterIndex = 3;
            dlg.Title = "Выберите файл с данными";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFileWithData.Text = dlg.FileName;
                inputFile = dlg.FileName;
            }
        }

        private void btnChooseFolderToSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Выберите папку для сохранения результата";
            dlg.ShowNewFolderButton = true;
            dlg.SelectedPath = Application.StartupPath;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFolderToSave.Text = dlg.SelectedPath;
                outputFile = dlg.SelectedPath;
            }
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;
            dlg.Font = txtChooseFont.Font;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFont.Font = dlg.Font;
                txtChooseFont.ForeColor = dlg.Color;
                btnCalcU.Font = dlg.Font;
                btnChooseFileWithData.Font = dlg.Font;
                btnChooseFolderToSave.Font = dlg.Font;
                btnChooseFont.Font = dlg.Font;
                btnCloseForm.Font = dlg.Font;

            }


        }
    }
}
