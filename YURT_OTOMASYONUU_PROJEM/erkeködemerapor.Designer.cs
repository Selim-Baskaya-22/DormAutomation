namespace YURT_OTOMASYONUU_PROJEM
{
    partial class erkeködemerapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(erkeködemerapor));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.yurt_otomasyon_projemDataSet7 = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet7();
            this.erkeködemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erkeködemeTableAdapter = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet7TableAdapters.erkeködemeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erkeködemeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.button2.Location = new System.Drawing.Point(477, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 70;
            this.button2.Text = "ÇIKIŞ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.erkeködemeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YURT_OTOMASYONUU_PROJEM.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(528, 246);
            this.reportViewer1.TabIndex = 71;
            // 
            // yurt_otomasyon_projemDataSet7
            // 
            this.yurt_otomasyon_projemDataSet7.DataSetName = "yurt_otomasyon_projemDataSet7";
            this.yurt_otomasyon_projemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // erkeködemeBindingSource
            // 
            this.erkeködemeBindingSource.DataMember = "erkeködeme";
            this.erkeködemeBindingSource.DataSource = this.yurt_otomasyon_projemDataSet7;
            // 
            // erkeködemeTableAdapter
            // 
            this.erkeködemeTableAdapter.ClearBeforeFill = true;
            // 
            // erkeködemerapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(552, 289);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Name = "erkeködemerapor";
            this.Text = "Erkek Ödeme Raporu";
            this.Load += new System.EventHandler(this.erkeködemerapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erkeködemeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource erkeködemeBindingSource;
        private yurt_otomasyon_projemDataSet7 yurt_otomasyon_projemDataSet7;
        private yurt_otomasyon_projemDataSet7TableAdapters.erkeködemeTableAdapter erkeködemeTableAdapter;
    }
}