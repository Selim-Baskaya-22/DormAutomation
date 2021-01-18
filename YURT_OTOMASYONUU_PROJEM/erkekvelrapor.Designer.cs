namespace YURT_OTOMASYONUU_PROJEM
{
    partial class erkekvelrapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(erkekvelrapor));
            this.erkekvelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_otomasyon_projemDataSet1 = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.erkekvelTableAdapter = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet1TableAdapters.erkekvelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.erkekvelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // erkekvelBindingSource
            // 
            this.erkekvelBindingSource.DataMember = "erkekvel";
            this.erkekvelBindingSource.DataSource = this.yurt_otomasyon_projemDataSet1;
            // 
            // yurt_otomasyon_projemDataSet1
            // 
            this.yurt_otomasyon_projemDataSet1.DataSetName = "yurt_otomasyon_projemDataSet1";
            this.yurt_otomasyon_projemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.erkekvelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YURT_OTOMASYONUU_PROJEM.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(657, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "sd.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageKey = "sd.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(606, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 95;
            this.button1.Text = "ÇIKIŞ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // erkekvelTableAdapter
            // 
            this.erkekvelTableAdapter.ClearBeforeFill = true;
            // 
            // erkekvelrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(681, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "erkekvelrapor";
            this.Text = "Erkek Veli Raporlama";
            this.Load += new System.EventHandler(this.erkekvelrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erkekvelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource erkekvelBindingSource;
        private yurt_otomasyon_projemDataSet1 yurt_otomasyon_projemDataSet1;
        private yurt_otomasyon_projemDataSet1TableAdapters.erkekvelTableAdapter erkekvelTableAdapter;
    }
}