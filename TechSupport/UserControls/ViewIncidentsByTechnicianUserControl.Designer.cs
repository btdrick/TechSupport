
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
            this.technicianOpenIncidentsLabel = new System.Windows.Forms.Label();
            this.technicianFieldsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.technicianOpenIncidentsListView = new System.Windows.Forms.ListView();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
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
            this.mainTableLayoutPanel.Controls.Add(this.technicianOpenIncidentsLabel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.technicianFieldsTableLayoutPanel, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.technicianOpenIncidentsListView, 1, 4);
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
            // technicianOpenIncidentsListView
            // 
            this.technicianOpenIncidentsListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainTableLayoutPanel.SetColumnSpan(this.technicianOpenIncidentsListView, 2);
            this.technicianOpenIncidentsListView.HideSelection = false;
            this.technicianOpenIncidentsListView.Location = new System.Drawing.Point(35, 228);
            this.technicianOpenIncidentsListView.Name = "technicianOpenIncidentsListView";
            this.technicianOpenIncidentsListView.Size = new System.Drawing.Size(578, 269);
            this.technicianOpenIncidentsListView.TabIndex = 4;
            this.technicianOpenIncidentsListView.UseCompatibleStateImageBehavior = false;
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
        private System.Windows.Forms.ListView technicianOpenIncidentsListView;
    }
}
