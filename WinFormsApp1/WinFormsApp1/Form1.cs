using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!double.TryParse(textBoxX.Text, out double x))
                {
                    MessageBox.Show("Введите корректное значение X");
                    return;
                }

                if (!int.TryParse(textBoxZ.Text, out int n) || n <= 0)
                {
                    MessageBox.Show("Введите корректное положительное значение N");
                    return;
                }

                double Z = 0;

                double X = Convert.ToDouble(textBoxX.Text);
                int N = Convert.ToInt32(textBoxZ.Text);

                if (eq1.Checked) // Первое уравнение 
                {
                    double p = Convert.ToDouble(comboBoxP.SelectedItem.ToString());
                    Z = CalculateSeriesEquation(X, p, N);
                }
                else // Второе уравнение 
                {
                    double a = Convert.ToDouble(comboBoxA.SelectedItem.ToString());
                    double b = Convert.ToDouble(comboBoxB.SelectedItem.ToString());
                    int R = Convert.ToInt32(listBoxR.SelectedItem.ToString());
                    Z = CalculateDoubleSumEquation(a, b, N, R);
                }

                textBoxResult.Text = Z.ToString("F6");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Метод для вычисления первого уравнения 
        private double CalculateSeriesEquation(double X, double p, int N)
        {
            double result = 0;

            for (int n = 1; n <= N; n++)
            {
                double term = CalculateSeriesTerm(X, p, n);
                result += term;
            }

            return result;
        }

        // Вычисление n-го члена ряда
        private double CalculateSeriesTerm(double X, double p, int n)
        {
          
            double sign = (n % 2 == 1) ? -1 : 1; 
            double pPower = (n == 1) ? 1 : Math.Pow(p, n - 1);
            double xPower = Math.Pow(X, n);
            double factorial = Factorial(n + 1);

            return sign * pPower * xPower / factorial;
        }

        // Метод для вычисления второго уравнения 
        private double CalculateDoubleSumEquation(double a, double b, int N, int R)
        {
            double result = 0;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= R; j++)
                {
                    double numerator = Math.Pow(a * i + j, 2);
                    double denominator = Math.Pow(i, 3) + b * Math.Pow(j, 3);
                    result += numerator / denominator;
                }
            }

            return result;
        }

        // Вспомогательный метод для вычисления факториала
        private double Factorial(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}