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
                Incident incident = this.CreateIncidentWithIDField();
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
            try
            {
                Incident incident = this.CreateIncidentWithIDField();
                incident = this.techSupportController.GetIncidentByID(incident);
                this.ValidateFieldsChanged(incident);
                this.CheckIncidentAssignedTechnician(incident);

                if (this.textToAddTextBox.Text != "")
                {
                    incident.Description += "\n<" + DateTime.Now.ToShortDateString() + "> " +
                    this.textToAddTextBox.Text;
                }
                if (incident.Description.Length > 200)
                {
                    switch (this.ConfirmDescriptionTruncation())
                    {
                        case DialogResult.Cancel:
                            return;
                        case DialogResult.OK:
                            incident.Description = incident.Description.Substring(0, 198) + "...";
                            break;
                        default:
                            break;
                    }
                }
                if (this.ConfirmUpdateIncident(incident) == DialogResult.OK)
                {
                    this.techSupportController.UpdateIncident(incident);
                    this.messageLabel.Text = "Incident with ID of " + incident.IncidentID + " has been updated.";
                }
            }
            catch (ArgumentException)
            {
                this.messageLabel.Text = "Cannot update the incident. Must have either new technician or description";
            }
            catch (Exception)
            {
                this.messageLabel.Text = "An error has occurred with processing the update";
            }
        }

        /// <summary>
        /// Handles the event of "Close" button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseIncidentButtonClick(object sender, EventArgs e)
        {
            Incident incident = this.CreateIncidentWithIDField();
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

        //*** HELPER FUNCTIONS ***

        
        /// <summary>
        /// Creates an Incident object
        /// using the IncidentID TextField.
        /// </summary>
        /// <returns>Incident object</returns>
        private Incident CreateIncidentWithIDField()
        {
            Incident incident = new Incident
            {
                IncidentID = Convert.ToInt32(this.incidentIDTextBox.Text)
            };
            return incident;
        }

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
            else if (incident.Technician == null)
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
        /// Prompts the user to confirm
        /// that they want to update the incident.
        /// </summary>
        /// <param name="incident"></param>
        private DialogResult ConfirmUpdateIncident(Incident incident)
        {
            this.ValidateIncident(incident);
            DialogResult result = MessageBox.Show("Are you sure you want to update Incident " + incident.IncidentID +
                " with title: " + incident.Title + "?\n\nThis cannot be undone", 
                "Confirm Incident Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return result;
        }

        /// <summary>
        /// Prompts a warning to the user
        /// a confirmation to truncate an incident's
        /// description with the added text.
        /// </summary>
        /// <returns>True to truncate description</returns>
        private DialogResult ConfirmDescriptionTruncation()
        {
            DialogResult result = MessageBox.Show("Added text currently exceeds the 200 character limit.\n" +
                "Would you like to truncate the description to fit the 200 character limit?\n\n" +
                "This cannot be undone.",
                "Update Description Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return result;
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

        /// <summary>
        /// Checks that the fields to add 
        /// changes to an incidents have been updated.
        /// </summary>
        /// <param name="incident"></param>
        private void ValidateFieldsChanged(Incident incident)
        {
            this.ValidateIncident(incident);
            var selectedTechnician = this.technicianComboBox.SelectedValue.ToString();
            var addedText = this.textToAddTextBox.Text;
            if (((incident.Technician == null && selectedTechnician == "** Unassigned **") || incident.Technician == selectedTechnician) 
                && addedText == "")
            {
                throw new ArgumentException("Cannot update incident with unchanged fields");
            }
        }

        /// <summary>
        /// Assigns Technician value to NULL
        /// if Technician remains unassigned.
        /// </summary>
        /// <param name="incident"></param>
        private void CheckIncidentAssignedTechnician(Incident incident)
        {
            this.ValidateIncident(incident);
            var selectedTechnician = this.technicianComboBox.SelectedValue.ToString();
            if (selectedTechnician == "** Unassigned **")
            {
                incident.Technician = null;
            }
            else
            {
                incident.Technician = selectedTechnician;
            }
        }
    }
}
