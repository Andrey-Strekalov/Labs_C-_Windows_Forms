namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ShowData(String datapath)
        {
            DataStorage data = new DataStorage();
            try
            {
                data = DataStorage.DataCreator(datapath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ѕри загрузке данных что-то сломалось");
            }

            dgvRaw.DataSource = data.GetRawData();
            dgvRaw.ReadOnly = true;
            dgvSummaryPurchase.DataSource = data.GetSummaryDataPurchase();
            dgvSummaryPurchase.ReadOnly = true;
            dgvSummarySale.DataSource = data.GetSummaryDataSale();
            dgvSummarySale.ReadOnly = true;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ShowData(dlg.FileName);
            }

        }
    }
}
