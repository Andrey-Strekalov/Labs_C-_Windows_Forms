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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainStatusStrip = new StatusStrip();
            toolStripStatusLabelState = new ToolStripStatusLabel();
            toolStripStatusLabelClock = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripMenuItemDate = new ToolStripMenuItem();
            toolStripMenuItemTime = new ToolStripMenuItem();
            timerDateTimeUpdate = new System.Windows.Forms.Timer(components);
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.ImageScalingSize = new Size(24, 24);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelState, toolStripStatusLabelClock, toolStripDropDownButton1 });
            MainStatusStrip.Location = new Point(0, 419);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(800, 31);
            MainStatusStrip.TabIndex = 0;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelState
            // 
            toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            toolStripStatusLabelState.Size = new Size(739, 24);
            toolStripStatusLabelState.Spring = true;
            toolStripStatusLabelState.TextAlign = ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabelClock
            // 
            toolStripStatusLabelClock.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            toolStripStatusLabelClock.Size = new Size(4, 24);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemDate, toolStripMenuItemTime });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(42, 28);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItemDate
            // 
            toolStripMenuItemDate.Name = "toolStripMenuItemDate";
            toolStripMenuItemDate.Size = new Size(240, 34);
            toolStripMenuItemDate.Text = "Текущая дата";
            toolStripMenuItemDate.Click += toolStripMenuItemDate_Click;
            // 
            // toolStripMenuItemTime
            // 
            toolStripMenuItemTime.Name = "toolStripMenuItemTime";
            toolStripMenuItemTime.Size = new Size(240, 34);
            toolStripMenuItemTime.Text = "Текущее время";
            toolStripMenuItemTime.Click += toolStripMenuItemTime_Click;
            // 
            // timerDateTimeUpdate
            // 
            timerDateTimeUpdate.Enabled = true;
            timerDateTimeUpdate.Interval = 1000;
            timerDateTimeUpdate.Tick += timerDateTimeUpdate_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainStatusStrip);
            Name = "Form1";
            Text = "Form1";
            MouseMove += Form1_MouseMove;
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel toolStripStatusLabelState;
        private ToolStripStatusLabel toolStripStatusLabelClock;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItemDate;
        private ToolStripMenuItem toolStripMenuItemTime;
        private System.Windows.Forms.Timer timerDateTimeUpdate;
    }
}
