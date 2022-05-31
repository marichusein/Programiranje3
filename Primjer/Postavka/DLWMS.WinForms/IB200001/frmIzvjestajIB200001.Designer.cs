namespace DLWMS.WinForms.IB200001
{
    partial class frmIzvjestajIB200001
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.DataSetIB200001xsd = new DLWMS.WinForms.IB200001.DataSetIB200001xsd();
            this.SkeniraniIspitiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetIB200001xsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkeniraniIspitiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SkeniraniIspitiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DLWMS.WinForms.IB200001.ReportIB200001.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // DataSetIB200001xsd
            // 
            this.DataSetIB200001xsd.DataSetName = "DataSetIB200001xsd";
            this.DataSetIB200001xsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SkeniraniIspitiBindingSource
            // 
            this.SkeniraniIspitiBindingSource.DataMember = "SkeniraniIspiti";
            this.SkeniraniIspitiBindingSource.DataSource = this.DataSetIB200001xsd;
            // 
            // frmIzvjestajIB200001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvjestajIB200001";
            this.Text = "frmIzvjestajIB200001";
            this.Load += new System.EventHandler(this.FrmIzvjestajIB200001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetIB200001xsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkeniraniIspitiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.BindingSource SkeniraniIspitiBindingSource;
        private DataSetIB200001xsd DataSetIB200001xsd;
    }
}