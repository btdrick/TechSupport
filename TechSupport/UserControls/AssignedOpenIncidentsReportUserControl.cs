using System;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    public partial class AssignedOpenIncidentsReportUserControl : UserControl
    {
        public AssignedOpenIncidentsReportUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for loading the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignedOpenIncidentsReportViewerLoad(object sender, System.EventArgs e)
        {
            this.openAssignedIncidentsTableAdapter.Fill(this.techSupportDataSet.OpenAssignedIncidents);
            this.assignedOpenIncidentsReportViewer.Refresh();
        }
    }
}
