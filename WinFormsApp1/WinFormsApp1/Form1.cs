namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DateTimeFormat dtFormat;
        ToolStripMenuItem currentCheckedItem;
        public Form1()
        {
            InitializeComponent();
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }


        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowTime)
            {
                info = DateTime.Now.ToLongTimeString();
            }
            else
            {
                info = DateTime.Now.ToLongDateString();

            }

            toolStripStatusLabelClock.Text = info;
        }

        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelState.Text = (e.X + ";" + e.Y).ToString();

        }

        public enum DateTimeFormat
        {
            ShowTime,
            ShowDate
        }


    }
}
