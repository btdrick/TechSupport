
namespace TechSupport.UserControls
{
    partial class AssignedOpenIncidentsReportUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.assignedOpenIncidentsReportTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.assignedOpenIncidentsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.techSupportDataSet = new TechSupport.TechSupportDataSet();
            this.assignedOpenIncidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignedOpenIncidentsTableAdapter = new TechSupport.TechSupportDataSetTableAdapters.AssignedOpenIncidentsTableAdapter();
            this.assignedOpenIncidentsReportTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedOpenIncidentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assignedOpenIncidentsReportTableLayoutPanel
            // 
            this.assignedOpenIncidentsReportTableLayoutPanel.ColumnCount = 1;
            this.assignedOpenIncidentsReportTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.assignedOpenIncidentsReportTableLayoutPanel.Controls.Add(this.assignedOpenIncidentsReportViewer, 0, 0);
            this.assignedOpenIncidentsReportTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignedOpenIncidentsReportTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.assignedOpenIncidentsReportTableLayoutPanel.Name = "assignedOpenIncidentsReportTableLayoutPanel";
            this.assignedOpenIncidentsReportTableLayoutPanel.RowCount = 1;
            this.assignedOpenIncidentsReportTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.assignedOpenIncidentsReportTableLayoutPanel.Size = new System.Drawing.Size(650, 450);
            this.assignedOpenIncidentsReportTableLayoutPanel.TabIndex = 0;
            // 
            // assignedOpenIncidentsReportViewer
            // 
            this.assignedOpenIncidentsReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AssignedOpenIncidentsDataSet";
            reportDataSource1.Value = this.assignedOpenIncidentsBindingSource;
            this.assignedOpenIncidentsReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.assignedOpenIncidentsReportViewer.LocalReport.ReportEmbeddedResource = "TechSupport.Reports.AssignedOpenIncidentsReport.rdlc";
            this.assignedOpenIncidentsReportViewer.Location = new System.Drawing.Point(3, 3);
            this.assignedOpenIncidentsReportViewer.Name = "assignedOpenIncidentsReportViewer";
            this.assignedOpenIncidentsReportViewer.ServerReport.BearerToken = null;
            this.assignedOpenIncidentsReportViewer.Size = new System.Drawing.Size(644, 444);
            this.assignedOpenIncidentsReportViewer.TabIndex = 0;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignedOpenIncidentsBindingSource
            // 
            this.assignedOpenIncidentsBindingSource.DataMember = "AssignedOpenIncidents";
            this.assignedOpenIncidentsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // assignedOpenIncidentsTableAdapter
            // 
            this.assignedOpenIncidentsTableAdapter.ClearBeforeFill = true;
            // 
            // AssignedOpenIncidentsReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignedOpenIncidentsReportTableLayoutPanel);
            this.Name = "AssignedOpenIncidentsReportUserControl";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.AssignedOpenIncidentsReportUserControlLoad);
            this.assignedOpenIncidentsReportTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedOpenIncidentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel assignedOpenIncidentsReportTableLayoutPanel;
        private Microsoft.Reporting.WinForms.ReportViewer assignedOpenIncidentsReportViewer;
        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource assignedOpenIncidentsBindingSource;
        private TechSupportDataSetTableAdapters.AssignedOpenIncidentsTableAdapter assignedOpenIncidentsTableAdapter;
    }
}
