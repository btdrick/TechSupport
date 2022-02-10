
namespace TechSupport.UserControls
{
    partial class AddIncidentUserControl
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
            this.addIncidentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.submitButtonLayoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.addIncidentCancelButton = new System.Windows.Forms.Button();
            this.addIncidentStatusLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addIncidentLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.addIncidentTableLayoutPanel.SuspendLayout();
            this.submitButtonLayoutPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // addIncidentTableLayoutPanel
            // 
            this.addIncidentTableLayoutPanel.ColumnCount = 2;
            this.addIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.99408F));
            this.addIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.00592F));
            this.addIncidentTableLayoutPanel.Controls.Add(this.submitButtonLayoutPane, 0, 6);
            this.addIncidentTableLayoutPanel.Controls.Add(this.addIncidentStatusLabel, 0, 5);
            this.addIncidentTableLayoutPanel.Controls.Add(this.descriptionTextBox, 1, 4);
            this.addIncidentTableLayoutPanel.Controls.Add(this.descriptionLabel, 0, 4);
            this.addIncidentTableLayoutPanel.Controls.Add(this.titleTextBox, 1, 3);
            this.addIncidentTableLayoutPanel.Controls.Add(this.titleLabel, 0, 3);
            this.addIncidentTableLayoutPanel.Controls.Add(this.addIncidentLabel, 0, 0);
            this.addIncidentTableLayoutPanel.Controls.Add(this.productLabel, 0, 2);
            this.addIncidentTableLayoutPanel.Controls.Add(this.customerLabel, 0, 1);
            this.addIncidentTableLayoutPanel.Controls.Add(this.customerComboBox, 1, 1);
            this.addIncidentTableLayoutPanel.Controls.Add(this.productComboBox, 1, 2);
            this.addIncidentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncidentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.addIncidentTableLayoutPanel.Name = "addIncidentTableLayoutPanel";
            this.addIncidentTableLayoutPanel.RowCount = 7;
            this.addIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.02899F));
            this.addIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.43478F));
            this.addIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14493F));
            this.addIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.72464F));
            this.addIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.01639F));
            this.addIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.78689F));
            this.addIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.39344F));
            this.addIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.addIncidentTableLayoutPanel.Size = new System.Drawing.Size(380, 305);
            this.addIncidentTableLayoutPanel.TabIndex = 1;
            // 
            // submitButtonLayoutPane
            // 
            this.submitButtonLayoutPane.ColumnCount = 2;
            this.addIncidentTableLayoutPanel.SetColumnSpan(this.submitButtonLayoutPane, 2);
            this.submitButtonLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitButtonLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitButtonLayoutPane.Controls.Add(this.addIncidentButton, 0, 0);
            this.submitButtonLayoutPane.Controls.Add(this.addIncidentCancelButton, 1, 0);
            this.submitButtonLayoutPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButtonLayoutPane.Location = new System.Drawing.Point(2, 256);
            this.submitButtonLayoutPane.Margin = new System.Windows.Forms.Padding(2);
            this.submitButtonLayoutPane.Name = "submitButtonLayoutPane";
            this.submitButtonLayoutPane.RowCount = 1;
            this.submitButtonLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitButtonLayoutPane.Size = new System.Drawing.Size(376, 47);
            this.submitButtonLayoutPane.TabIndex = 13;
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentButton.Location = new System.Drawing.Point(47, 9);
            this.addIncidentButton.Margin = new System.Windows.Forms.Padding(2);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(94, 29);
            this.addIncidentButton.TabIndex = 4;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.AddIncidentButtonClick);
            // 
            // addIncidentCancelButton
            // 
            this.addIncidentCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentCancelButton.Location = new System.Drawing.Point(235, 9);
            this.addIncidentCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.addIncidentCancelButton.Name = "addIncidentCancelButton";
            this.addIncidentCancelButton.Size = new System.Drawing.Size(94, 29);
            this.addIncidentCancelButton.TabIndex = 5;
            this.addIncidentCancelButton.Text = "Clear";
            this.addIncidentCancelButton.UseVisualStyleBackColor = true;
            this.addIncidentCancelButton.Click += new System.EventHandler(this.AddIncidentClearButtonClick);
            // 
            // addIncidentStatusLabel
            // 
            this.addIncidentStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentStatusLabel.AutoSize = true;
            this.addIncidentTableLayoutPanel.SetColumnSpan(this.addIncidentStatusLabel, 2);
            this.addIncidentStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentStatusLabel.Location = new System.Drawing.Point(190, 225);
            this.addIncidentStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addIncidentStatusLabel.Name = "addIncidentStatusLabel";
            this.addIncidentStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addIncidentStatusLabel.Size = new System.Drawing.Size(0, 20);
            this.addIncidentStatusLabel.TabIndex = 12;
            this.addIncidentStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(123, 161);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.MaxLength = 2000;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(243, 53);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.AddIncidentFieldsChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(25, 165);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(123, 131);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(243, 23);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.TextChanged += new System.EventHandler(this.AddIncidentFieldsChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(69, 134);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Title:";
            // 
            // addIncidentLabel
            // 
            this.addIncidentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentLabel.AutoSize = true;
            this.addIncidentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addIncidentTableLayoutPanel.SetColumnSpan(this.addIncidentLabel, 2);
            this.addIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentLabel.Location = new System.Drawing.Point(52, 16);
            this.addIncidentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addIncidentLabel.Name = "addIncidentLabel";
            this.addIncidentLabel.Size = new System.Drawing.Size(275, 33);
            this.addIncidentLabel.TabIndex = 1;
            this.addIncidentLabel.Text = "Add Incident Report";
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(47, 103);
            this.productLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(61, 17);
            this.productLabel.TabIndex = 14;
            this.productLabel.Text = "Product:";
            // 
            // customerLabel
            // 
            this.customerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(36, 73);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(72, 17);
            this.customerLabel.TabIndex = 15;
            this.customerLabel.Text = "Customer:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.AllowDrop = true;
            this.customerComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(123, 71);
            this.customerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerComboBox.MaxDropDownItems = 5;
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(243, 21);
            this.customerComboBox.TabIndex = 0;
            this.customerComboBox.SelectedValueChanged += new System.EventHandler(this.AddIncidentFieldsChanged);
            // 
            // productComboBox
            // 
            this.productComboBox.AllowDrop = true;
            this.productComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(123, 101);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(243, 21);
            this.productComboBox.TabIndex = 1;
            this.productComboBox.SelectedValueChanged += new System.EventHandler(this.AddIncidentFieldsChanged);
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addIncidentTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(380, 305);
            this.addIncidentTableLayoutPanel.ResumeLayout(false);
            this.addIncidentTableLayoutPanel.PerformLayout();
            this.submitButtonLayoutPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addIncidentTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel submitButtonLayoutPane;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button addIncidentCancelButton;
        private System.Windows.Forms.Label addIncidentStatusLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addIncidentLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
    }
}
