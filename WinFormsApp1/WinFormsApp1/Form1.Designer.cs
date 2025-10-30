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
            btnChooseColor = new Button();
            panelChooseColor = new Panel();
            btnChooseFont = new Button();
            txtChooseFont = new TextBox();
            btnChooseFile = new Button();
            txtChooseFile = new TextBox();
            btnChooseFolder = new Button();
            txtChooseFolder = new TextBox();
            SuspendLayout();
            // 
            // btnChooseColor
            // 
            btnChooseColor.BackColor = SystemColors.Control;
            btnChooseColor.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnChooseColor.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnChooseColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnChooseColor.FlatStyle = FlatStyle.Popup;
            btnChooseColor.Location = new Point(42, 37);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(151, 44);
            btnChooseColor.TabIndex = 0;
            btnChooseColor.Text = "Выбор цвета";
            btnChooseColor.UseVisualStyleBackColor = false;
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // panelChooseColor
            // 
            panelChooseColor.Location = new Point(209, 45);
            panelChooseColor.Name = "panelChooseColor";
            panelChooseColor.Size = new Size(533, 31);
            panelChooseColor.TabIndex = 1;
            // 
            // btnChooseFont
            // 
            btnChooseFont.BackColor = SystemColors.Control;
            btnChooseFont.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnChooseFont.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnChooseFont.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnChooseFont.FlatStyle = FlatStyle.Popup;
            btnChooseFont.Location = new Point(42, 104);
            btnChooseFont.Name = "btnChooseFont";
            btnChooseFont.Size = new Size(151, 44);
            btnChooseFont.TabIndex = 2;
            btnChooseFont.Text = "Выбор шрифта";
            btnChooseFont.UseVisualStyleBackColor = false;
            btnChooseFont.Click += btnChooseFont_Click;
            // 
            // txtChooseFont
            // 
            txtChooseFont.Location = new Point(213, 112);
            txtChooseFont.Name = "txtChooseFont";
            txtChooseFont.Size = new Size(529, 31);
            txtChooseFont.TabIndex = 3;
            txtChooseFont.Text = "Образец шрифта";
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = SystemColors.Control;
            btnChooseFile.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnChooseFile.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnChooseFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnChooseFile.FlatStyle = FlatStyle.Popup;
            btnChooseFile.Location = new Point(42, 217);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(151, 47);
            btnChooseFile.TabIndex = 4;
            btnChooseFile.Text = "Выбор файла";
            btnChooseFile.UseVisualStyleBackColor = false;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // txtChooseFile
            // 
            txtChooseFile.Location = new Point(209, 225);
            txtChooseFile.Name = "txtChooseFile";
            txtChooseFile.Size = new Size(533, 31);
            txtChooseFile.TabIndex = 5;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.BackColor = SystemColors.Control;
            btnChooseFolder.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnChooseFolder.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnChooseFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnChooseFolder.FlatStyle = FlatStyle.Popup;
            btnChooseFolder.Location = new Point(42, 300);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(151, 47);
            btnChooseFolder.TabIndex = 6;
            btnChooseFolder.Text = "Выбор каталога";
            btnChooseFolder.UseVisualStyleBackColor = false;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // txtChooseFolder
            // 
            txtChooseFolder.Location = new Point(209, 313);
            txtChooseFolder.Name = "txtChooseFolder";
            txtChooseFolder.Size = new Size(533, 31);
            txtChooseFolder.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtChooseFolder);
            Controls.Add(btnChooseFolder);
            Controls.Add(txtChooseFile);
            Controls.Add(btnChooseFile);
            Controls.Add(txtChooseFont);
            Controls.Add(btnChooseFont);
            Controls.Add(panelChooseColor);
            Controls.Add(btnChooseColor);
            Name = "Form1";
            Text = "Тестирование диалоговых окон";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChooseColor;
        private Panel panelChooseColor;
        private Button btnChooseFont;
        private TextBox txtChooseFont;
        private Button btnChooseFile;
        private TextBox txtChooseFile;
        private Button btnChooseFolder;
        private TextBox txtChooseFolder;
    }
}
