
namespace TechSupport.View
{
    partial class MainForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.techSupportDashboardTabControl = new System.Windows.Forms.TabControl();
            this.addIncidentTab = new System.Windows.Forms.TabPage();
            this.loadInternalIncidentsTab = new System.Windows.Forms.TabPage();
            this.searchIncidentsTab = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLogoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loadInternalIncidentsUserControl1 = new TechSupport.UserControls.LoadInternalIncidentsUserControl();
            this.searchIncidentUserControl1 = new TechSupport.UserControls.SearchIncidentUserControl();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.mainTableLayoutPanel.SuspendLayout();
            this.techSupportDashboardTabControl.SuspendLayout();
            this.addIncidentTab.SuspendLayout();
            this.loadInternalIncidentsTab.SuspendLayout();
            this.searchIncidentsTab.SuspendLayout();
            this.displayOpenIncidentsTab.SuspendLayout();
            this.usernameLogoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.23485F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.76515F));
            this.mainTableLayoutPanel.Controls.Add(this.techSupportDashboardTabControl, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.usernameLogoutPanel, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.41483F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.58517F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(430, 407);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // techSupportDashboardTabControl
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.techSupportDashboardTabControl, 2);
            this.techSupportDashboardTabControl.Controls.Add(this.addIncidentTab);
            this.techSupportDashboardTabControl.Controls.Add(this.loadInternalIncidentsTab);
            this.techSupportDashboardTabControl.Controls.Add(this.searchIncidentsTab);
            this.techSupportDashboardTabControl.Controls.Add(this.displayOpenIncidentsTab);
            this.techSupportDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techSupportDashboardTabControl.Location = new System.Drawing.Point(2, 32);
            this.techSupportDashboardTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.techSupportDashboardTabControl.Name = "techSupportDashboardTabControl";
            this.techSupportDashboardTabControl.SelectedIndex = 0;
            this.techSupportDashboardTabControl.Size = new System.Drawing.Size(426, 373);
            this.techSupportDashboardTabControl.TabIndex = 2;
            // 
            // addIncidentTab
            // 
            this.addIncidentTab.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTab.Location = new System.Drawing.Point(4, 25);
            this.addIncidentTab.Margin = new System.Windows.Forms.Padding(2);
            this.addIncidentTab.Name = "addIncidentTab";
            this.addIncidentTab.Padding = new System.Windows.Forms.Padding(2);
            this.addIncidentTab.Size = new System.Drawing.Size(418, 344);
            this.addIncidentTab.TabIndex = 0;
            this.addIncidentTab.Text = "Add";
            this.addIncidentTab.UseVisualStyleBackColor = true;
            // 
            // loadInternalIncidentsTab
            // 
            this.loadInternalIncidentsTab.Controls.Add(this.loadInternalIncidentsUserControl1);
            this.loadInternalIncidentsTab.Location = new System.Drawing.Point(4, 25);
            this.loadInternalIncidentsTab.Margin = new System.Windows.Forms.Padding(2);
            this.loadInternalIncidentsTab.Name = "loadInternalIncidentsTab";
            this.loadInternalIncidentsTab.Padding = new System.Windows.Forms.Padding(2);
            this.loadInternalIncidentsTab.Size = new System.Drawing.Size(418, 344);
            this.loadInternalIncidentsTab.TabIndex = 1;
            this.loadInternalIncidentsTab.Text = "Load Internal Incidents";
            this.loadInternalIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // searchIncidentsTab
            // 
            this.searchIncidentsTab.Controls.Add(this.searchIncidentUserControl1);
            this.searchIncidentsTab.Location = new System.Drawing.Point(4, 25);
            this.searchIncidentsTab.Margin = new System.Windows.Forms.Padding(2);
            this.searchIncidentsTab.Name = "searchIncidentsTab";
            this.searchIncidentsTab.Padding = new System.Windows.Forms.Padding(2);
            this.searchIncidentsTab.Size = new System.Drawing.Size(418, 344);
            this.searchIncidentsTab.TabIndex = 2;
            this.searchIncidentsTab.Text = "Search";
            this.searchIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentsTab
            // 
            this.displayOpenIncidentsTab.Controls.Add(this.tableLayoutPanel6);
            this.displayOpenIncidentsTab.Location = new System.Drawing.Point(4, 25);
            this.displayOpenIncidentsTab.Margin = new System.Windows.Forms.Padding(2);
            this.displayOpenIncidentsTab.Name = "displayOpenIncidentsTab";
            this.displayOpenIncidentsTab.Padding = new System.Windows.Forms.Padding(2);
            this.displayOpenIncidentsTab.Size = new System.Drawing.Size(418, 344);
            this.displayOpenIncidentsTab.TabIndex = 3;
            this.displayOpenIncidentsTab.Text = "Display Open Incidents";
            this.displayOpenIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(414, 340);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // usernameLogoutPanel
            // 
            this.usernameLogoutPanel.ColumnCount = 2;
            this.usernameLogoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.66667F));
            this.usernameLogoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.33333F));
            this.usernameLogoutPanel.Controls.Add(this.logoutLink, 1, 0);
            this.usernameLogoutPanel.Controls.Add(this.usernameLabel, 0, 0);
            this.usernameLogoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLogoutPanel.Location = new System.Drawing.Point(183, 2);
            this.usernameLogoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.usernameLogoutPanel.Name = "usernameLogoutPanel";
            this.usernameLogoutPanel.RowCount = 1;
            this.usernameLogoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.usernameLogoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.usernameLogoutPanel.Size = new System.Drawing.Size(245, 26);
            this.usernameLogoutPanel.TabIndex = 3;
            // 
            // logoutLink
            // 
            this.logoutLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logoutLink.Location = new System.Drawing.Point(171, 3);
            this.logoutLink.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(59, 20);
            this.logoutLink.TabIndex = 1;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutLink.UseMnemonic = false;
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkClickedEventHandle);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(68, 3);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(80, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadInternalIncidentsUserControl1
            // 
            this.loadInternalIncidentsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadInternalIncidentsUserControl1.Location = new System.Drawing.Point(2, 2);
            this.loadInternalIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadInternalIncidentsUserControl1.Name = "loadInternalIncidentsUserControl1";
            this.loadInternalIncidentsUserControl1.Size = new System.Drawing.Size(414, 340);
            this.loadInternalIncidentsUserControl1.TabIndex = 0;
            // 
            // searchIncidentUserControl1
            // 
            this.searchIncidentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchIncidentUserControl1.Location = new System.Drawing.Point(2, 2);
            this.searchIncidentUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchIncidentUserControl1.Name = "searchIncidentUserControl1";
            this.searchIncidentUserControl1.Size = new System.Drawing.Size(414, 340);
            this.searchIncidentUserControl1.TabIndex = 0;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncidentUserControl1.Location = new System.Drawing.Point(2, 2);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(414, 340);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 407);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Support";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosedEventHandle);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.techSupportDashboardTabControl.ResumeLayout(false);
            this.addIncidentTab.ResumeLayout(false);
            this.loadInternalIncidentsTab.ResumeLayout(false);
            this.searchIncidentsTab.ResumeLayout(false);
            this.displayOpenIncidentsTab.ResumeLayout(false);
            this.usernameLogoutPanel.ResumeLayout(false);
            this.usernameLogoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel usernameLogoutPanel;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TabControl techSupportDashboardTabControl;
        private System.Windows.Forms.TabPage addIncidentTab;
        private System.Windows.Forms.TabPage loadInternalIncidentsTab;
        private System.Windows.Forms.TabPage searchIncidentsTab;
        private UserControls.SearchIncidentUserControl searchIncidentUserControl1;
        private System.Windows.Forms.TabPage displayOpenIncidentsTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private UserControls.LoadInternalIncidentsUserControl loadInternalIncidentsUserControl1;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
    }
}