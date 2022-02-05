using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class LoadInternalIncidentsUserControl : UserControl
    {
        private readonly TechSupportController techSupportController;

        public LoadInternalIncidentsUserControl()
        {
            InitializeComponent();
            this.techSupportController = new TechSupportController();
            this.RefreshLoadDataGrid();
        }

        /// <summary>
        /// Refresh list of incident reports.
        /// </summary>
        private void RefreshLoadDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.techSupportController.GetIncidents();
        }

        /// <summary>
        /// Handles the event for clicking the refresh button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshIncidentsDataGridButtonClick(object sender, EventArgs e)
        {
            this.RefreshLoadDataGrid();
        }
    }
}
