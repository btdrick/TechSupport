
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.submitButtonLayoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.addIncidentCancelButton = new System.Windows.Forms.Button();
            this.addIncidentConfirmationLabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addIncidentLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.submitButtonLayoutPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.23316F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.76684F));
            this.tableLayoutPanel1.Controls.Add(this.submitButtonLayoutPane, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.addIncidentConfirmationLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.customerIDTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.customerIDLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addIncidentLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 280);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // submitButtonLayoutPane
            // 
            this.submitButtonLayoutPane.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.submitButtonLayoutPane, 2);
            this.submitButtonLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitButtonLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitButtonLayoutPane.Controls.Add(this.addIncidentButton, 0, 0);
            this.submitButtonLayoutPane.Controls.Add(this.addIncidentCancelButton, 1, 0);
            this.submitButtonLayoutPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButtonLayoutPane.Location = new System.Drawing.Point(2, 214);
            this.submitButtonLayoutPane.Margin = new System.Windows.Forms.Padding(2);
            this.submitButtonLayoutPane.Name = "submitButtonLayoutPane";
            this.submitButtonLayoutPane.RowCount = 1;
            this.submitButtonLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitButtonLayoutPane.Size = new System.Drawing.Size(376, 79);
            this.submitButtonLayoutPane.TabIndex = 13;
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentButton.Location = new System.Drawing.Point(47, 23);
            this.addIncidentButton.Margin = new System.Windows.Forms.Padding(2);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(94, 32);
            this.addIncidentButton.TabIndex = 3;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.AddIncidentButtonClick);
            // 
            // addIncidentCancelButton
            // 
            this.addIncidentCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentCancelButton.Location = new System.Drawing.Point(235, 23);
            this.addIncidentCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.addIncidentCancelButton.Name = "addIncidentCancelButton";
            this.addIncidentCancelButton.Size = new System.Drawing.Size(94, 32);
            this.addIncidentCancelButton.TabIndex = 4;
            this.addIncidentCancelButton.Text = "Cancel";
            this.addIncidentCancelButton.UseVisualStyleBackColor = true;
            this.addIncidentCancelButton.Click += new System.EventHandler(this.AddIncidentCancelButtonClick);
            // 
            // addIncidentConfirmationLabel
            // 
            this.addIncidentConfirmationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIncidentConfirmationLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.addIncidentConfirmationLabel, 2);
            this.addIncidentConfirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentConfirmationLabel.Location = new System.Drawing.Point(190, 191);
            this.addIncidentConfirmationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addIncidentConfirmationLabel.Name = "addIncidentConfirmationLabel";
            this.addIncidentConfirmationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addIncidentConfirmationLabel.Size = new System.Drawing.Size(0, 20);
            this.addIncidentConfirmationLabel.TabIndex = 12;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(135, 162);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(141, 23);
            this.customerIDTextBox.TabIndex = 11;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.AddIncidentTextFieldsChanged);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(42, 165);
            this.customerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(89, 17);
            this.customerIDLabel.TabIndex = 10;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.descriptionTextBox, 2);
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(55, 108);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(270, 48);
            this.descriptionTextBox.TabIndex = 9;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.AddIncidentTextFieldsChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(48, 83);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(135, 52);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(141, 23);
            this.titleTextBox.TabIndex = 7;
            this.titleTextBox.TextChanged += new System.EventHandler(this.AddIncidentTextFieldsChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(92, 55);
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
            this.tableLayoutPanel1.SetColumnSpan(this.addIncidentLabel, 2);
            this.addIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentLabel.Location = new System.Drawing.Point(52, 8);
            this.addIncidentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addIncidentLabel.Name = "addIncidentLabel";
            this.addIncidentLabel.Size = new System.Drawing.Size(275, 33);
            this.addIncidentLabel.TabIndex = 1;
            this.addIncidentLabel.Text = "Add Incident Report";
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(380, 280);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.submitButtonLayoutPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel submitButtonLayoutPane;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button addIncidentCancelButton;
        private System.Windows.Forms.Label addIncidentConfirmationLabel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addIncidentLabel;
    }
}
