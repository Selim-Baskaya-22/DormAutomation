namespace YURT_OTOMASYONUU_PROJEM
{
    partial class kızvelrapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kızvelrapor));
            this.kızvelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_otomasyon_projemDataSet4 = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.kızvelTableAdapter = new YURT_OTOMASYONUU_PROJEM.yurt_otomasyon_projemDataSet4TableAdapters.kızvelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kızvelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // kızvelBindingSource
            // 
            this.kızvelBindingSource.DataMember = "kızvel";
            this.kızvelBindingSource.DataSource = this.yurt_otomasyon_projemDataSet4;
            // 
            // yurt_otomasyon_projemDataSet4
            // 
            this.yurt_otomasyon_projemDataSet4.DataSetName = "yurt_otomasyon_projemDataSet4";
            this.yurt_otomasyon_projemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.kızvelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YURT_OTOMASYONUU_PROJEM.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(740, 246);
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
            this.button2.Location = new System.Drawing.Point(689, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 70;
            this.button2.Text = "ÇIKIŞ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kızvelTableAdapter
            // 
            this.kızvelTableAdapter.ClearBeforeFill = true;
            // 
            // kızvelrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(764, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "kızvelrapor";
            this.Text = "Kız Veli Raporu";
            this.Load += new System.EventHandler(this.kızvelrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kızvelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_otomasyon_projemDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource kızvelBindingSource;
        private yurt_otomasyon_projemDataSet4 yurt_otomasyon_projemDataSet4;
        private yurt_otomasyon_projemDataSet4TableAdapters.kızvelTableAdapter kızvelTableAdapter;
    }
}