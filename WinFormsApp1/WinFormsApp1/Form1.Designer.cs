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
            components = new System.ComponentModel.Container();
            toolStripComboBoxY = new ToolStripComboBox();
            toolStripComboBoxZ = new ToolStripComboBox();
            toolStripTextBoxX = new ToolStripTextBox();
            toolStripTextBoxA = new ToolStripTextBox();
            toolStripTextBoxB = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            calcToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripComboBoxY
            // 
            toolStripComboBoxY.BackColor = SystemColors.Window;
            toolStripComboBoxY.Items.AddRange(new object[] { "30", "45", "60", "120", "180" });
            toolStripComboBoxY.Name = "toolStripComboBoxY";
            toolStripComboBoxY.Size = new Size(121, 33);
            toolStripComboBoxY.ToolTipText = "y";
            toolStripComboBoxY.SelectedIndexChanged += toolStripComboBoxA_SelectedIndexChanged;
            // 
            // toolStripComboBoxZ
            // 
            toolStripComboBoxZ.Items.AddRange(new object[] { "0,0001", "0,01", "0,1", "10", "100", "1000", "10000" });
            toolStripComboBoxZ.Name = "toolStripComboBoxZ";
            toolStripComboBoxZ.Size = new Size(121, 33);
            toolStripComboBoxZ.ToolTipText = "z";
            // 
            // toolStripTextBoxX
            // 
            toolStripTextBoxX.Name = "toolStripTextBoxX";
            toolStripTextBoxX.Size = new Size(100, 31);
            toolStripTextBoxX.ToolTipText = "X";
            // 
            // toolStripTextBoxA
            // 
            toolStripTextBoxA.Name = "toolStripTextBoxA";
            toolStripTextBoxA.Size = new Size(100, 31);
            toolStripTextBoxA.ToolTipText = "a";
            // 
            // toolStripTextBoxB
            // 
            toolStripTextBoxB.Name = "toolStripTextBoxB";
            toolStripTextBoxB.Size = new Size(100, 31);
            toolStripTextBoxB.ToolTipText = "b";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // calcToolStripMenuItem
            // 
            calcToolStripMenuItem.Name = "calcToolStripMenuItem";
            calcToolStripMenuItem.Size = new Size(181, 32);
            calcToolStripMenuItem.Text = "В&ычислить";
            calcToolStripMenuItem.Click += calcToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBoxY, toolStripComboBoxZ, toolStripTextBoxX, toolStripTextBoxA, toolStripTextBoxB, toolStripSeparator1, calcToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 225);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(828, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripSeparator2, closeToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "&Menu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(299, 34);
            toolStripMenuItem1.Text = "Вычислить выражение";
            toolStripMenuItem1.Click += calcToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(299, 34);
            toolStripMenuItem2.Text = "Очистить ввод";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(296, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(299, 34);
            closeToolStripMenuItem.Text = "В&ыход";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(828, 486);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(menuStrip1);
            Name = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();



            #endregion


        }
        private ToolStripComboBox toolStripComboBoxY;
        private ToolStripComboBox toolStripComboBoxZ;
        private ToolStripTextBox toolStripTextBoxX;
        private ToolStripTextBox toolStripTextBoxA;
        private ToolStripTextBox toolStripTextBoxB;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem calcToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}
