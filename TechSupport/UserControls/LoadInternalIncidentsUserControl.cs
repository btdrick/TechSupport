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
            this.RefreshDataGrid();
        }

        /// <summary>
        /// Refresh list of incident reports.
        /// </summary>
        public void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.techSupportController.GetInternalIncidents();
            this.incidentDataGridView.AutoGenerateColumns = false;
            this.incidentDataGridView.Columns["DateOpened"].Visible = false;
            this.incidentDataGridView.Columns["ProductCode"].Visible = false;
            this.incidentDataGridView.Columns["Technician"].Visible = false;
            this.incidentDataGridView.Columns["Customer"].Visible = false;
        }
    }
}
