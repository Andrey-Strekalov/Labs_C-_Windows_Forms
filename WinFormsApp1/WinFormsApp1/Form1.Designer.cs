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
            dgvRaw = new DataGridView();
            dgvSummaryPurchase = new DataGridView();
            btnLoad = new Button();
            dgvSummarySale = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRaw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSummaryPurchase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSummarySale).BeginInit();
            SuspendLayout();
            // 
            // dgvRaw
            // 
            dgvRaw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaw.Location = new Point(12, 12);
            dgvRaw.Name = "dgvRaw";
            dgvRaw.RowHeadersWidth = 62;
            dgvRaw.Size = new Size(1029, 221);
            dgvRaw.TabIndex = 0;
            // 
            // dgvSummaryPurchase
            // 
            dgvSummaryPurchase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSummaryPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSummaryPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummaryPurchase.Location = new Point(12, 351);
            dgvSummaryPurchase.Name = "dgvSummaryPurchase";
            dgvSummaryPurchase.RowHeadersWidth = 62;
            dgvSummaryPurchase.Size = new Size(1029, 106);
            dgvSummaryPurchase.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 491);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(195, 34);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Загрузить данные";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvSummarySale
            // 
            dgvSummarySale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSummarySale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSummarySale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummarySale.Location = new Point(12, 239);
            dgvSummarySale.Name = "dgvSummarySale";
            dgvSummarySale.RowHeadersWidth = 62;
            dgvSummarySale.Size = new Size(1029, 106);
            dgvSummarySale.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 537);
            Controls.Add(dgvSummarySale);
            Controls.Add(btnLoad);
            Controls.Add(dgvSummaryPurchase);
            Controls.Add(dgvRaw);
            Name = "Form1";
            Text = "Загрузка данных";
            ((System.ComponentModel.ISupportInitialize)dgvRaw).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSummaryPurchase).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSummarySale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRaw;
        private DataGridView dgvSummaryPurchase;
        private Button btnLoad;
        private DataGridView dgvSummarySale;
    }
}
