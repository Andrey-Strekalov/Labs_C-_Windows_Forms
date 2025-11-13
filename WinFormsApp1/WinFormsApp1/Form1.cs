using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Инициализация компонентов формы значениями переменных
            // Выбор режима
            comboMode.SelectedIndex = mode;
            // Установка коэффициентов
            txtA.Text = a.ToString();
            txtB.Text = b.ToString();
            txtK.Text = k.ToString();
            txtP.Text = p.ToString();

            // Добавляем обработчик события Paint для панели
            panelGraf.Paint += PanelGraf_Paint;
            // Добавляем обработчик изменения размера панели
            panelGraf.Resize += (s, e) => panelGraf.Invalidate();
        }

        // Цвет графика
        Color color = Color.Red;
        // Режим отображения
        int mode = 0;
        // Шаг расчета функции
        double dx = 0.5;
        // Интервал изменения x
        double x0 = 0.0, xn = 400.00;
        // Коэффициенты функции
        double a = 5, b = 100, p = -0.5, k = 2;
        int equation_index = 0;

        private double Calc(double x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {

                switch (equation_index)
                {
                    case 0:
                        return a * Math.Pow(x, -p) * Math.Sin(k * x + b);
                        break;
                    case 1:
                        return Math.Pow(Math.Sin(2 * x), 2) + Math.Sin(k * x) + p;
                        break;
                    case 2:
                        return Math.Pow(a * x, 3) - 1 / (p * k);
                        break;
                    case 3:
                        return b * Math.Pow((Math.Pow(x, 3) - 3), k - p);
                        break;
                    default: return 0;
                }
            }
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            // Обновляем коэффициенты из текстовых полей
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            k = Convert.ToDouble(txtK.Text);
            p = Convert.ToDouble(txtP.Text);
            // Перерисовываем график
            panelGraf.Invalidate();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = color;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                color = dlg.Color;
                panelGraf.Invalidate();
            }
        }

        private void comboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = comboMode.SelectedIndex;
            panelGraf.Invalidate();
        }

        private void PanelGraf_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            if (panelGraf.Width <= 0 || panelGraf.Height <= 0)
                return;

            // ФИКСИРОВАННЫЙ масштаб - убираем автоматическое подстраивание
            double xScale = panelGraf.Width / 60;
            double yScale = panelGraf.Height / 60; // Фиксированный коэффициент

            // Рисуем оси координат
            DrawCoordinateSystem(g);

            // Рисуем график
            DrawFunction(g, xScale, yScale);
        }

        private void DrawCoordinateSystem(Graphics g)
        {
            int centerX = panelGraf.Width / 2;
            int centerY = panelGraf.Height / 2;

            // Ось X
            g.DrawLine(Pens.Black, 0, centerY, panelGraf.Width, centerY);
            // Ось Y
            g.DrawLine(Pens.Black, centerX, 0, centerX, panelGraf.Height);
        }

        private void DrawFunction(Graphics g, double xScale, double yScale)
        {
            Point? previousPoint = null;
            Pen graphPen = new Pen(color, 2);
            try
            {
                for (double x = x0; x <= xn; x += dx)
                {
                    double y = Calc(x);

                    // Ограничиваем Y разумными пределами
                    y = Math.Max(-1000, Math.Min(1000, y));

                    int pixelX = (int)((x - x0) * xScale);
                    int pixelY = (int)(panelGraf.Height / 2 - y * yScale);

                    Point currentPoint = new Point(pixelX, pixelY);

                    if (previousPoint != null && mode == 0)
                    {
                        g.DrawLine(graphPen, previousPoint.Value, currentPoint);
                    }

                    if (mode == 1)
                    {
                        g.FillEllipse(new SolidBrush(color), currentPoint.X - 2, currentPoint.Y - 2, 4, 4);
                    }

                    previousPoint = currentPoint;
                }

                graphPen.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка!" + ex.ToString());
            }
        }
        private void comboBoxChooseEquation_SelectedIndexChanged(object sender, EventArgs e)
        {
            equation_index = comboBoxChooseEquation.SelectedIndex;
        }
    }
}