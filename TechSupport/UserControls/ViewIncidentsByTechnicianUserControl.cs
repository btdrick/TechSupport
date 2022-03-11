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
        private List<Technician> technicians;
        /// <summary>
        /// Initialize the control.
        /// </summary>
        public ViewIncidentsByTechnicianUserControl()
        {
            InitializeComponent();
            this.technicianController = new TechnicianController();
        }

        /// <summary>
        /// Event handler for loading the user control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewIncidentsByTechnicianUserControlLoad(object sender, System.EventArgs e)
        {
            this.technicians = technicianController.GetAllTechnicians();
            this.nameComboBox.DataSource = technicians;
        }

        /// <summary>
        /// Event handler for changing index of Name ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameComboBoxSelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.nameComboBox.SelectedIndex < 0)
            {
                return;
            }

            Technician technician = this.technicians[this.nameComboBox.SelectedIndex];
            technicianBindingSource.Clear();
            technicianBindingSource.Add(technician);
            incidentBindingSource.Clear();
            incidentBindingSource.DataSource = this.technicianController.GetOpenIncidentsAssignedToTechnician(technician);
        }
    }
}
