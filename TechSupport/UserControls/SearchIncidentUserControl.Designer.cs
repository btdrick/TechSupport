
namespace TechSupport.UserControls
{
    partial class SearchIncidentUserControl
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
            this.searchLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchIncidentLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.searchIncidentButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchIncidentDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBoxLabel = new System.Windows.Forms.Label();
            this.searchCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchLayoutPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIncidentDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.searchLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.searchLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchLayoutPanel.Name = "searchLayoutPanel";
            this.searchLayoutPanel.RowCount = 4;
            this.searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.7561F));
            this.searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.2439F));
            this.searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.searchLayoutPanel.Size = new System.Drawing.Size(386, 344);
            this.searchLayoutPanel.TabIndex = 2;
            // 
            // searchIncidentLabel
            // 
            this.searchIncidentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchIncidentLabel.AutoSize = true;
            this.searchIncidentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchLayoutPanel.SetColumnSpan(this.searchIncidentLabel, 2);
            this.searchIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIncidentLabel.Location = new System.Drawing.Point(83, 21);
            this.searchIncidentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchIncidentLabel.Name = "searchIncidentLabel";
            this.searchIncidentLabel.Size = new System.Drawing.Size(220, 33);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 291);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(382, 51);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // searchIncidentButton
            // 
            this.searchIncidentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchIncidentButton.Location = new System.Drawing.Point(48, 9);
            this.searchIncidentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchIncidentButton.Name = "searchIncidentButton";
            this.searchIncidentButton.Size = new System.Drawing.Size(94, 32);
            this.searchIncidentButton.TabIndex = 1;
            this.searchIncidentButton.Text = "Search";
            this.searchIncidentButton.UseVisualStyleBackColor = true;
            this.searchIncidentButton.Click += new System.EventHandler(this.SearchIncidentButtonClick);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearSearchButton.Location = new System.Drawing.Point(239, 9);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(94, 32);
            this.clearSearchButton.TabIndex = 2;
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
            this.searchIncidentDataGridView.Location = new System.Drawing.Point(14, 88);
            this.searchIncidentDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchIncidentDataGridView.Name = "searchIncidentDataGridView";
            this.searchIncidentDataGridView.RowHeadersWidth = 51;
            this.searchIncidentDataGridView.RowTemplate.Height = 24;
            this.searchIncidentDataGridView.Size = new System.Drawing.Size(358, 150);
            this.searchIncidentDataGridView.TabIndex = 3;
            // 
            // searchTextBoxLabel
            // 
            this.searchTextBoxLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchTextBoxLabel.AutoSize = true;
            this.searchTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBoxLabel.Location = new System.Drawing.Point(28, 262);
            this.searchTextBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 8, 0);
            this.searchTextBoxLabel.Name = "searchTextBoxLabel";
            this.searchTextBoxLabel.Size = new System.Drawing.Size(157, 17);
            this.searchTextBoxLabel.TabIndex = 3;
            this.searchTextBoxLabel.Text = "Search by Customer ID:";
            // 
            // searchCustomerIDTextBox
            // 
            this.searchCustomerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchCustomerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerIDTextBox.Location = new System.Drawing.Point(201, 259);
            this.searchCustomerIDTextBox.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.searchCustomerIDTextBox.Name = "searchCustomerIDTextBox";
            this.searchCustomerIDTextBox.Size = new System.Drawing.Size(76, 23);
            this.searchCustomerIDTextBox.TabIndex = 0;
            this.searchCustomerIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchIncidentUserControl";
            this.Size = new System.Drawing.Size(386, 344);
            this.searchLayoutPanel.ResumeLayout(false);
            this.searchLayoutPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchIncidentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel searchLayoutPanel;
        private System.Windows.Forms.Label searchIncidentLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button searchIncidentButton;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.DataGridView searchIncidentDataGridView;
        private System.Windows.Forms.Label searchTextBoxLabel;
        private System.Windows.Forms.TextBox searchCustomerIDTextBox;
    }
}
