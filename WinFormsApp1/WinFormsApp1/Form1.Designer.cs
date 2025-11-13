namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtA = new TextBox();
            txtP = new TextBox();
            txtK = new TextBox();
            txtB = new TextBox();
            btnChooseColor = new Button();
            comboMode = new ComboBox();
            panelGraf = new Panel();
            btnRedraw = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxChooseEquation = new ComboBox();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(60, 109);
            txtA.Name = "txtA";
            txtA.Size = new Size(79, 31);
            txtA.TabIndex = 0;
            txtA.Tag = "";
            // 
            // txtP
            // 
            txtP.Location = new Point(199, 109);
            txtP.Name = "txtP";
            txtP.Size = new Size(79, 31);
            txtP.TabIndex = 1;
            // 
            // txtK
            // 
            txtK.Location = new Point(60, 146);
            txtK.Name = "txtK";
            txtK.Size = new Size(79, 31);
            txtK.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(199, 146);
            txtB.Name = "txtB";
            txtB.Size = new Size(79, 31);
            txtB.TabIndex = 3;
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(484, 106);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(112, 34);
            btnChooseColor.TabIndex = 4;
            btnChooseColor.Text = "...";
            btnChooseColor.UseVisualStyleBackColor = true;
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // comboMode
            // 
            comboMode.FormattingEnabled = true;
            comboMode.Items.AddRange(new object[] { "Линия", "Точки" });
            comboMode.Location = new Point(484, 146);
            comboMode.Name = "comboMode";
            comboMode.Size = new Size(209, 33);
            comboMode.TabIndex = 5;
            comboMode.SelectedIndexChanged += comboMode_SelectedIndexChanged;
            // 
            // panelGraf
            // 
            panelGraf.Location = new Point(12, 217);
            panelGraf.Name = "panelGraf";
            panelGraf.Size = new Size(681, 658);
            panelGraf.TabIndex = 6;
            // 
            // btnRedraw
            // 
            btnRedraw.Location = new Point(343, 50);
            btnRedraw.Name = "btnRedraw";
            btnRedraw.Size = new Size(350, 34);
            btnRedraw.TabIndex = 7;
            btnRedraw.Text = "Перерисовать";
            btnRedraw.UseVisualStyleBackColor = true;
            btnRedraw.Click += btnRedraw_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 111);
            label1.Name = "label1";
            label1.Size = new Size(21, 25);
            label1.TabIndex = 8;
            label1.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 152);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 8;
            label2.Text = "p";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 115);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 8;
            label3.Text = "k";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 152);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 8;
            label4.Text = "b";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 108);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 8;
            label5.Text = "Цвет графика";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 149);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 8;
            label6.Text = "Режим вывода";
            // 
            // comboBoxChooseEquation
            // 
            comboBoxChooseEquation.FormattingEnabled = true;
            comboBoxChooseEquation.Items.AddRange(new object[] { "F = ax ^ (-p) * sin(kx + b)", "F = sin ^ 2x + sin(k*x) + p", "F = a*x ^ 3 - 1/p*k", "F = b*(x ^ 3 - 3) ^ k-p" });
            comboBoxChooseEquation.Location = new Point(12, 50);
            comboBoxChooseEquation.Name = "comboBoxChooseEquation";
            comboBoxChooseEquation.Size = new Size(266, 33);
            comboBoxChooseEquation.TabIndex = 9;
            comboBoxChooseEquation.SelectedIndexChanged += comboBoxChooseEquation_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 887);
            Controls.Add(comboBoxChooseEquation);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRedraw);
            Controls.Add(panelGraf);
            Controls.Add(comboMode);
            Controls.Add(btnChooseColor);
            Controls.Add(txtB);
            Controls.Add(txtK);
            Controls.Add(txtP);
            Controls.Add(txtA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtP;
        private TextBox txtK;
        private TextBox txtB;
        private Button btnChooseColor;
        private ComboBox comboMode;
        private Panel panelGraf;
        private Button btnRedraw;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxChooseEquation;
    }
}
