
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
            this.reportTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // reportTableLayoutPanel
            // 
            this.reportTableLayoutPanel.ColumnCount = 1;
            this.reportTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reportTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.reportTableLayoutPanel.Name = "reportTableLayoutPanel";
            this.reportTableLayoutPanel.RowCount = 1;
            this.reportTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reportTableLayoutPanel.Size = new System.Drawing.Size(650, 450);
            this.reportTableLayoutPanel.TabIndex = 0;
            // 
            // AssignedOpenIncidentsReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportTableLayoutPanel);
            this.Name = "AssignedOpenIncidentsReportUserControl";
            this.Size = new System.Drawing.Size(650, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel reportTableLayoutPanel;
    }
}
