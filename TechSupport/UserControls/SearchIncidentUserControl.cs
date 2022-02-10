using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This class models a User Control
    /// which allows the user to search
    /// for incidents stored in internal memory.
    /// </summary>
    public partial class SearchIncidentUserControl : UserControl
    {
        private readonly TechSupportController techSupportController;

        /// <summary>
        /// Initialize the form.
        /// </summary>
        public SearchIncidentUserControl()
        {
            InitializeComponent();
            this.techSupportController = new TechSupportController();
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
                    this.techSupportController.GetInternalIncidentsByCustomerID(inputCustomerID);
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
            this.searchIncidentDataGridView.AutoGenerateColumns = false;
            foreach (DataGridViewColumn column in this.searchIncidentDataGridView.Columns)
            {
                if (column.Name != "Title" && column.Name != "Description" && column.Name != "CustomerID")
                {
                    column.Visible = false;
                }
            }
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
    }
}
