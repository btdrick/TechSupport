using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This class models a user control 
    /// which allows a user to retrieve existing
    /// incidents by ID and modify their contents.
    /// </summary>
    public partial class UpdateIncidentUserControl : UserControl
    {
        private readonly TechSupportController techSupportController;

        /// <summary>
        /// Initialize the form.
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            this.techSupportController = new TechSupportController();
        }

        /// <summary>
        /// Handles the event of the "Get" button
        /// being clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetIncidentButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                var incidentID = Convert.ToInt32(this.incidentIDTextBox.Text);
                Incident incident = new Incident
                {
                    IncidentID = incidentID
                };

                incident = this.techSupportController.GetIncidentByID(incident);
                this.RefreshTechnicianComboBox();

                this.customerTextBox.Text = incident.Customer;
                this.productCodeTextBox.Text = incident.ProductCode;
                if (incident.Technician == "" || incident.Technician == null)
                {
                    this.technicianComboBox.Text = "** Unassigned **";
                }
                else
                {
                    this.technicianComboBox.Text = incident.Technician;
                }
                this.titleTextBox.Text = incident.Title;
                this.dateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
                this.descriptionTextBox.Text = incident.Description;
                if (descriptionTextBox.Text.Length == 200)
                {
                    MessageBox.Show("Cannot add to incident description\n\nThe character count has reached its limit of 200");
                }
                else
                {
                    this.textToAddTextBox.Enabled = true;
                }
                this.updateIncidentButton.Enabled = true;
                this.closeButton.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid IncidentID\n\nCheck that the entered ID is a positive integer",
                    "IncidentID Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid IncidentID\n\nAn open incident with that ID does not exist",
                    "Search Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Populates the Technician ComboBox
        /// </summary>
        private void RefreshTechnicianComboBox()
        {
            this.technicianComboBox.DataSource = null;
            this.technicianComboBox.DataSource = this.techSupportController.GetTechnicianNames();
        }
    }
}
