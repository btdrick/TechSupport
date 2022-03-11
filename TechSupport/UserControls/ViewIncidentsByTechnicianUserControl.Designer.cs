
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.technicianOpenIncidentsLabel = new System.Windows.Forms.Label();
            this.technicianFieldsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.technicianPhoneLabel = new System.Windows.Forms.Label();
            this.technicianEmailLabel = new System.Windows.Forms.Label();
            this.technicianNameComboBox = new System.Windows.Forms.ComboBox();
            this.technicianPhoneTextBox = new System.Windows.Forms.TextBox();
            this.technicianEmailTextBox = new System.Windows.Forms.TextBox();
            this.techncianNameLabel = new System.Windows.Forms.Label();
            this.technicianOpenIncidentsListView = new System.Windows.Forms.ListView();
            this.mainTableLayoutPanel.SuspendLayout();
            this.technicianFieldsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.technicianFieldsTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.SetColumnSpan(this.technicianFieldsTableLayoutPanel, 2);
            this.technicianFieldsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.technicianFieldsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.technicianFieldsTableLayoutPanel.Controls.Add(this.technicianPhoneLabel, 0, 2);
            this.technicianFieldsTableLayoutPanel.Controls.Add(this.technicianEmailLabel, 0, 1);
            this.technicianFieldsTableLayoutPanel.Controls.Add(this.technicianNameComboBox, 1, 0);
            this.technicianFieldsTableLayoutPanel.Controls.Add(this.technicianPhoneTextBox, 1, 2);
            this.technicianFieldsTableLayoutPanel.Controls.Add(this.technicianEmailTextBox, 1, 1);
            this.technicianFieldsTableLayoutPanel.Controls.Add(this.techncianNameLabel, 0, 0);
            this.technicianFieldsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.technicianFieldsTableLayoutPanel.Location = new System.Drawing.Point(35, 78);
            this.technicianFieldsTableLayoutPanel.Name = "technicianFieldsTableLayoutPanel";
            this.technicianFieldsTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.SetRowSpan(this.technicianFieldsTableLayoutPanel, 3);
            this.technicianFieldsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.technicianFieldsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.technicianFieldsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.technicianFieldsTableLayoutPanel.Size = new System.Drawing.Size(578, 144);
            this.technicianFieldsTableLayoutPanel.TabIndex = 4;
            // 
            // technicianPhoneLabel
            // 
            this.technicianPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.technicianPhoneLabel.AutoSize = true;
            this.technicianPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianPhoneLabel.Location = new System.Drawing.Point(51, 109);
            this.technicianPhoneLabel.Name = "technicianPhoneLabel";
            this.technicianPhoneLabel.Size = new System.Drawing.Size(61, 20);
            this.technicianPhoneLabel.TabIndex = 23;
            this.technicianPhoneLabel.Text = "Phone:";
            this.technicianPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // technicianEmailLabel
            // 
            this.technicianEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.technicianEmailLabel.AutoSize = true;
            this.technicianEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianEmailLabel.Location = new System.Drawing.Point(56, 61);
            this.technicianEmailLabel.Name = "technicianEmailLabel";
            this.technicianEmailLabel.Size = new System.Drawing.Size(56, 20);
            this.technicianEmailLabel.TabIndex = 22;
            this.technicianEmailLabel.Text = "Email:";
            this.technicianEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // technicianNameComboBox
            // 
            this.technicianNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.technicianNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicianNameComboBox.FormattingEnabled = true;
            this.technicianNameComboBox.Location = new System.Drawing.Point(119, 11);
            this.technicianNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 7, 4);
            this.technicianNameComboBox.Name = "technicianNameComboBox";
            this.technicianNameComboBox.Size = new System.Drawing.Size(389, 24);
            this.technicianNameComboBox.TabIndex = 20;
            // 
            // technicianPhoneTextBox
            // 
            this.technicianPhoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.technicianPhoneTextBox.Location = new System.Drawing.Point(119, 108);
            this.technicianPhoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 7, 4);
            this.technicianPhoneTextBox.Name = "technicianPhoneTextBox";
            this.technicianPhoneTextBox.ReadOnly = true;
            this.technicianPhoneTextBox.Size = new System.Drawing.Size(389, 22);
            this.technicianPhoneTextBox.TabIndex = 15;
            // 
            // technicianEmailTextBox
            // 
            this.technicianEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.technicianEmailTextBox.Location = new System.Drawing.Point(119, 60);
            this.technicianEmailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 7, 4);
            this.technicianEmailTextBox.Name = "technicianEmailTextBox";
            this.technicianEmailTextBox.ReadOnly = true;
            this.technicianEmailTextBox.Size = new System.Drawing.Size(389, 22);
            this.technicianEmailTextBox.TabIndex = 14;
            // 
            // techncianNameLabel
            // 
            this.techncianNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.techncianNameLabel.AutoSize = true;
            this.techncianNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techncianNameLabel.Location = new System.Drawing.Point(54, 13);
            this.techncianNameLabel.Name = "techncianNameLabel";
            this.techncianNameLabel.Size = new System.Drawing.Size(58, 20);
            this.techncianNameLabel.TabIndex = 21;
            this.techncianNameLabel.Text = "Name:";
            this.techncianNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // technicianOpenIncidentsListView
            // 
            this.technicianOpenIncidentsListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainTableLayoutPanel.SetColumnSpan(this.technicianOpenIncidentsListView, 2);
            this.technicianOpenIncidentsListView.HideSelection = false;
            this.technicianOpenIncidentsListView.Location = new System.Drawing.Point(35, 228);
            this.technicianOpenIncidentsListView.Name = "technicianOpenIncidentsListView";
            this.technicianOpenIncidentsListView.Size = new System.Drawing.Size(578, 269);
            this.technicianOpenIncidentsListView.TabIndex = 5;
            this.technicianOpenIncidentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // ViewIncidentsByTechnicianUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "ViewIncidentsByTechnicianUserControl";
            this.Size = new System.Drawing.Size(650, 500);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.technicianFieldsTableLayoutPanel.ResumeLayout(false);
            this.technicianFieldsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label technicianOpenIncidentsLabel;
        private System.Windows.Forms.TableLayoutPanel technicianFieldsTableLayoutPanel;
        private System.Windows.Forms.ListView technicianOpenIncidentsListView;
        private System.Windows.Forms.TextBox technicianPhoneTextBox;
        private System.Windows.Forms.TextBox technicianEmailTextBox;
        private System.Windows.Forms.ComboBox technicianNameComboBox;
        private System.Windows.Forms.Label techncianNameLabel;
        private System.Windows.Forms.Label technicianPhoneLabel;
        private System.Windows.Forms.Label technicianEmailLabel;
    }
}
