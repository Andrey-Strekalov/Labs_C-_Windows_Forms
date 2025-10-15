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
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            textBoxN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxW = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            eq1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBoxZoo = new TextBox();
            label7 = new Label();
            button1 = new Button();
            listBoxT = new ListBox();
            SuspendLayout();
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(80, 66);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(150, 31);
            textBoxX.TabIndex = 0;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(80, 122);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(150, 31);
            textBoxY.TabIndex = 1;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(80, 185);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(150, 31);
            textBoxN.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 72);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 3;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 128);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 4;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 188);
            label3.Name = "label3";
            label3.Size = new Size(25, 25);
            label3.TabIndex = 5;
            label3.Text = "N";
            // 
            // comboBoxW
            // 
            comboBoxW.FormattingEnabled = true;
            comboBoxW.Items.AddRange(new object[] { "0,05" });
            comboBoxW.Location = new Point(353, 66);
            comboBoxW.Name = "comboBoxW";
            comboBoxW.Size = new Size(182, 33);
            comboBoxW.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 69);
            label4.Name = "label4";
            label4.Size = new Size(29, 25);
            label4.TabIndex = 7;
            label4.Text = "W";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 122);
            label5.Name = "label5";
            label5.Size = new Size(21, 25);
            label5.TabIndex = 8;
            label5.Text = "T";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(588, 27);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 9;
            label6.Text = "Выбор уравнения";
            // 
            // eq1
            // 
            eq1.AutoSize = true;
            eq1.Location = new Point(598, 69);
            eq1.Name = "eq1";
            eq1.Size = new Size(140, 29);
            eq1.TabIndex = 11;
            eq1.TabStop = true;
            eq1.Text = "Уравнение 1";
            eq1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(598, 124);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(140, 29);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Уравнение 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxZoo
            // 
            textBoxZoo.Location = new Point(479, 356);
            textBoxZoo.Name = "textBoxZoo";
            textBoxZoo.Size = new Size(150, 31);
            textBoxZoo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(410, 357);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 14;
            label7.Text = "Zoo = ";
            // 
            // button1
            // 
            button1.Location = new Point(148, 359);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxT
            // 
            listBoxT.FormattingEnabled = true;
            listBoxT.ItemHeight = 25;
            listBoxT.Items.AddRange(new object[] { "0,001", "0,1", "10", "100", "1000", "10000" });
            listBoxT.Location = new Point(353, 122);
            listBoxT.Name = "listBoxT";
            listBoxT.Size = new Size(182, 154);
            listBoxT.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxT);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBoxZoo);
            Controls.Add(radioButton2);
            Controls.Add(eq1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxW);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxN);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX;
        private TextBox textBoxY;
        private TextBox textBoxN;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxW;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton eq1;
        private RadioButton radioButton2;
        private TextBox textBoxZoo;
        private Label label7;
        private Button button1;
        private ListBox listBoxT;
    }
}
