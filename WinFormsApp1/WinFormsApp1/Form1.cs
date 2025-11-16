using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int centerX;
        int centerY;
        private GraphicsPath filledRegion;
        private bool isMouseOverRegion = false;

        // Для перетаскивания подписи "x"
        private Point xLabelLocation;
        private bool isDraggingX = false;
        private Point dragOffset;

        // Для анимации
        private float currentFontSize = 18f;
        private float fontSizeDirection = 0.2f;
        private float minFontSize = 14f;
        private float maxFontSize = 24f;
        private Color currentAnimationColor = Color.Blue;
        private int colorPhase = 0;
        private bool isAnimationRunning = true;

        public Form1()
        {
            InitializeComponent();

            // Инициализация позиций
            centerX = this.Width / 2;
            centerY = this.Height / 2;
            xLabelLocation = new Point(centerX + 350, centerY); // Начальная позиция подписи "x"

            // Настройка таймера анимации
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();

         

            // Добавление кнопки для управления анимацией
            AddAnimationButton();
        }

        private void AddAnimationButton()
        {
            Button animationButton = new Button();
            animationButton.Text = "Остановить анимацию";
            animationButton.Size = new Size(120, 30);
            animationButton.Location = new Point(10, 10);
            animationButton.Click += AnimationButton_Click;
            this.Controls.Add(animationButton);
        }

        private void AnimationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isAnimationRunning)
            {
                animationTimer.Stop();
                isAnimationRunning = false;
                button.Text = "Запустить анимацию";
            }
            else
            {
                animationTimer.Start();
                isAnimationRunning = true;
                button.Text = "Остановить анимацию";
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Анимация размера шрифта
            currentFontSize += fontSizeDirection;
            if (currentFontSize > maxFontSize || currentFontSize < minFontSize)
            {
                fontSizeDirection = -fontSizeDirection;
            }

            // Анимация цвета (циклическое изменение через HSV)
            colorPhase = (colorPhase + 5) % 360;
            currentAnimationColor = HsvToRgb(colorPhase, 1.0, 1.0);

            this.Invalidate();
        }

        // Преобразование HSV в RGB
        private Color HsvToRgb(double h, double s, double v)
        {
            h = h % 360;
            double c = v * s;
            double x = c * (1 - Math.Abs((h / 60) % 2 - 1));
            double m = v - c;

            double r = 0, g = 0, b = 0;

            if (0 <= h && h < 60) { r = c; g = x; b = 0; }
            else if (60 <= h && h < 120) { r = x; g = c; b = 0; }
            else if (120 <= h && h < 180) { r = 0; g = c; b = x; }
            else if (180 <= h && h < 240) { r = 0; g = x; b = c; }
            else if (240 <= h && h < 300) { r = x; g = 0; b = c; }
            else if (300 <= h && h < 360) { r = c; g = 0; b = x; }

            return Color.FromArgb(
                (int)((r + m) * 255),
                (int)((g + m) * 255),
                (int)((b + m) * 255)
            );
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Проверяем, нажали ли на подпись "x"
            Font font = new Font("Arial", currentFontSize, FontStyle.Regular);
            SizeF textSize = TextRenderer.MeasureText("x", font);
            Rectangle xLabelRect = new Rectangle(xLabelLocation, textSize.ToSize());

            if (xLabelRect.Contains(e.Location))
            {
                isDraggingX = true;
                dragOffset = new Point(e.X - xLabelLocation.X, e.Y - xLabelLocation.Y);
            }
            font.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Перетаскивание подписи "x"
            if (isDraggingX)
            {
                xLabelLocation = new Point(e.X - dragOffset.X, e.Y - dragOffset.Y);
                this.Invalidate();
                return;
            }

            // Проверка наведения на закрашенную область
            if (filledRegion != null)
            {
                bool inside = filledRegion.IsVisible(e.Location);
                if (inside != isMouseOverRegion)
                {
                    isMouseOverRegion = inside;
                    this.Invalidate();
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingX = false;
        }

        private void DrawCoordinateSystem(Graphics g)
        {
            // Ось X с анимированным цветом
            using (Pen axisPen = new Pen(currentAnimationColor, 2))
            {
                g.DrawLine(axisPen, 0, centerY, this.Width, centerY);
                // Ось Y
                g.DrawLine(axisPen, centerX, 0, centerX, this.Height);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            // Используем анимированный размер шрифта
            Font font = new Font("Arial", currentFontSize, FontStyle.Regular);
            Pen dashedPen = new Pen(Color.Black);
            dashedPen.DashStyle = DashStyle.Dot;
            dashedPen.Width = 3;

            DrawCoordinateSystem(gr);
            Point pos = new Point(centerX, centerY);

            // Рисуем окружности с анимированным цветом
            using (Pen animatedPen = new Pen(currentAnimationColor, 2))
            {
                gr.DrawEllipse(animatedPen, pos.X - 100, pos.Y - 100, 2 * 100, 2 * 100);
                gr.DrawEllipse(animatedPen, pos.X - 200, pos.Y - 200, 2 * 200, 2 * 200);
                gr.DrawEllipse(animatedPen, pos.X, pos.Y, -200, 200);
            }

            gr.DrawLine(Pens.Black, this.Width * 3 / 4 + 5, this.Height / 4 + 5, this.Width / 4, this.Height * 3 / 4);

            // Подписи с анимированным размером шрифта
            gr.DrawString("x", font, Brushes.Black, xLabelLocation);
            gr.DrawString("y", font, Brushes.Black, centerX - 40, centerY - 430);
            gr.DrawString("0", font, Brushes.Black, centerX - 30, centerY - 40);
            gr.DrawString("1", font, Brushes.Black, centerX - 130, centerY - 40);
            gr.DrawString("2", font, Brushes.Black, centerX - 235, centerY);
            gr.DrawString("1", font, Brushes.Black, centerX, centerY + 100);
            gr.DrawString("2", font, Brushes.Black, centerX, centerY + 200);
            gr.DrawString("2", font, Brushes.Black, centerX + 200, centerY);
            gr.DrawString("2", font, Brushes.Black, centerX - 30, centerY - 240);

            gr.DrawLine(dashedPen, this.Width * 3 / 4 - 5, this.Height / 4 + 14, centerX - 5, centerY - 200);
            gr.DrawLine(dashedPen, this.Width * 3 / 4 - 5, this.Height / 4 + 14, centerX + 200, centerY);

            // Создаем и закрашиваем область
            filledRegion = new GraphicsPath();
            Rectangle bigCircle = new Rectangle(centerX - 200, centerY - 200, 400, 400);
            filledRegion.AddArc(bigCircle, 45, 90);

            filledRegion.AddLine(
                centerX + (int)(200 * Math.Cos(135 * Math.PI / 180)),
                centerY + (int)(200 * Math.Sin(135 * Math.PI / 180)),
                centerX, centerY);
            filledRegion.AddLine(centerX, centerY,
                centerX + (int)(200 * Math.Cos(45 * Math.PI / 180)),
                centerY + (int)(200 * Math.Sin(45 * Math.PI / 180)));

            // Закрашиваем область с анимированным цветом
            Color fillColor = isMouseOverRegion ?
                Color.FromArgb(128, Color.Red) :
                Color.FromArgb(128, currentAnimationColor);

            using (SolidBrush brush = new SolidBrush(fillColor))
            {
                gr.FillPath(brush, filledRegion);
            }

            // Освобождаем ресурсы
            font.Dispose();
            dashedPen.Dispose();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Останавливаем таймер при закрытии формы
            if (animationTimer != null)
            {
                animationTimer.Stop();
                animationTimer.Dispose();
            }
            base.OnFormClosed(e);
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverRegion = false;
            this.Invalidate();
        }
    }
}