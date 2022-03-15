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
        private void AssignedOpenIncidentsReportUserControlLoad(object sender, System.EventArgs e)
        {
            this.RefreshReportData();   
        }

        public void RefreshReportData()
        {
            this.assignedOpenIncidentsTableAdapter.Fill(this.techSupportDataSet.AssignedOpenIncidents);
            this.assignedOpenIncidentsReportViewer.RefreshReport();
        }
    }
}
