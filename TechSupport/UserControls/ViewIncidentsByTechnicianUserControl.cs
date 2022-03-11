using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{   
    /// <summary>
    /// This class models a user control
    /// which allows a user to view incidents
    /// categorized by the technician 
    /// they're assigned to. Does not display 
    /// unassigned incidents.
    /// </summary>
    public partial class ViewIncidentsByTechnicianUserControl : UserControl
    {
        private readonly TechnicianController technicianController;
        /// <summary>
        /// Initialize the control.
        /// </summary>
        public ViewIncidentsByTechnicianUserControl()
        {
            InitializeComponent();
            this.technicianController = new TechnicianController();
        }

        private void ViewIncidentsByTechnicianUserControlLoad(object sender, System.EventArgs e)
        {
            List<Technician> technicians = technicianController.GetAllTechnicians();
            this.nameComboBox.DataSource = technicians;
        }
    }
}
