using System;
using System.Collections.Generic;
using System.Drawing;
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
                this.updateIncidentStatusLabel.Text = "";                
                Incident incident = this.GetIncidentWithIDField();
                this.SetFields(incident);              
            }
            catch (FormatException)
            {
                this.UpdateIncidentStatusLabel("Check that the entered ID is a positive integer", true);
                this.ClearFields();
            }
            catch (Exception)
            {
                this.UpdateIncidentStatusLabel("An incident with that ID does not exist", true);
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
                Incident incident = this.GetIncidentWithIDField();
                this.UpdateTechnicianWIthTechnicianComboBox(incident);

                if (this.textToAddTextBox.Text != "")
                {
                    incident.Description += "\n<" + DateTime.Now.ToShortDateString() + "> " +
                    this.textToAddTextBox.Text;

                    if (incident.Description.Length > 200)
                    {
                        switch (this.ConfirmDescriptionTruncation())
                        {
                            case DialogResult.Cancel:
                                return;
                            case DialogResult.OK:
                                incident.Description = incident.Description.Substring(0, 196) + "...";
                                break;
                            default:
                                break;
                        }
                    }
                }          
                
                if (this.ConfirmUpdateIncident(incident) == DialogResult.OK)
                {
                    this.FinalizeUpdateIncident(incident);                   
                }
            }
            catch (ArgumentException)
            {
                this.UpdateIncidentStatusLabel("Cannot update the incident. Must have either new technician or description", true);
            }
            catch (Exception)
            {
                this.UpdateIncidentStatusLabel("An error has occurred with processing the update", true);
            }
        }

        /// <summary>
        /// Handles the event of "Close" button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseIncidentButtonClick(object sender, EventArgs e)
        {
            try
            {
                Incident incident = this.GetIncidentWithIDField();
                this.ValidateIncidentCanBeClosed(incident);
                incident.DateClosed = DateTime.Now;
                if (this.ConfirmUpdateIncident(incident) == DialogResult.OK)
                {
                    this.techSupportController.UpdateIncident(incident);
                    this.techSupportController.CloseIncident(incident);
                    incident = this.techSupportController.GetIncidentByID(incident);
                    this.SetFields(incident);
                    this.UpdateIncidentStatusLabel("Incident with ID of " + incident.IncidentID + " has been closed.", false);
                }
            }
            catch (ArgumentException)
            {
                this.UpdateIncidentStatusLabel("An incident must have an assigned technician in order to be closed.", true);
            }
            catch (Exception)
            {
                this.UpdateIncidentStatusLabel("An error has occurred while processing the close request.", true);
            }
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
        private Incident GetIncidentWithIDField()
        {
            Incident incident = new Incident
            {
                IncidentID = Convert.ToInt32(this.incidentIDTextBox.Text)
            };
            incident = this.techSupportController.GetIncidentByID(incident);
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
            this.textToAddTextBox.Text = "";
            if (descriptionTextBox.Text.Length == 200)
            {
                this.UpdateIncidentStatusLabel("Incident description cannot be added to, the max character count is 200", false);
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
                this.UpdateIncidentStatusLabel("Incident with ID of " + incident.IncidentID +
                " was closed on " + incident.DateClosed.ToShortDateString(), false);
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
        /// alter a closed incident or an empty form.
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
        /// Processes the update to an incident.
        /// </summary>
        /// <param name="incident"></param>
        private void FinalizeUpdateIncident(Incident incident)
        {
            this.ValidateIncident(incident);
            this.techSupportController.UpdateIncident(incident);
            incident = this.techSupportController.GetIncidentByID(incident);
            if (this.ValidateUserInput(incident))
            {
                this.UpdateIncidentStatusLabel("Incident with ID of " + incident.IncidentID + " has been updated.", false);
            }
            else
            {
                this.UpdateIncidentStatusLabel("No changes made.", false);
            }
            this.SetFields(incident);
        }

        /// <summary>
        /// Assigns Technician value to NULL
        /// if Technician remains unassigned.
        /// </summary>
        /// <param name="incident"></param>
        private void UpdateTechnicianWIthTechnicianComboBox(Incident incident)
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


        //*** VALIDATION FUNCTIONS ***


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
        /// Throws an exception if an incident
        /// has no technician assigned.
        /// </summary>
        /// <param name="incident"></param>
        private void ValidateIncidentCanBeClosed(Incident incident)
        {
            this.UpdateTechnicianWIthTechnicianComboBox(incident);
            if (incident.Technician == null)
            {
                throw new ArgumentException("Cannot close incident with unassigned technician");
            }
        }

        /// <summary>
        /// Checks that the fields to add 
        /// changes to an incidents have been updated.
        /// </summary>
        /// <param name="incident"></param>
        private bool ValidateUserInput(Incident incident)
        {
            this.ValidateIncident(incident);
            var selectedTechnician = this.technicianComboBox.SelectedValue.ToString();
            var addedText = this.textToAddTextBox.Text;
            if (((incident.Technician == null && selectedTechnician == "** Unassigned **") || incident.Technician != selectedTechnician)
                && addedText == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Updates the status label.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="isError"></param>
        private void UpdateIncidentStatusLabel(string message, bool isError)
        {
            if (message != null)
            {
                if (isError)
                {
                    this.updateIncidentStatusLabel.ForeColor = Color.Red;
                }
                else
                {
                    this.updateIncidentStatusLabel.ForeColor = Color.Black;
                }

                this.updateIncidentStatusLabel.Text = message;
            }
            else
            {
                throw new ArgumentException("Message cannot be null");
            }
        }
    }
}
