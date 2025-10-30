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
            btnChooseFileWithData = new Button();
            txtChooseFileWithData = new TextBox();
            btnChooseFolderToSave = new Button();
            txtChooseFolderToSave = new TextBox();
            btnChooseFont = new Button();
            txtChooseFont = new TextBox();
            textBoxN = new TextBox();
            textBoxInputN = new TextBox();
            btnCalcU = new Button();
            btnCloseForm = new Button();
            txtResultU = new TextBox();
            SuspendLayout();
            // 
            // btnChooseFileWithData
            // 
            btnChooseFileWithData.Location = new Point(48, 36);
            btnChooseFileWithData.Name = "btnChooseFileWithData";
            btnChooseFileWithData.Size = new Size(254, 45);
            btnChooseFileWithData.TabIndex = 0;
            btnChooseFileWithData.Text = "Выбрать файл с данными";
            btnChooseFileWithData.UseVisualStyleBackColor = true;
            btnChooseFileWithData.Click += btnChooseFileWithData_Click;
            // 
            // txtChooseFileWithData
            // 
            txtChooseFileWithData.Location = new Point(354, 45);
            txtChooseFileWithData.Name = "txtChooseFileWithData";
            txtChooseFileWithData.Size = new Size(381, 31);
            txtChooseFileWithData.TabIndex = 1;
            // 
            // btnChooseFolderToSave
            // 
            btnChooseFolderToSave.Location = new Point(47, 106);
            btnChooseFolderToSave.Name = "btnChooseFolderToSave";
            btnChooseFolderToSave.Size = new Size(254, 45);
            btnChooseFolderToSave.TabIndex = 2;
            btnChooseFolderToSave.Text = "Сохранить в...";
            btnChooseFolderToSave.UseVisualStyleBackColor = true;
            btnChooseFolderToSave.Click += btnChooseFolderToSave_Click;
            // 
            // txtChooseFolderToSave
            // 
            txtChooseFolderToSave.Location = new Point(354, 113);
            txtChooseFolderToSave.Name = "txtChooseFolderToSave";
            txtChooseFolderToSave.Size = new Size(381, 31);
            txtChooseFolderToSave.TabIndex = 3;
            // 
            // btnChooseFont
            // 
            btnChooseFont.Location = new Point(48, 182);
            btnChooseFont.Name = "btnChooseFont";
            btnChooseFont.Size = new Size(254, 42);
            btnChooseFont.TabIndex = 4;
            btnChooseFont.Text = "Выбрать шрифт для формы";
            btnChooseFont.UseVisualStyleBackColor = true;
            btnChooseFont.Click += btnChooseFont_Click;
            // 
            // txtChooseFont
            // 
            txtChooseFont.Location = new Point(354, 189);
            txtChooseFont.Name = "txtChooseFont";
            txtChooseFont.Size = new Size(381, 31);
            txtChooseFont.TabIndex = 5;
            txtChooseFont.Text = "Образец шрифта ABZ";
            // 
            // textBoxN
            // 
            textBoxN.BackColor = SystemColors.Control;
            textBoxN.BorderStyle = BorderStyle.None;
            textBoxN.Font = new Font("Segoe UI", 15F);
            textBoxN.Location = new Point(49, 274);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(57, 40);
            textBoxN.TabIndex = 6;
            textBoxN.Text = "n = ";
            // 
            // textBoxInputN
            // 
            textBoxInputN.Location = new Point(111, 284);
            textBoxInputN.Name = "textBoxInputN";
            textBoxInputN.Size = new Size(190, 31);
            textBoxInputN.TabIndex = 7;
            textBoxInputN.TextChanged += textBoxInputN_TextChanged;
            // 
            // btnCalcU
            // 
            btnCalcU.Location = new Point(493, 393);
            btnCalcU.Name = "btnCalcU";
            btnCalcU.Size = new Size(112, 34);
            btnCalcU.TabIndex = 8;
            btnCalcU.Text = "В&ычислить\r\n";
            btnCalcU.UseVisualStyleBackColor = true;
            btnCalcU.Click += btnCalcU_Click;
            // 
            // btnCloseForm
            // 
            btnCloseForm.Location = new Point(623, 393);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(112, 34);
            btnCloseForm.TabIndex = 9;
            btnCloseForm.Text = "З&акрыть";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // txtResultU
            // 
            txtResultU.BackColor = SystemColors.Control;
            txtResultU.BorderStyle = BorderStyle.None;
            txtResultU.Location = new Point(354, 287);
            txtResultU.Name = "txtResultU";
            txtResultU.Size = new Size(381, 24);
            txtResultU.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultU);
            Controls.Add(btnCloseForm);
            Controls.Add(btnCalcU);
            Controls.Add(textBoxInputN);
            Controls.Add(textBoxN);
            Controls.Add(txtChooseFont);
            Controls.Add(btnChooseFont);
            Controls.Add(txtChooseFolderToSave);
            Controls.Add(btnChooseFolderToSave);
            Controls.Add(txtChooseFileWithData);
            Controls.Add(btnChooseFileWithData);
            Name = "Form1";
            Text = "Тестирование диалоговых окон";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChooseFileWithData;
        private TextBox txtChooseFileWithData;
        private Button btnChooseFolderToSave;
        private TextBox txtChooseFolderToSave;
        private Button btnChooseFont;
        private TextBox txtChooseFont;
        private TextBox textBoxN;
        private TextBox textBoxInputN;
        private Button btnCalcU;
        private Button btnCloseForm;
        private TextBox txtResultU;
    }
}
