using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// This class serves as the controller, mediator for 
    /// TechSupport db Technicians table data.
    /// </summary>
    public class TechnicianController
    {
        private readonly TechnicianDBDAL technicianDBSource;

        public TechnicianController()
        {
            this.technicianDBSource = new TechnicianDBDAL();
        }

        /// <summary>
        /// Gets a list of all Technicians from TechSupport db source.
        /// </summary>
        /// <returns></returns>
        public List<Technician> GetAllTechnicians()
        {
            return TechnicianDBDAL.GetAllTechnicians();
        }

        /// <summary>
        /// Gets all technician names from TechSupport db source.
        /// </summary>
        /// <returns>List of technician names</returns>
        public List<string> GetTechnicianNames()
        {
            return this.technicianDBSource.GetTechnicianNames();
        }
    }
}
