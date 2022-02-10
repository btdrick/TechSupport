using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This class models a User Control 
    /// which allows the user to view 
    /// incidents submitted to internal memory
    /// </summary>
    public partial class LoadInternalIncidentsUserControl : UserControl
    {
        private readonly TechSupportController techSupportController;

        /// <summary>
        /// Initialize the Form.
        /// </summary>
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
            foreach (DataGridViewColumn column in this.incidentDataGridView.Columns)
            {
                if (column.Name != "Title" && column.Name != "Description" && column.Name != "CustomerID")
                {
                    column.Visible = false;
                }
            }
        }
    }
}
