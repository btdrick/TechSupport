
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
            this.displayOpenIncidentsTab = new System.Windows.Forms.TabPage();
            this.addIncidentTab = new System.Windows.Forms.TabPage();
            this.updateIncidentTab = new System.Windows.Forms.TabPage();
            this.viewIncidentsByTechnicianTab = new System.Windows.Forms.TabPage();
            this.usernameLogoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.assignedOpenIncidentsReportTab = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentsUserControl = new TechSupport.UserControls.DisplayOpenIncidentsUserControl();
            this.addIncidentUserControl = new TechSupport.UserControls.AddIncidentUserControl();
            this.updateIncidentUserControl1 = new TechSupport.UserControls.UpdateIncidentUserControl();
            this.viewIncidentsByTechnicianUserControl1 = new TechSupport.UserControls.ViewIncidentsByTechnicianUserControl();
            this.assignedOpenIncidentsReportUserControl = new TechSupport.UserControls.AssignedOpenIncidentsReportUserControl();
            this.mainTableLayoutPanel.SuspendLayout();
            this.techSupportDashboardTabControl.SuspendLayout();
            this.displayOpenIncidentsTab.SuspendLayout();
            this.addIncidentTab.SuspendLayout();
            this.updateIncidentTab.SuspendLayout();
            this.viewIncidentsByTechnicianTab.SuspendLayout();
            this.usernameLogoutPanel.SuspendLayout();
            this.assignedOpenIncidentsReportTab.SuspendLayout();
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
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(707, 624);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // techSupportDashboardTabControl
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.techSupportDashboardTabControl, 2);
            this.techSupportDashboardTabControl.Controls.Add(this.displayOpenIncidentsTab);
            this.techSupportDashboardTabControl.Controls.Add(this.addIncidentTab);
            this.techSupportDashboardTabControl.Controls.Add(this.updateIncidentTab);
            this.techSupportDashboardTabControl.Controls.Add(this.viewIncidentsByTechnicianTab);
            this.techSupportDashboardTabControl.Controls.Add(this.assignedOpenIncidentsReportTab);
            this.techSupportDashboardTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.techSupportDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techSupportDashboardTabControl.Location = new System.Drawing.Point(3, 33);
            this.techSupportDashboardTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.techSupportDashboardTabControl.Name = "techSupportDashboardTabControl";
            this.techSupportDashboardTabControl.SelectedIndex = 0;
            this.techSupportDashboardTabControl.Size = new System.Drawing.Size(701, 589);
            this.techSupportDashboardTabControl.TabIndex = 2;
            this.techSupportDashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.TechSupportDashboardTabControlSelectedIndexChanged);
            // 
            // displayOpenIncidentsTab
            // 
            this.displayOpenIncidentsTab.Controls.Add(this.displayOpenIncidentsUserControl);
            this.displayOpenIncidentsTab.Location = new System.Drawing.Point(4, 29);
            this.displayOpenIncidentsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayOpenIncidentsTab.Name = "displayOpenIncidentsTab";
            this.displayOpenIncidentsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayOpenIncidentsTab.Size = new System.Drawing.Size(693, 556);
            this.displayOpenIncidentsTab.TabIndex = 3;
            this.displayOpenIncidentsTab.Text = "Display Open Incidents";
            this.displayOpenIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // addIncidentTab
            // 
            this.addIncidentTab.Controls.Add(this.addIncidentUserControl);
            this.addIncidentTab.Location = new System.Drawing.Point(4, 29);
            this.addIncidentTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addIncidentTab.Name = "addIncidentTab";
            this.addIncidentTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addIncidentTab.Size = new System.Drawing.Size(693, 556);
            this.addIncidentTab.TabIndex = 0;
            this.addIncidentTab.Text = "Add";
            this.addIncidentTab.UseVisualStyleBackColor = true;
            // 
            // updateIncidentTab
            // 
            this.updateIncidentTab.Controls.Add(this.updateIncidentUserControl1);
            this.updateIncidentTab.Location = new System.Drawing.Point(4, 29);
            this.updateIncidentTab.Margin = new System.Windows.Forms.Padding(4);
            this.updateIncidentTab.Name = "updateIncidentTab";
            this.updateIncidentTab.Padding = new System.Windows.Forms.Padding(4);
            this.updateIncidentTab.Size = new System.Drawing.Size(693, 556);
            this.updateIncidentTab.TabIndex = 4;
            this.updateIncidentTab.Text = "Update";
            this.updateIncidentTab.UseVisualStyleBackColor = true;
            // 
            // viewIncidentsByTechnicianTab
            // 
            this.viewIncidentsByTechnicianTab.Controls.Add(this.viewIncidentsByTechnicianUserControl1);
            this.viewIncidentsByTechnicianTab.Location = new System.Drawing.Point(4, 29);
            this.viewIncidentsByTechnicianTab.Name = "viewIncidentsByTechnicianTab";
            this.viewIncidentsByTechnicianTab.Size = new System.Drawing.Size(693, 556);
            this.viewIncidentsByTechnicianTab.TabIndex = 5;
            this.viewIncidentsByTechnicianTab.Text = "View Incidents By Technician";
            this.viewIncidentsByTechnicianTab.UseVisualStyleBackColor = true;
            // 
            // usernameLogoutPanel
            // 
            this.usernameLogoutPanel.ColumnCount = 2;
            this.usernameLogoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.66667F));
            this.usernameLogoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.33333F));
            this.usernameLogoutPanel.Controls.Add(this.logoutLink, 1, 0);
            this.usernameLogoutPanel.Controls.Add(this.usernameLabel, 0, 0);
            this.usernameLogoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLogoutPanel.Location = new System.Drawing.Point(301, 2);
            this.usernameLogoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameLogoutPanel.Name = "usernameLogoutPanel";
            this.usernameLogoutPanel.RowCount = 1;
            this.usernameLogoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.usernameLogoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.usernameLogoutPanel.Size = new System.Drawing.Size(403, 27);
            this.usernameLogoutPanel.TabIndex = 3;
            // 
            // logoutLink
            // 
            this.logoutLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logoutLink.Location = new System.Drawing.Point(311, 1);
            this.logoutLink.Margin = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(72, 25);
            this.logoutLink.TabIndex = 0;
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
            this.usernameLabel.Location = new System.Drawing.Point(145, 1);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(99, 25);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assignedOpenIncidentsReportTab
            // 
            this.assignedOpenIncidentsReportTab.Controls.Add(this.assignedOpenIncidentsReportUserControl);
            this.assignedOpenIncidentsReportTab.Location = new System.Drawing.Point(4, 29);
            this.assignedOpenIncidentsReportTab.Name = "assignedOpenIncidentsReportTab";
            this.assignedOpenIncidentsReportTab.Size = new System.Drawing.Size(693, 556);
            this.assignedOpenIncidentsReportTab.TabIndex = 6;
            this.assignedOpenIncidentsReportTab.Text = "Report";
            this.assignedOpenIncidentsReportTab.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentsUserControl
            // 
            this.displayOpenIncidentsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayOpenIncidentsUserControl.Location = new System.Drawing.Point(3, 2);
            this.displayOpenIncidentsUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.displayOpenIncidentsUserControl.Name = "displayOpenIncidentsUserControl";
            this.displayOpenIncidentsUserControl.Size = new System.Drawing.Size(687, 552);
            this.displayOpenIncidentsUserControl.TabIndex = 0;
            // 
            // addIncidentUserControl
            // 
            this.addIncidentUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncidentUserControl.Location = new System.Drawing.Point(3, 2);
            this.addIncidentUserControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addIncidentUserControl.Name = "addIncidentUserControl";
            this.addIncidentUserControl.Size = new System.Drawing.Size(687, 552);
            this.addIncidentUserControl.TabIndex = 0;
            // 
            // updateIncidentUserControl1
            // 
            this.updateIncidentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateIncidentUserControl1.Location = new System.Drawing.Point(4, 4);
            this.updateIncidentUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.updateIncidentUserControl1.Name = "updateIncidentUserControl1";
            this.updateIncidentUserControl1.Size = new System.Drawing.Size(685, 548);
            this.updateIncidentUserControl1.TabIndex = 0;
            // 
            // viewIncidentsByTechnicianUserControl1
            // 
            this.viewIncidentsByTechnicianUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewIncidentsByTechnicianUserControl1.Location = new System.Drawing.Point(0, 0);
            this.viewIncidentsByTechnicianUserControl1.Name = "viewIncidentsByTechnicianUserControl1";
            this.viewIncidentsByTechnicianUserControl1.Size = new System.Drawing.Size(693, 556);
            this.viewIncidentsByTechnicianUserControl1.TabIndex = 0;
            // 
            // assignedOpenIncidentsReportUserControl
            // 
            this.assignedOpenIncidentsReportUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignedOpenIncidentsReportUserControl.Location = new System.Drawing.Point(0, 0);
            this.assignedOpenIncidentsReportUserControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assignedOpenIncidentsReportUserControl.Name = "assignedOpenIncidentsReportUserControl";
            this.assignedOpenIncidentsReportUserControl.Size = new System.Drawing.Size(693, 556);
            this.assignedOpenIncidentsReportUserControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 624);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Support";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosedEventHandle);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.techSupportDashboardTabControl.ResumeLayout(false);
            this.displayOpenIncidentsTab.ResumeLayout(false);
            this.addIncidentTab.ResumeLayout(false);
            this.updateIncidentTab.ResumeLayout(false);
            this.viewIncidentsByTechnicianTab.ResumeLayout(false);
            this.usernameLogoutPanel.ResumeLayout(false);
            this.usernameLogoutPanel.PerformLayout();
            this.assignedOpenIncidentsReportTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel usernameLogoutPanel;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TabControl techSupportDashboardTabControl;
        private System.Windows.Forms.TabPage addIncidentTab;
        private System.Windows.Forms.TabPage displayOpenIncidentsTab;
        private UserControls.DisplayOpenIncidentsUserControl displayOpenIncidentsUserControl;
        private UserControls.AddIncidentUserControl addIncidentUserControl;
        private System.Windows.Forms.TabPage updateIncidentTab;
        private UserControls.UpdateIncidentUserControl updateIncidentUserControl1;
        private System.Windows.Forms.TabPage viewIncidentsByTechnicianTab;
        private UserControls.ViewIncidentsByTechnicianUserControl viewIncidentsByTechnicianUserControl1;
        private System.Windows.Forms.TabPage assignedOpenIncidentsReportTab;
        private UserControls.AssignedOpenIncidentsReportUserControl assignedOpenIncidentsReportUserControl;
    }
}