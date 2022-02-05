using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// The main form for Tech Support application.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly TechSupportController techSupportController;

        /// <summary>
        /// Initializes MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.techSupportController = new TechSupportController();
            this.usernameLabel.Text = "Hello, " + FormProvider.LoginForm.UsernameLabel + "!";
        }

        /// <summary>
        /// Loads the MainForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormLoad(object sender, EventArgs e)
        {
            this.RefreshLoadDataGrid();
        }

        /// <summary>
        /// Hides current form and shows owner LoginForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutLinkClickedEventHandle(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormProvider.LoginForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Closes the application upon form closure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormClosedEventHandle(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.techSupportController.Add(new Incident(title, description, customerID));
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
            this.titleTextBox.Text = "";
            this.descriptionTextBox.Text = "";
            this.customerIDTextBox.Text = "";
            this.addIncidentConfirmationLabel.Text = "Fields cleared";
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

        /// <summary>
        /// Handles the search incident button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchIncidentButtonClick(object sender, EventArgs e)
        {
            try
            {
                int inputCustomerID = int.Parse(this.searchCustomerIDTextBox.Text);
                List<Incident> results =
                    this.techSupportController.GetIncidentsByCustomerID(inputCustomerID);
                this.RefreshSearchIncidentDataGrid(results);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid CustomerID!\n\nCustomerID must be numeric and assigned to an incident",
                    "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refresh list of search results.
        /// </summary>
        private void RefreshSearchIncidentDataGrid(List<Incident> incidentsByID)
        {
            this.searchIncidentDataGridView.DataSource = null;
            this.searchIncidentDataGridView.DataSource = incidentsByID;
        }

        /// <summary>
        /// Clears the Search Incidents data grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearSearchButtonClicked(object sender, EventArgs e)
        {
            this.searchIncidentDataGridView.DataSource = null;
        }

        /// <summary>
        /// Refresh list of incident reports.
        /// </summary>
        private void RefreshLoadDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.techSupportController.GetIncidents();
        }

        private void RefreshIncidentsDataGridButtonClick(object sender, EventArgs e)
        {
            this.RefreshLoadDataGrid();
        }
    }
}
