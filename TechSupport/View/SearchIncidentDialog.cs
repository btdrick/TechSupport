using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// This class serves as a Dialog Box to
    /// search for a submitted incident report byt customerID.
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        private readonly TechSupportController techSupportController;

        /// <summary>
        /// 0-param constructor
        /// </summary>
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this.techSupportController = new TechSupportController();
        }

        /// <summary>
        /// Handles the search incident button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchIncidentButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                int inputCustomerID = int.Parse(this.customerIDTextBox.Text);
                List<Incident> results = SearchByCustomerID(inputCustomerID);
                this.RefreshDataGrid(results);
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid CustomerID!\n\n" + ex.Message,
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the close button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClick(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Returns a list of incidents by CustomerID.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>Incidents by CustomerID</returns>
        private List<Incident> SearchByCustomerID(int customerID)
        {
            List<Incident> searchResults = new List<Incident>();
            foreach (var incident in this.techSupportController.GetIncidents())
            {
                if (incident.CustomerID == customerID)
                {
                    searchResults.Add(incident);
                }
            }

            if (searchResults.Capacity == 0)
            {
                throw new ArgumentException("Customer either does not exist or hasn't submitted an incident report");
            }
                return searchResults;
        }

        /// <summary>
        /// Refresh list of search results.
        /// </summary>
        private void RefreshDataGrid(List<Incident> incidentsByID)
        {
            if (!searchDataGridView.Visible)
            {
                searchDataGridView.Visible = true;
            }
            this.searchDataGridView.DataSource = null;
            this.searchDataGridView.DataSource = incidentsByID;
        }
    }
}
