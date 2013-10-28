namespace ViewMain
{
    partial class ReportForm
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
            this.BMS_BookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookMSDataSet = new ViewMain.BookMSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BMS_BookTableAdapter = new ViewMain.BookMSDataSetTableAdapters.BMS_BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BMS_BookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BMS_BookBindingSource
            // 
            this.BMS_BookBindingSource.DataMember = "BMS_Book";
            this.BMS_BookBindingSource.DataSource = this.BookMSDataSet;
            // 
            // BookMSDataSet
            // 
            this.BookMSDataSet.DataSetName = "BookMSDataSet";
            this.BookMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BookMSDataSet_BMS_Book";
            reportDataSource1.Value = this.BMS_BookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ViewMain.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(872, 393);
            this.reportViewer1.TabIndex = 0;
            // 
            // BMS_BookTableAdapter
            // 
            this.BMS_BookTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 393);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BMS_BookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BMS_BookBindingSource;
        private BookMSDataSet BookMSDataSet;
        private ViewMain.BookMSDataSetTableAdapters.BMS_BookTableAdapter BMS_BookTableAdapter;
    }
}