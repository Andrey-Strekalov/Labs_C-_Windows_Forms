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
            textBoxN = new TextBox();
            textBoxZ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxP = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            eq1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBoxResult = new TextBox();
            label7 = new Label();
            button1 = new Button();
            comboBoxA = new ComboBox();
            comboBoxB = new ComboBox();
            label5 = new Label();
            label8 = new Label();
            listBoxR = new ListBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(41, 6);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(150, 31);
            textBoxX.TabIndex = 0;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(41, 49);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(150, 31);
            textBoxN.TabIndex = 1;
            // 
            // textBoxZ
            // 
            textBoxZ.Location = new Point(41, 92);
            textBoxZ.Name = "textBoxZ";
            textBoxZ.Size = new Size(150, 31);
            textBoxZ.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 3;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 4;
            label2.Text = "Z";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 49);
            label3.Name = "label3";
            label3.Size = new Size(25, 25);
            label3.TabIndex = 5;
            label3.Text = "N";
            // 
            // comboBoxP
            // 
            comboBoxP.FormattingEnabled = true;
            comboBoxP.Items.AddRange(new object[] { "0,1", "0,5", "1,0", "2,0", "5,0" });
            comboBoxP.Location = new Point(308, 4);
            comboBoxP.Name = "comboBoxP";
            comboBoxP.Size = new Size(182, 33);
            comboBoxP.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 9);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 7;
            label4.Text = "P";
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
            eq1.Appearance = Appearance.Button;
            eq1.AutoSize = true;
            eq1.Location = new Point(598, 69);
            eq1.Name = "eq1";
            eq1.Size = new Size(125, 35);
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
            // textBoxResult
            // 
            textBoxResult.Location = new Point(553, 326);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(150, 31);
            textBoxResult.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(490, 332);
            label7.Name = "label7";
            label7.Size = new Size(39, 25);
            label7.TabIndex = 14;
            label7.Text = "Z =";
            // 
            // button1
            // 
            button1.Location = new Point(163, 368);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxA
            // 
            comboBoxA.FormattingEnabled = true;
            comboBoxA.Items.AddRange(new object[] { "0,1", "0,5", "1,0", "2,0", "5,0" });
            comboBoxA.Location = new Point(310, 49);
            comboBoxA.Name = "comboBoxA";
            comboBoxA.Size = new Size(182, 33);
            comboBoxA.TabIndex = 16;
            // 
            // comboBoxB
            // 
            comboBoxB.FormattingEnabled = true;
            comboBoxB.Items.AddRange(new object[] { "0,1", "0,5", "1,0", "2,0", "5,0" });
            comboBoxB.Location = new Point(308, 92);
            comboBoxB.Name = "comboBoxB";
            comboBoxB.Size = new Size(182, 33);
            comboBoxB.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 52);
            label5.Name = "label5";
            label5.Size = new Size(24, 25);
            label5.TabIndex = 18;
            label5.Text = "A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(271, 98);
            label8.Name = "label8";
            label8.Size = new Size(22, 25);
            label8.TabIndex = 19;
            label8.Text = "B";
            // 
            // listBoxR
            // 
            listBoxR.FormattingEnabled = true;
            listBoxR.ItemHeight = 25;
            listBoxR.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50" });
            listBoxR.Location = new Point(41, 154);
            listBoxR.Name = "listBoxR";
            listBoxR.Size = new Size(180, 129);
            listBoxR.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 206);
            label9.Name = "label9";
            label9.Size = new Size(23, 25);
            label9.TabIndex = 21;
            label9.Text = "R";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 463);
            Controls.Add(label9);
            Controls.Add(listBoxR);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(comboBoxB);
            Controls.Add(comboBoxA);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBoxResult);
            Controls.Add(radioButton2);
            Controls.Add(eq1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(comboBoxP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxZ);
            Controls.Add(textBoxN);
            Controls.Add(textBoxX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX;
        private TextBox textBoxN;
        private TextBox textBoxZ;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxP;
        private Label label4;
        private Label label6;
        private RadioButton eq1;
        private RadioButton radioButton2;
        private TextBox textBoxResult;
        private Label label7;
        private Button button1;
        private ComboBox comboBoxA;
        private ComboBox comboBoxB;
        private Label label5;
        private Label label8;
        private ListBox listBoxR;
        private Label label9;
    }
}
