using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class AddIncidentUserControl : UserControl
    {
        private readonly TechSupportController techSupportController;

        public AddIncidentUserControl()
        {
            InitializeComponent();
            this.techSupportController = new TechSupportController();
        }

        /// <summary>
        /// Handles the add incident button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentButtonClick(object sender, EventArgs e)
        {
            try
            {
                var title = char.ToUpper(this.titleTextBox.Text[0]) + this.titleTextBox.Text.Substring(1);
                var description = this.descriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.techSupportController.AddInternalIncident(new Incident(title, description, customerID));
                this.addIncidentConfirmationLabel.Text = title + " incident has been added under CustomerID: " + customerID;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!\n\nAn incident must have a:\n - Title\n- Description\n- CustomerID greater than 0",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the cancel button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentCancelButtonClick(object sender, EventArgs e)
        {
            if (this.titleTextBox.Text != "" &&
            this.descriptionTextBox.Text != "" &&
            this.customerIDTextBox.Text != "")
            {
                this.titleTextBox.Text = "";
                this.descriptionTextBox.Text = "";
                this.customerIDTextBox.Text = "";
                this.addIncidentConfirmationLabel.Text = "Fields cleared";
            }
        }

        /// <summary>
        /// Clears the confirmation label upon text change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentTextFieldsChanged(object sender, EventArgs e)
        {
            this.addIncidentConfirmationLabel.Text = "";
        }
    }
}
