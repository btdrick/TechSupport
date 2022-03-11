using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;
using TechSupport.Validators;

namespace TechSupport.Controller
{
    /// <summary>
    /// This class serves as the controller, mediator for 
    /// TechSupport db Technicians table data.
    /// </summary>
    public class TechnicianController
    {
        public TechnicianController()
        {
        }

        /// <summary>
        /// Gets a list of all Technicians from TechSupport db source.
        /// </summary>
        /// <returns></returns>
        public List<Technician> GetAllTechnicians()
        {
            return TechnicianDAL.GetAllTechnicians();
        }

        /// <summary>
        /// Gets all technician names from TechSupport db source.
        /// </summary>
        /// <returns>List of technician names</returns>
        public List<string> GetTechnicianNames()
        {
            return TechnicianDAL.GetTechnicianNames();
        }

        /// <summary>
        /// Gets all open incidents assigned to a Technician.
        /// </summary>
        /// <param name="technician"></param>
        /// <returns></returns>
        public List<Incident> GetOpenIncidentsAssignedToTechnician(Technician technician)
        {
            TechnicianValidator.ValidateTechnicianNotNull(technician);
            return TechnicianDAL.GetOpenIncidentsAssignedToTechnician(technician);
        }
    }
}
