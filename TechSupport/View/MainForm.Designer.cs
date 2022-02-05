
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
            this.addIncidentLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.submitButtonLayoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.addIncidentCancelButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addIncidentLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addIncidentConfirmationLabel = new System.Windows.Forms.Label();
            this.loadIncidentsTab = new System.Windows.Forms.TabPage();
            this.loadIncidentsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshIncidentsDataGridButton = new System.Windows.Forms.Button();
            this.searchIncidentsTab = new System.Windows.Forms.TabPage();
            this.searchLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchIncidentLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.searchIncidentButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchIncidentDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBoxLabel = new System.Windows.Forms.Label();
            this.searchCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.openIncidentsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLogoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.techSupportDashboardTabControl.SuspendLayout();
            this.addIncidentTab.SuspendLayout();
            this.addIncidentLayoutPanel.SuspendLayout();
            this.submitButtonLayoutPane.SuspendLayout();
            this.loadIncidentsTab.SuspendLayout();
            this.loadIncidentsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.searchIncidentsTab.SuspendLayout();
            this.searchLayoutPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIncidentDataGridView)).BeginInit();
            this.openIncidentsTab.SuspendLayout();
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
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.41483F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.58517F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(528, 499);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // techSupportDashboardTabControl
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.techSupportDashboardTabControl, 2);
            this.techSupportDashboardTabControl.Controls.Add(this.addIncidentTab);
            this.techSupportDashboardTabControl.Controls.Add(this.loadIncidentsTab);
            this.techSupportDashboardTabControl.Controls.Add(this.searchIncidentsTab);
            this.techSupportDashboardTabControl.Controls.Add(this.openIncidentsTab);
            this.techSupportDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techSupportDashboardTabControl.Location = new System.Drawing.Point(3, 40);
            this.techSupportDashboardTabControl.Name = "techSupportDashboardTabControl";
            this.techSupportDashboardTabControl.SelectedIndex = 0;
            this.techSupportDashboardTabControl.Size = new System.Drawing.Size(522, 456);
            this.techSupportDashboardTabControl.TabIndex = 2;
            // 
            // addIncidentTab
            // 
            this.addIncidentTab.Controls.Add(this.addIncidentLayoutPanel);
            this.addIncidentTab.Location = new System.Drawing.Point(4, 29);
            this.addIncidentTab.Name = "addIncidentTab";
            this.addIncidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTab.Size = new System.Drawing.Size(514, 423);
            this.addIncidentTab.TabIndex = 0;
            this.addIncidentTab.Text = "Add";
            this.addIncidentTab.UseVisualStyleBackColor = true;
            // 
            // addIncidentLayoutPanel
            // 
            this.addIncidentLayoutPanel.ColumnCount = 2;
            this.addIncidentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.4086F));
            this.addIncidentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.5914F));
            this.addIncidentLayoutPanel.Controls.Add(this.submitButtonLayoutPane, 0, 6);
            this.addIncidentLayoutPanel.Controls.Add(this.descriptionLabel, 0, 2);
            this.addIncidentLayoutPanel.Controls.Add(this.descriptionTextBox, 1, 2);
            this.addIncidentLayoutPanel.Controls.Add(this.addIncidentLabel, 0, 0);
            this.addIncidentLayoutPanel.Controls.Add(this.titleTextBox, 1, 1);
            this.addIncidentLayoutPanel.Controls.Add(this.customerIDTextBox, 1, 4);
            this.addIncidentLayoutPanel.Controls.Add(this.customerIDLabel, 0, 4);
            this.addIncidentLayoutPanel.Controls.Add(this.titleLabel, 0, 1);
            this.addIncidentLayoutPanel.Controls.Add(this.addIncidentConfirmationLabel, 0, 5);
            this.addIncidentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncidentLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.addIncidentLayoutPanel.Name = "addIncidentLayoutPanel";
            this.addIncidentLayoutPanel.RowCount = 7;
            this.addIncidentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addIncidentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.addIncidentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.addIncidentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.addIncidentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.addIncidentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.addIncidentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.addIncidentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addIncidentLayoutPanel.Size = new System.Drawing.Size(508, 417);
            this.addIncidentLayoutPanel.TabIndex = 1;
            // 
            // submitButtonLayoutPane
            // 
            this.submitButtonLayoutPane.ColumnCount = 2;
            this.addIncidentLayoutPanel.SetColumnSpan(this.submitButtonLayoutPane, 2);
            this.submitButtonLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitButtonLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitButtonLayoutPane.Controls.Add(this.addIncidentButton, 0, 0);
            this.submitButtonLayoutPane.Controls.Add(this.addIncidentCancelButton, 1, 0);
            this.submitButtonLayoutPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButtonLayoutPane.Location = new System.Drawing.Point(3, 355);
            this.submitButtonLayoutPane.Name = "submitButtonLayoutPane";
            this.submitButtonLayoutPane.RowCount = 1;
            this.submitButtonLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitButtonLayoutPane.Size = new System.Drawing.Size(502, 59);
            this.submitButtonLayoutPane.TabIndex = 7;
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentButton.Location = new System.Drawing.Point(63, 9);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(125, 40);
            this.addIncidentButton.TabIndex = 3;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.AddIncidentButtonClick);
            // 
            // addIncidentCancelButton
            // 
            this.addIncidentCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentCancelButton.Location = new System.Drawing.Point(314, 9);
            this.addIncidentCancelButton.Name = "addIncidentCancelButton";
            this.addIncidentCancelButton.Size = new System.Drawing.Size(125, 40);
            this.addIncidentCancelButton.TabIndex = 4;
            this.addIncidentCancelButton.Text = "Cancel";
            this.addIncidentCancelButton.UseVisualStyleBackColor = true;
            this.addIncidentCancelButton.Click += new System.EventHandler(this.AddIncidentCancelButtonClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(71, 149);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 20);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentLayoutPanel.SetColumnSpan(this.descriptionTextBox, 2);
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(64, 179);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(380, 99);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.AddIncidentTextFieldsChanged);
            // 
            // addIncidentLabel
            // 
            this.addIncidentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentLabel.AutoSize = true;
            this.addIncidentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addIncidentLayoutPanel.SetColumnSpan(this.addIncidentLabel, 2);
            this.addIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentLabel.Location = new System.Drawing.Point(84, 35);
            this.addIncidentLabel.Name = "addIncidentLabel";
            this.addIncidentLabel.Size = new System.Drawing.Size(339, 41);
            this.addIncidentLabel.TabIndex = 0;
            this.addIncidentLabel.Text = "Add Incident Report";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(177, 115);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(187, 26);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.AddIncidentTextFieldsChanged);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(177, 287);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(187, 26);
            this.customerIDTextBox.TabIndex = 2;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.AddIncidentTextFieldsChanged);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(62, 289);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(109, 20);
            this.customerIDLabel.TabIndex = 4;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(125, 118);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 20);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title:";
            // 
            // addIncidentConfirmationLabel
            // 
            this.addIncidentConfirmationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentConfirmationLabel.AutoSize = true;
            this.addIncidentLayoutPanel.SetColumnSpan(this.addIncidentConfirmationLabel, 2);
            this.addIncidentConfirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentConfirmationLabel.Location = new System.Drawing.Point(254, 321);
            this.addIncidentConfirmationLabel.Name = "addIncidentConfirmationLabel";
            this.addIncidentConfirmationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addIncidentConfirmationLabel.Size = new System.Drawing.Size(0, 25);
            this.addIncidentConfirmationLabel.TabIndex = 8;
            // 
            // loadIncidentsTab
            // 
            this.loadIncidentsTab.Controls.Add(this.loadIncidentsLayoutPanel);
            this.loadIncidentsTab.Location = new System.Drawing.Point(4, 29);
            this.loadIncidentsTab.Name = "loadIncidentsTab";
            this.loadIncidentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.loadIncidentsTab.Size = new System.Drawing.Size(514, 423);
            this.loadIncidentsTab.TabIndex = 1;
            this.loadIncidentsTab.Text = "Load";
            this.loadIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // loadIncidentsLayoutPanel
            // 
            this.loadIncidentsLayoutPanel.ColumnCount = 2;
            this.loadIncidentsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loadIncidentsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loadIncidentsLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.loadIncidentsLayoutPanel.Controls.Add(this.incidentDataGridView, 0, 1);
            this.loadIncidentsLayoutPanel.Controls.Add(this.refreshIncidentsDataGridButton, 0, 2);
            this.loadIncidentsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadIncidentsLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.loadIncidentsLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loadIncidentsLayoutPanel.Name = "loadIncidentsLayoutPanel";
            this.loadIncidentsLayoutPanel.RowCount = 3;
            this.loadIncidentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loadIncidentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.loadIncidentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.loadIncidentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.loadIncidentsLayoutPanel.Size = new System.Drawing.Size(508, 417);
            this.loadIncidentsLayoutPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loadIncidentsLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Incidents";
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AllowUserToDeleteRows = false;
            this.incidentDataGridView.AllowUserToResizeColumns = false;
            this.incidentDataGridView.AllowUserToResizeRows = false;
            this.incidentDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadIncidentsLayoutPanel.SetColumnSpan(this.incidentDataGridView, 2);
            this.incidentDataGridView.Location = new System.Drawing.Point(24, 104);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.ReadOnly = true;
            this.incidentDataGridView.RowHeadersWidth = 51;
            this.incidentDataGridView.RowTemplate.Height = 24;
            this.incidentDataGridView.Size = new System.Drawing.Size(460, 220);
            this.incidentDataGridView.TabIndex = 4;
            // 
            // refreshIncidentsDataGridButton
            // 
            this.refreshIncidentsDataGridButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadIncidentsLayoutPanel.SetColumnSpan(this.refreshIncidentsDataGridButton, 2);
            this.refreshIncidentsDataGridButton.Location = new System.Drawing.Point(191, 363);
            this.refreshIncidentsDataGridButton.Name = "refreshIncidentsDataGridButton";
            this.refreshIncidentsDataGridButton.Size = new System.Drawing.Size(125, 40);
            this.refreshIncidentsDataGridButton.TabIndex = 7;
            this.refreshIncidentsDataGridButton.Text = "Refresh";
            this.refreshIncidentsDataGridButton.UseVisualStyleBackColor = true;
            this.refreshIncidentsDataGridButton.Click += new System.EventHandler(this.RefreshIncidentsDataGridButtonClick);
            // 
            // searchIncidentsTab
            // 
            this.searchIncidentsTab.Controls.Add(this.searchLayoutPanel);
            this.searchIncidentsTab.Location = new System.Drawing.Point(4, 29);
            this.searchIncidentsTab.Name = "searchIncidentsTab";
            this.searchIncidentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchIncidentsTab.Size = new System.Drawing.Size(514, 423);
            this.searchIncidentsTab.TabIndex = 2;
            this.searchIncidentsTab.Text = "Search";
            this.searchIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // searchLayoutPanel
            // 
            this.searchLayoutPanel.ColumnCount = 2;
            this.searchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLayoutPanel.Controls.Add(this.searchIncidentLabel, 0, 0);
            this.searchLayoutPanel.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.searchLayoutPanel.Controls.Add(this.searchIncidentDataGridView, 0, 1);
            this.searchLayoutPanel.Controls.Add(this.searchTextBoxLabel, 0, 2);
            this.searchLayoutPanel.Controls.Add(this.searchCustomerIDTextBox, 1, 2);
            this.searchLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.searchLayoutPanel.Name = "searchLayoutPanel";
            this.searchLayoutPanel.RowCount = 4;
            this.searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.7561F));
            this.searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.2439F));
            this.searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.searchLayoutPanel.Size = new System.Drawing.Size(508, 417);
            this.searchLayoutPanel.TabIndex = 1;
            // 
            // searchIncidentLabel
            // 
            this.searchIncidentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchIncidentLabel.AutoSize = true;
            this.searchIncidentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchLayoutPanel.SetColumnSpan(this.searchIncidentLabel, 2);
            this.searchIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIncidentLabel.Location = new System.Drawing.Point(118, 24);
            this.searchIncidentLabel.Name = "searchIncidentLabel";
            this.searchIncidentLabel.Size = new System.Drawing.Size(271, 41);
            this.searchIncidentLabel.TabIndex = 2;
            this.searchIncidentLabel.Text = "Incident Search";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.searchLayoutPanel.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.searchIncidentButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.clearSearchButton, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 352);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(502, 62);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // searchIncidentButton
            // 
            this.searchIncidentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchIncidentButton.Location = new System.Drawing.Point(63, 11);
            this.searchIncidentButton.Name = "searchIncidentButton";
            this.searchIncidentButton.Size = new System.Drawing.Size(125, 40);
            this.searchIncidentButton.TabIndex = 4;
            this.searchIncidentButton.Text = "Search";
            this.searchIncidentButton.UseVisualStyleBackColor = true;
            this.searchIncidentButton.Click += new System.EventHandler(this.SearchIncidentButtonClick);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearSearchButton.Location = new System.Drawing.Point(314, 11);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(125, 40);
            this.clearSearchButton.TabIndex = 5;
            this.clearSearchButton.Text = "Clear";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.ClearSearchButtonClicked);
            // 
            // searchIncidentDataGridView
            // 
            this.searchIncidentDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchIncidentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchIncidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchLayoutPanel.SetColumnSpan(this.searchIncidentDataGridView, 2);
            this.searchIncidentDataGridView.Location = new System.Drawing.Point(15, 105);
            this.searchIncidentDataGridView.Name = "searchIncidentDataGridView";
            this.searchIncidentDataGridView.RowHeadersWidth = 51;
            this.searchIncidentDataGridView.RowTemplate.Height = 24;
            this.searchIncidentDataGridView.Size = new System.Drawing.Size(478, 184);
            this.searchIncidentDataGridView.TabIndex = 1;
            // 
            // searchTextBoxLabel
            // 
            this.searchTextBoxLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchTextBoxLabel.AutoSize = true;
            this.searchTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBoxLabel.Location = new System.Drawing.Point(55, 316);
            this.searchTextBoxLabel.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.searchTextBoxLabel.Name = "searchTextBoxLabel";
            this.searchTextBoxLabel.Size = new System.Drawing.Size(189, 20);
            this.searchTextBoxLabel.TabIndex = 3;
            this.searchTextBoxLabel.Text = "Search by Customer ID:";
            // 
            // searchCustomerIDTextBox
            // 
            this.searchCustomerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchCustomerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerIDTextBox.Location = new System.Drawing.Point(264, 313);
            this.searchCustomerIDTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.searchCustomerIDTextBox.Name = "searchCustomerIDTextBox";
            this.searchCustomerIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.searchCustomerIDTextBox.TabIndex = 4;
            this.searchCustomerIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openIncidentsTab
            // 
            this.openIncidentsTab.Controls.Add(this.tableLayoutPanel6);
            this.openIncidentsTab.Location = new System.Drawing.Point(4, 29);
            this.openIncidentsTab.Name = "openIncidentsTab";
            this.openIncidentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.openIncidentsTab.Size = new System.Drawing.Size(514, 423);
            this.openIncidentsTab.TabIndex = 3;
            this.openIncidentsTab.Text = "Open Incidents";
            this.openIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(508, 417);
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
            this.usernameLogoutPanel.Location = new System.Drawing.Point(226, 3);
            this.usernameLogoutPanel.Name = "usernameLogoutPanel";
            this.usernameLogoutPanel.RowCount = 1;
            this.usernameLogoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.usernameLogoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.usernameLogoutPanel.Size = new System.Drawing.Size(299, 31);
            this.usernameLogoutPanel.TabIndex = 3;
            // 
            // logoutLink
            // 
            this.logoutLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logoutLink.Location = new System.Drawing.Point(207, 3);
            this.logoutLink.Margin = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(72, 25);
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
            this.usernameLabel.Location = new System.Drawing.Point(82, 3);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(99, 25);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 499);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Support";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosedEventHandle);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.techSupportDashboardTabControl.ResumeLayout(false);
            this.addIncidentTab.ResumeLayout(false);
            this.addIncidentLayoutPanel.ResumeLayout(false);
            this.addIncidentLayoutPanel.PerformLayout();
            this.submitButtonLayoutPane.ResumeLayout(false);
            this.loadIncidentsTab.ResumeLayout(false);
            this.loadIncidentsLayoutPanel.ResumeLayout(false);
            this.loadIncidentsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.searchIncidentsTab.ResumeLayout(false);
            this.searchLayoutPanel.ResumeLayout(false);
            this.searchLayoutPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchIncidentDataGridView)).EndInit();
            this.openIncidentsTab.ResumeLayout(false);
            this.usernameLogoutPanel.ResumeLayout(false);
            this.usernameLogoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TabControl techSupportDashboardTabControl;
        private System.Windows.Forms.TabPage addIncidentTab;
        private System.Windows.Forms.TableLayoutPanel addIncidentLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel submitButtonLayoutPane;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button addIncidentCancelButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label addIncidentLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addIncidentConfirmationLabel;
        private System.Windows.Forms.TabPage loadIncidentsTab;
        private System.Windows.Forms.TableLayoutPanel loadIncidentsLayoutPanel;
        private System.Windows.Forms.DataGridView incidentDataGridView;
        private System.Windows.Forms.TabPage searchIncidentsTab;
        private System.Windows.Forms.TableLayoutPanel searchLayoutPanel;
        private System.Windows.Forms.Label searchIncidentLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button searchIncidentButton;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.DataGridView searchIncidentDataGridView;
        private System.Windows.Forms.Label searchTextBoxLabel;
        private System.Windows.Forms.TextBox searchCustomerIDTextBox;
        private System.Windows.Forms.TabPage openIncidentsTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel usernameLogoutPanel;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshIncidentsDataGridButton;
    }
}