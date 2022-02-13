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
        /// Handles the event of "Get" button click
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
               
                this.customerTextBox.Text = incident.Customer;
                this.productCodeTextBox.Text = incident.ProductCode;

                if (!this.technicianComboBox.Enabled)
                {
                    this.technicianComboBox.Enabled = true;
                }
                this.RefreshTechnicianComboBox();
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
                this.ValidateClosedDate(incident);
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
        /// Handles the event of "Clear" button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClick(object sender, EventArgs e)
        {
            this.ClearFields();
            this.technicianComboBox.Enabled = false;
            if (this.textToAddTextBox.Enabled)
            {
                this.textToAddTextBox.Enabled = false;
            }
            this.updateIncidentButton.Enabled = false;
            this.closeIncidentButton.Enabled = false;
        }

        /// <summary>
        /// Clears the data fields for the form.
        /// </summary>
        private void ClearFields()
        {
            void func(ControlCollection controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else if (control is ComboBox)
                    {
                        if ((control as ComboBox).Text != "")
                        {
                            (control as ComboBox).Text = "";
                        }
                        (control as ComboBox).DataSource = null;
                    }
                    else
                    {
                        func(control.Controls);
                    }       
            }

            func(Controls);
        }

        /// <summary>
        /// Populates the Technician ComboBox
        /// </summary>
        private void RefreshTechnicianComboBox()
        {
            this.technicianComboBox.DataSource = null;
            this.technicianComboBox.DataSource = this.techSupportController.GetTechnicianNames();
        }

        /// <summary>
        /// Disables fields to update an incident
        /// if it has already been closed
        /// </summary>
        /// <param name="incident"></param>
        private void ValidateClosedDate(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident cannot be null");
            }

            if (incident.DateClosed.ToShortDateString() == "1/1/0001")
            {
                this.updateIncidentButton.Enabled = true;
                this.closeIncidentButton.Enabled = true;
            }
            else
            {
                this.technicianComboBox.Enabled = false;
                this.textToAddTextBox.Enabled = false;
                this.updateIncidentButton.Enabled = false;
                this.closeIncidentButton.Enabled = false;
            }
        }
    }
}
