using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// This class serves as the controller, mediator of the application.
    /// </summary>
    public class TechSupportController
    {
        private IncidentDAL incidentSource;

        /// <summary>
        /// 0-param constructor.
        /// </summary>
        public TechSupportController()
        {
            this.incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// Returns the contents of the Incident Report list.
        /// </summary>
        /// <returns>List of Incident objects</returns>
        public List<Incident> GetIncidents()
        {
            return this.incidentSource.GetIncidents();
        }

        public List<Incident> GetIncidentsByCustomerID(int customerID)
        { 
            return this.incidentSource.GetIncidentsByCustomerID(customerID);
        }

        /// <summary>
        /// Adds an incident report to the list.
        /// </summary>
        /// <param name="incident"></param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            this.incidentSource.Add(incident);
        }
    }
}
