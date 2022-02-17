using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This class models a User Control
    /// where a user can submit a new open 
    /// incident to the TechSupport database.
    /// </summary>
    public partial class AddIncidentUserControl : UserControl
    {
        private readonly TechSupportController techSupportController;

        /// <summary>
        /// Initialize the form.
        /// </summary>
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

                Incident incidentToAdd = new Incident
                {
                    Customer = customer,
                    Product = product,
                    DateOpened = DateTime.Now,
                    Title = title,
                    Description = description
                };

                if (this.techSupportController.ProductIsRegisteredToCustomer(incidentToAdd))
                {
                    this.techSupportController.AddOpenIncident(incidentToAdd);

                    this.UpdateIncidentStatusLabel("Incident successfully added\n by "
                    + this.customerComboBox.SelectedValue.ToString() + ". Incident ID is "
                    + incidentToAdd.IncidentID, false);
                } else
                {
                    this.UpdateIncidentStatusLabel(product + " is not registered to " + customer + ".", true);
                }
            }
            catch (Exception)
            {
                this.UpdateIncidentStatusLabel("An incident must have a title and description.", true);
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
                
                this.UpdateIncidentStatusLabel("Fields cleared", false);
            }
        }

        /// <summary>
        /// Clears the confirmation label upon text change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentFieldsChanged(object sender, EventArgs e)
        {
            if (this.addIncidentStatusLabel.Text != "")
            {
                this.UpdateIncidentStatusLabel("", false);
            }
        }

        /// <summary>
        /// Updates message status label.
        /// </summary>
        /// <param name="message"></param>
        private void UpdateIncidentStatusLabel(string message, bool isErrorMessage)
        {
            if (message != null)
            {
                if (isErrorMessage)
                {
                    this.addIncidentStatusLabel.ForeColor = Color.Red;
                }
                else
                {
                    this.addIncidentStatusLabel.ForeColor = Color.Black;
                }
                
                this.addIncidentStatusLabel.Text = message;               
            }
            else
            {
                throw new ArgumentException("Message cannot be null");
            }
        }
    }
}
