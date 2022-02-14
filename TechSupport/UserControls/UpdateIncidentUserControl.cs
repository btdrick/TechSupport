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
        /// Handles the event of "Get" button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetIncidentButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                this.messageLabel.Text = "";
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

                this.titleTextBox.Text = incident.Title;
                this.dateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
                this.descriptionTextBox.Text = incident.Description;

                if (descriptionTextBox.Text.Length == 200)
                {
                    this.messageLabel.Text = "Cannot add to incident description, character count has reached its limit of 200";
                }
                else
                {
                    this.textToAddTextBox.Enabled = true;
                }

                this.ValidateClosedDate(incident);
                if (incident.Technician == "" || incident.Technician == null)
                {
                    this.technicianComboBox.Items.Insert(0, "** Unassigned **");
                    this.technicianComboBox.SelectedIndex = 0;
                }
            }
            catch (FormatException)
            {
                this.messageLabel.Text = "Check that the entered ID is a positive integer";
            }
            catch (Exception)
            {
                this.messageLabel.Text = "An incident with that ID does not exist";                
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
                        (control as ComboBox).Items.Clear();
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
        private void RefreshTechnicianComboBox()
        {
            this.technicianComboBox.Items.Clear();
            List<string> technicians = this.techSupportController.GetTechnicianNames();
            foreach (var technician in technicians)
            { 
                this.technicianComboBox.Items.Add(technician);
            }
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
                this.RefreshTechnicianComboBox();
                this.technicianComboBox.SelectedItem = incident.Technician;
            }
            else
            {
                this.textToAddTextBox.Enabled = false;
                this.updateIncidentButton.Enabled = false;
                this.closeIncidentButton.Enabled = false;
                this.messageLabel.Text = "Incident with ID of " + incident.IncidentID + 
                    " was closed on " + incident.DateClosed.ToShortDateString();
                this.technicianComboBox.Items.Clear();
                this.technicianComboBox.Items.Insert(0, incident.Technician);
                this.technicianComboBox.SelectedItem = incident.Technician;
                this.technicianComboBox.Enabled = false;
            }
        }
    }
}
