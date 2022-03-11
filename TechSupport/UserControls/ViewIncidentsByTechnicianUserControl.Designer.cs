
namespace TechSupport.UserControls
{
    partial class ViewIncidentsByTechnicianUserControl
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOpened = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technicianOpenIncidentsLabel = new System.Windows.Forms.Label();
            this.technicianFieldsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            this.technicianFieldsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(63, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(59, 111);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(66, 62);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 4;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTableLayoutPanel.Controls.Add(this.incidentDataGridView, 1, 4);
            this.mainTableLayoutPanel.Controls.Add(this.technicianOpenIncidentsLabel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.technicianFieldsTableLayoutPanel, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(650, 500);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AllowUserToDeleteRows = false;
            this.incidentDataGridView.AutoGenerateColumns = false;
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.dateOpened,
            this.customerName,
            this.incidentTitle});
            this.mainTableLayoutPanel.SetColumnSpan(this.incidentDataGridView, 2);
            this.incidentDataGridView.DataSource = this.incidentBindingSource;
            this.incidentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incidentDataGridView.Location = new System.Drawing.Point(35, 228);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.ReadOnly = true;
            this.incidentDataGridView.RowHeadersWidth = 51;
            this.incidentDataGridView.RowTemplate.Height = 24;
            this.incidentDataGridView.Size = new System.Drawing.Size(578, 269);
            this.incidentDataGridView.TabIndex = 4;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "Product";
            this.productName.HeaderText = "Product";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 125;
            // 
            // dateOpened
            // 
            this.dateOpened.DataPropertyName = "DateOpened";
            this.dateOpened.HeaderText = "DateOpened";
            this.dateOpened.MinimumWidth = 6;
            this.dateOpened.Name = "dateOpened";
            this.dateOpened.ReadOnly = true;
            this.dateOpened.Width = 125;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "Customer";
            this.customerName.HeaderText = "Customer";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 125;
            // 
            // incidentTitle
            // 
            this.incidentTitle.DataPropertyName = "Title";
            this.incidentTitle.HeaderText = "Title";
            this.incidentTitle.MinimumWidth = 6;
            this.incidentTitle.Name = "incidentTitle";
            this.incidentTitle.ReadOnly = true;
            this.incidentTitle.Width = 125;
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataSource = typeof(TechSupport.Model.Incident);
            // 
            // technicianOpenIncidentsLabel
            // 
            this.technicianOpenIncidentsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.technicianOpenIncidentsLabel.AutoSize = true;
            this.technicianOpenIncidentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainTableLayoutPanel.SetColumnSpan(this.technicianOpenIncidentsLabel, 2);
            this.technicianOpenIncidentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianOpenIncidentsLabel.Location = new System.Drawing.Point(100, 17);
            this.technicianOpenIncidentsLabel.Name = "technicianOpenIncidentsLabel";
            this.technicianOpenIncidentsLabel.Size = new System.Drawing.Size(448, 41);
            this.technicianOpenIncidentsLabel.TabIndex = 3;
            this.technicianOpenIncidentsLabel.Text = "Technician Open Incidents";
            // 
            // technicianFieldsTableLayoutPanel
            // 
            this.technicianFieldsTableLayoutPanel.AutoScroll = true;
            this.technicianFieldsTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.SetColumnSpan(this.technicianFieldsTableLayoutPanel, 2);
            this.technicianFieldsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.technicianFieldsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.technicianFieldsTableLayoutPanel.Controls.Add(emailLabel, 0, 1);
            this.technicianFieldsTableLayoutPanel.Controls.Add(this.nameComboBox, 1, 0);
            this.technicianFieldsTableLayoutPanel.Controls.Add(phoneLabel, 0, 2);
            this.technicianFieldsTableLayoutPanel.Controls.Add(this.phoneTextBox, 1, 2);
            this.technicianFieldsTableLayoutPanel.Controls.Add(this.emailTextBox, 1, 1);
            this.technicianFieldsTableLayoutPanel.Controls.Add(nameLabel, 0, 0);
            this.technicianFieldsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.technicianFieldsTableLayoutPanel.Location = new System.Drawing.Point(35, 78);
            this.technicianFieldsTableLayoutPanel.Name = "technicianFieldsTableLayoutPanel";
            this.technicianFieldsTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.SetRowSpan(this.technicianFieldsTableLayoutPanel, 3);
            this.technicianFieldsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.technicianFieldsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.technicianFieldsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.technicianFieldsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.technicianFieldsTableLayoutPanel.Size = new System.Drawing.Size(578, 144);
            this.technicianFieldsTableLayoutPanel.TabIndex = 4;
            // 
            // nameComboBox
            // 
            this.nameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Name", true));
            this.nameComboBox.DataSource = this.technicianBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(118, 11);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(395, 24);
            this.nameComboBox.TabIndex = 6;
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.NameComboBoxSelectedIndexChanged);
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataSource = typeof(TechSupport.Model.Technician);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(118, 108);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(395, 22);
            this.phoneTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(118, 60);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(395, 22);
            this.emailTextBox.TabIndex = 1;
            // 
            // ViewIncidentsByTechnicianUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "ViewIncidentsByTechnicianUserControl";
            this.Size = new System.Drawing.Size(650, 500);
            this.Load += new System.EventHandler(this.ViewIncidentsByTechnicianUserControlLoad);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            this.technicianFieldsTableLayoutPanel.ResumeLayout(false);
            this.technicianFieldsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label technicianOpenIncidentsLabel;
        private System.Windows.Forms.TableLayoutPanel technicianFieldsTableLayoutPanel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.DataGridView incidentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpened;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentTitle;
        private System.Windows.Forms.BindingSource incidentBindingSource;
    }
}
