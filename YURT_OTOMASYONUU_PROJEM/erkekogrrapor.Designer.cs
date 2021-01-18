namespace YURT_OTOMASYONUU_PROJEM
{
    partial class erkekogrrapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(erkekogrrapor));
            this.erkekogrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_otomasyon_projemDataSet = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.erkekogrTableAdapter = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSetTableAdapters.erkekogrTableAdapter();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erkekogrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // erkekogrBindingSource
            // 
            this.erkekogrBindingSource.DataMember = "erkekogr";
            this.erkekogrBindingSource.DataSource = this.yurt_otomasyon_projemDataSet;
            // 
            // yurt_otomasyon_projemDataSet
            // 
            this.yurt_otomasyon_projemDataSet.DataSetName = "yurt_otomasyon_projemDataSet";
            this.yurt_otomasyon_projemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.erkekogrBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YURT_OTOMASYONUU_PROJEM.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(908, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // erkekogrTableAdapter
            // 
            this.erkekogrTableAdapter.ClearBeforeFill = true;
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
            this.button2.Location = new System.Drawing.Point(857, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 82;
            this.button2.Text = "ÇIKIŞ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // erkekogrrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "erkekogrrapor";
            this.Text = "Erkek Öğrenci Raporlaması";
            this.Load += new System.EventHandler(this.erkekogrrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erkekogrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource erkekogrBindingSource;
        private yurt_otomasyon_projemDataSet yurt_otomasyon_projemDataSet;
        private yurt_otomasyon_projemDataSetTableAdapters.erkekogrTableAdapter erkekogrTableAdapter;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
    }
}