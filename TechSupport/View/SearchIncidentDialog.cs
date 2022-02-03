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
                List<Incident> results = 
                    this.techSupportController.GetIncidentsByCustomerID(inputCustomerID);
                this.RefreshDataGrid(results);
            } 
            catch (ArgumentException ex)
            {
                MessageBox.Show("Invalid CustomerID!\n\n" + ex.Message,
                    "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Search Error!\n\nPlease enter a numeric value",
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
