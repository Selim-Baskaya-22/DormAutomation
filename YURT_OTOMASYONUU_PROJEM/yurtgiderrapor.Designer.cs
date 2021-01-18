namespace YURT_OTOMASYONUU_PROJEM
{
    partial class yurtgiderrapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yurtgiderrapor));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.yurt_otomasyon_projemDataSet9 = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet9();
            this.giderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giderTableAdapter = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet9TableAdapters.giderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.giderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YURT_OTOMASYONUU_PROJEM.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(801, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "sd.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageKey = "sd.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(750, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 82;
            this.button2.Text = "ÇIKIŞ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yurt_otomasyon_projemDataSet9
            // 
            this.yurt_otomasyon_projemDataSet9.DataSetName = "yurt_otomasyon_projemDataSet9";
            this.yurt_otomasyon_projemDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderBindingSource
            // 
            this.giderBindingSource.DataMember = "gider";
            this.giderBindingSource.DataSource = this.yurt_otomasyon_projemDataSet9;
            // 
            // giderTableAdapter
            // 
            this.giderTableAdapter.ClearBeforeFill = true;
            // 
            // yurtgiderrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(825, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "yurtgiderrapor";
            this.Text = "Yurt Gider Raporu";
            this.Load += new System.EventHandler(this.yurtgiderrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.BindingSource giderBindingSource;
        private yurt_otomasyon_projemDataSet9 yurt_otomasyon_projemDataSet9;
        private System.Windows.Forms.Button button2;
        private yurt_otomasyon_projemDataSet9TableAdapters.giderTableAdapter giderTableAdapter;
    }
}