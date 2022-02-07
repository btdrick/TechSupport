
namespace TechSupport.UserControls
{
    partial class DisplayOpenIncidentsUserControl
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
            this.openIncidentsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.openIncidentsListView = new System.Windows.Forms.ListView();
            this.productCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOpenedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technicianHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openIncidentsLabel = new System.Windows.Forms.Label();
            this.openIncidentsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openIncidentsTableLayoutPanel
            // 
            this.openIncidentsTableLayoutPanel.ColumnCount = 2;
            this.openIncidentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.openIncidentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.openIncidentsTableLayoutPanel.Controls.Add(this.openIncidentsLabel, 0, 0);
            this.openIncidentsTableLayoutPanel.Controls.Add(this.openIncidentsListView, 0, 1);
            this.openIncidentsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openIncidentsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.openIncidentsTableLayoutPanel.Name = "openIncidentsTableLayoutPanel";
            this.openIncidentsTableLayoutPanel.RowCount = 2;
            this.openIncidentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.94118F));
            this.openIncidentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.05882F));
            this.openIncidentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.openIncidentsTableLayoutPanel.Size = new System.Drawing.Size(514, 340);
            this.openIncidentsTableLayoutPanel.TabIndex = 0;
            // 
            // openIncidentsListView
            // 
            this.openIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCodeHeader,
            this.dateOpenedHeader,
            this.customerHeader,
            this.technicianHeader,
            this.titleHeader});
            this.openIncidentsTableLayoutPanel.SetColumnSpan(this.openIncidentsListView, 2);
            this.openIncidentsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openIncidentsListView.HideSelection = false;
            this.openIncidentsListView.Location = new System.Drawing.Point(3, 64);
            this.openIncidentsListView.Name = "openIncidentsListView";
            this.openIncidentsListView.Size = new System.Drawing.Size(508, 273);
            this.openIncidentsListView.TabIndex = 1;
            this.openIncidentsListView.UseCompatibleStateImageBehavior = false;
            this.openIncidentsListView.View = System.Windows.Forms.View.Details;
            // 
            // productCodeHeader
            // 
            this.productCodeHeader.Text = "Product Code";
            this.productCodeHeader.Width = 108;
            // 
            // dateOpenedHeader
            // 
            this.dateOpenedHeader.Text = "Date Opened";
            this.dateOpenedHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateOpenedHeader.Width = 96;
            // 
            // customerHeader
            // 
            this.customerHeader.Text = "Customer";
            this.customerHeader.Width = 77;
            // 
            // technicianHeader
            // 
            this.technicianHeader.Text = "Technician";
            this.technicianHeader.Width = 78;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 144;
            // 
            // openIncidentsLabel
            // 
            this.openIncidentsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openIncidentsLabel.AutoSize = true;
            this.openIncidentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.openIncidentsTableLayoutPanel.SetColumnSpan(this.openIncidentsLabel, 2);
            this.openIncidentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openIncidentsLabel.Location = new System.Drawing.Point(150, 14);
            this.openIncidentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.openIncidentsLabel.Name = "openIncidentsLabel";
            this.openIncidentsLabel.Size = new System.Drawing.Size(213, 33);
            this.openIncidentsLabel.TabIndex = 3;
            this.openIncidentsLabel.Text = "Open Incidents";
            // 
            // DisplayOpenIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openIncidentsTableLayoutPanel);
            this.Name = "DisplayOpenIncidentsUserControl";
            this.Size = new System.Drawing.Size(514, 340);
            this.openIncidentsTableLayoutPanel.ResumeLayout(false);
            this.openIncidentsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel openIncidentsTableLayoutPanel;
        private System.Windows.Forms.ListView openIncidentsListView;
        private System.Windows.Forms.ColumnHeader productCodeHeader;
        private System.Windows.Forms.ColumnHeader dateOpenedHeader;
        private System.Windows.Forms.ColumnHeader customerHeader;
        private System.Windows.Forms.ColumnHeader technicianHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.Label openIncidentsLabel;
    }
}
