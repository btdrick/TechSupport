using System.Windows.Forms;

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
        /// <summary>
        /// Initialize the control.
        /// </summary>
        public ViewIncidentsByTechnicianUserControl()
        {
            InitializeComponent();
        }

    }
}
