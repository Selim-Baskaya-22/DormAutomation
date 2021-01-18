namespace YURT_OTOMASYONUU_PROJEM
{
    partial class Oda_Durumu_Raporla
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oda_Durumu_Raporla));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.yurt_otomasyon_projemDataSet10 = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet10();
            this.OdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OdaTableAdapter = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet10TableAdapters.OdaTableAdapter();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.OdaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YURT_OTOMASYONUU_PROJEM.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(574, 272);
            this.reportViewer1.TabIndex = 0;
            // 
            // yurt_otomasyon_projemDataSet10
            // 
            this.yurt_otomasyon_projemDataSet10.DataSetName = "yurt_otomasyon_projemDataSet10";
            this.yurt_otomasyon_projemDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OdaBindingSource
            // 
            this.OdaBindingSource.DataMember = "Oda";
            this.OdaBindingSource.DataSource = this.yurt_otomasyon_projemDataSet10;
            // 
            // OdaTableAdapter
            // 
            this.OdaTableAdapter.ClearBeforeFill = true;
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
            this.button1.Location = new System.Drawing.Point(524, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "ÇIKIŞ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Oda_Durumu_Raporla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(599, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Oda_Durumu_Raporla";
            this.Text = "Oda_Durumu_Raporla";
            this.Load += new System.EventHandler(this.Oda_Durumu_Raporla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OdaBindingSource;
        private yurt_otomasyon_projemDataSet10 yurt_otomasyon_projemDataSet10;
        private yurt_otomasyon_projemDataSet10TableAdapters.OdaTableAdapter OdaTableAdapter;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
    }
}