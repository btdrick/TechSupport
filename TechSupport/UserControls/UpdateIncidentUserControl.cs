using System;
using System.Collections.Generic;
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
        /// Handles the event of "Get" button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetIncidentButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                this.messageLabel.Text = "";                
                Incident incident = new Incident
                {
                    IncidentID = Convert.ToInt32(this.incidentIDTextBox.Text)
                };
                incident = this.techSupportController.GetIncidentByID(incident);
                this.SetFields(incident);              
            }
            catch (FormatException)
            {
                this.messageLabel.Text = "Check that the entered ID is a positive integer";
                this.ClearFields();
            }
            catch (Exception)
            {
                this.messageLabel.Text = "An incident with that ID does not exist";
                this.ClearFields();
            }
        }

        /// <summary>
        /// Handles the event of "Update" button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateIncidentButtonClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the event of "Close" button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseIncidentButtonClick(object sender, EventArgs e)
        {
            Incident incident = new Incident
            {
                IncidentID = Convert.ToInt32(this.incidentIDTextBox.Text)
            };
            this.techSupportController.CloseIncident(incident);
        }

        /// <summary>
        /// Handles the event of "Clear" button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClick(object sender, EventArgs e)
        {
            this.ClearFields();
            this.DisableFields();
        }

        ///*** HELPER FUNCTIONS ***

        /// <summary>
        /// Sets the fields after getting an existing incident.
        /// </summary>
        /// <param name="incident"></param>
        private void SetFields(Incident incident)
        {
            this.ValidateIncident(incident);

            this.customerTextBox.Text = incident.Customer;
            this.productCodeTextBox.Text = incident.ProductCode;
            this.SetTechnicianComboBox(incident);
            this.titleTextBox.Text = incident.Title;
            this.dateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
            this.descriptionTextBox.Text = incident.Description;
            if (descriptionTextBox.Text.Length == 200)
            {
                this.messageLabel.Text = "Cannot add to incident description, character count has reached its limit of 200";
                this.textToAddTextBox.Enabled = false;
            }
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
        /// with names of technicians.
        /// </summary>
        private void SetTechnicianComboBox(Incident incident)
        {
            this.ValidateIncident(incident);

            this.technicianComboBox.DataSource = null;
            if (this.techSupportController.IsIncidentClosed(incident))
            {
                this.SetTechnicianComboBoxForClosedIncident(incident);
                this.DisableFields();
                this.messageLabel.Text = "Incident with ID of " + incident.IncidentID +
                " was closed on " + incident.DateClosed.ToShortDateString();
            }
            else if (incident.Technician == "" || incident.Technician == null)
            {
                this.SetTechnicianComboBoxForOpenUnassignedIncident(incident);
                this.EnableFieldsForOpenIncident();
            }
            else
            {
                this.SetTechnicianComboBoxForOpenIncident(incident);
                this.EnableFieldsForOpenIncident();
            }
        }

        /// <summary>
        /// Sets Technician ComboBox for a closed incident.
        /// </summary>
        /// <param name="incident"></param>
        private void SetTechnicianComboBoxForClosedIncident(Incident incident)
        {
            this.ValidateIncident(incident);
            List<string> technicianWhoClosedIncident = new List<string> { incident.Technician };
            this.technicianComboBox.DataSource = technicianWhoClosedIncident;
            this.technicianComboBox.SelectedItem = incident.Technician;
        }

        /// <summary>
        /// Sets Technician ComboBox for an open incident
        /// with an unassigned technician.
        /// </summary>
        /// <param name="incident"></param>
        private void SetTechnicianComboBoxForOpenUnassignedIncident(Incident incident)
        {
            this.ValidateIncident(incident);
            List<string> techniciansWithUnassignedIncident = new List<string> { "** Unassigned **" };
            techniciansWithUnassignedIncident.AddRange(this.techSupportController.GetTechnicianNames());
            this.technicianComboBox.DataSource = techniciansWithUnassignedIncident;
            this.technicianComboBox.SelectedItem = "** Unassigned **";
        }

        /// <summary>
        /// Sets Technician ComboBox for an open incident
        /// with an assigned technician.
        /// </summary>
        /// <param name="incident"></param>
        private void SetTechnicianComboBoxForOpenIncident(Incident incident)
        {
            this.ValidateIncident(incident);
            this.technicianComboBox.DataSource = this.techSupportController.GetTechnicianNames();
            this.technicianComboBox.SelectedItem = incident.Technician;
        }

        /// <summary>
        /// Enables fields so the user can
        /// update an open incident.
        /// </summary>
        /// <param name="incident"></param>
        private void EnableFieldsForOpenIncident()
        {
            this.technicianComboBox.Enabled = true;
            this.textToAddTextBox.Enabled = true;
            this.updateIncidentButton.Enabled = true;
            this.closeIncidentButton.Enabled = true;
        }

        /// <summary>
        /// Disables fields so user cannot
        /// alter a closed incident.
        /// </summary>
        /// <param name="incident"></param>
        private void DisableFields()
        {
            this.technicianComboBox.Enabled = false;
            this.textToAddTextBox.Enabled = false;
            this.updateIncidentButton.Enabled = false;
            this.closeIncidentButton.Enabled = false;
                        
        }

        /// <summary>
        /// Validates that an Incident object is not null.
        /// </summary>
        /// <param name="incident"></param>
        private void ValidateIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident cannot be null");
            }
        }
    }
}
