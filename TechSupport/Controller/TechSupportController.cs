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
        private readonly IncidentDAL incidentInternalSource;
        private readonly IncidentDBDAL incidentDBSource;

        /// <summary>
        /// 0-param constructor.
        /// </summary>
        public TechSupportController()
        {
            this.incidentInternalSource = new IncidentDAL();
            this.incidentDBSource = new IncidentDBDAL();
        }

        /// <summary>
        /// Returns the contents of the Incident Report list.
        /// </summary>
        /// <returns>List of Incident objects</returns>
        public List<Incident> GetInternalIncidents()
        {
            return this.incidentInternalSource.GetIncidents();
        }

        /// <summary>
        /// Get internal incidents assigned to a customerID.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public List<Incident> GetInternalIncidentsByCustomerID(int customerID)
        {
            return this.incidentInternalSource.GetIncidentsByCustomerID(customerID);
        }

        /// <summary>
        /// Adds an incident report to the list.
        /// </summary>
        /// <param name="incident"></param>
        public void AddInternalIncident(Incident incident)
        {
            this.incidentInternalSource.Add(incident);
        }

        /// <summary>
        /// Add an open incident to TechSupport db source.
        /// </summary>
        /// <param name="incident"></param>
        public void AddOpenIncident(Incident incident)
        {
            this.incidentDBSource.AddOpenIncident(incident);
        }

        /// <summary>
        /// Gets the open incidents from TechSupport db source.
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetOpenIncidents()
        {
            return this.incidentDBSource.GetIncidents();
        }

        /// <summary>
        /// Gets all customers from TechSupport db source.
        /// </summary>
        /// <returns></returns>
        public List<string> GetCustomerNames()
        {
            return this.incidentDBSource.GetCustomerNames();
        }

        /// <summary>
        /// Gets all products from TechSupport db source.
        /// </summary>
        /// <returns></returns>
        public List<string> GetProductNames()
        {
            return this.incidentDBSource.GetProductNames();
        }

        /// <summary>
        /// Validates whether a customer has registered a product
        /// by customer name and product name.
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="productName"></param>
        /// <returns></returns>
        public bool ValidateExistingProductRegistration(string customerName, string productName)
        {
            return this.incidentDBSource.ProductIsRegisteredToCustomer(customerName, productName);
        }

        /// <summary>
        /// Gets most recent Incident ID from
        /// TechSupport db.
        /// </summary>
        /// <returns></returns>
        public int GetLastIncidentID()
        {
            return this.incidentDBSource.GetLastIncidentID();
        }
    }
}
