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
            this.RefreshComboBoxes();
        }

        /// <summary>
        /// Populates the Customer ComboBox with
        /// customer names from TechSupport db.
        /// </summary>
        private void RefreshCustomerComboBox()
        {
            this.customerComboBox.DataSource = null;
            this.customerComboBox.DataSource = this.techSupportController.GetCustomerNames();
        }

        /// <summary>
        /// Populates the Product ComboBox with
        /// product names from TechSupport db.
        /// </summary>
        private void RefreshProductComboBox()
        {
            this.productComboBox.DataSource = null;
            this.productComboBox.DataSource = this.techSupportController.GetProductNames();
        }

        /// <summary>
        /// Helper method to refresh ComboBox fields.
        /// </summary>
        public void RefreshComboBoxes()
        {
            this.RefreshCustomerComboBox();
            this.RefreshProductComboBox();
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
                var customer = this.customerComboBox.SelectedValue.ToString();
                var product = this.productComboBox.SelectedValue.ToString();
                var title = char.ToUpper(this.titleTextBox.Text[0]) + this.titleTextBox.Text.Substring(1);
                var description = this.descriptionTextBox.Text;

                if (this.techSupportController.ValidateExistingProductRegistration(customer, product))
                {

                    Incident incidentToAdd = new Incident
                    {
                        Customer = customer,
                        Product = product,
                        DateOpened = DateTime.Now,
                        Title = title,
                        Description = description
                    };
                    
                    this.techSupportController.AddOpenIncident(incidentToAdd);

                    this.addIncidentConfirmationLabel.Text = "Confirmation: new incident added\n by "
                    + this.customerComboBox.SelectedValue.ToString() + " with ID "
                    + this.techSupportController.GetLastIncidentID();
                } else
                {
                    MessageBox.Show(product + " is not registered to " + customer + ".",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!\n\nAn incident must have a title and description.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the cancel button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentClearButtonClick(object sender, EventArgs e)
        {
            if (this.titleTextBox.Text != "" ||
            this.descriptionTextBox.Text != "")
            {
                this.customerComboBox.SelectedIndex = 0;
                this.productComboBox.SelectedIndex = 0;
                this.titleTextBox.Text = "";
                this.descriptionTextBox.Text = "";
                
                this.addIncidentConfirmationLabel.Text = "Fields cleared";
            }
        }

        /// <summary>
        /// Clears the confirmation label upon text change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentFieldsChanged(object sender, EventArgs e)
        {
            if (this.addIncidentConfirmationLabel.Text != "")
            {
                this.addIncidentConfirmationLabel.Text = "";
            }
        }
    }
}
