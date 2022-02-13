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

        //***INTERNAL INCIDENT FUNCTIONS***

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
            if (customerID < 1)
            {
                throw new ArgumentException("CustomerID must be value greater than 0", "customerID");
            }
            return this.incidentInternalSource.GetIncidentsByCustomerID(customerID);
        }

        /// <summary>
        /// Adds an incident report to the list.
        /// </summary>
        /// <param name="incident"></param>
        public void AddInternalIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident cannot be null", "incident");
            }
            this.incidentInternalSource.Add(incident);
        }

        //***TECHSUPPORT DB INCIDENT FUNCTIONS***

        /// <summary>
        /// Add an open incident to TechSupport db source.
        /// </summary>
        /// <param name="incident"></param>
        public void AddOpenIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident cannot be null", "incident");
            }
            this.incidentDBSource.AddOpenIncident(incident);
        }

        /// <summary>
        /// Gets the open incidents from TechSupport db source.
        /// </summary>
        /// <returns>List of open incidents</returns>
        public List<Incident> GetOpenIncidents()
        {
            return this.incidentDBSource.GetIncidents();
        }

        /// <summary>
        /// Retrieves Incident information based on
        /// an incident object with an ID value.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns></returns>
        public Incident GetIncidentByID(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident cannot be null", "incident");
            }
            if (incident.IncidentID <= 0)
            {
                throw new ArgumentException("CustomerID cannot be less than 1");
            }
            return this.incidentDBSource.GetIncidentByID(incident);
        }

        /// <summary>
        /// Gets all customers from TechSupport db source.
        /// </summary>
        /// <returns>List of customer names</returns>
        public List<string> GetCustomerNames()
        {
            return this.incidentDBSource.GetCustomerNames();
        }


        /// <summary>
        /// Gets all technician names from TechSupport db source.
        /// </summary>
        /// <returns>List of technician names</returns>
        public List<string> GetTechnicianNames()
        {
            return this.incidentDBSource.GetTechnicianNames();
        }

        /// <summary>
        /// Gets all products from TechSupport db source.
        /// </summary>
        /// <returns>List of product names</returns>
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
        /// <returns>True if registration exists</returns>
        public bool ProductIsRegisteredToCustomer(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident cannot be null", "incident");
            }
            if (incident.Customer == null || incident.Customer == "")
            {
                throw new ArgumentException("Customer name cannot be null or empty");
            }
            if (incident.Product == null || incident.Product == "")
            {
                throw new ArgumentException("Product name cannot be null or empty");
            }
            return this.incidentDBSource.ProductIsRegisteredToCustomer(incident);
        }

        /// <summary>
        /// Gets most recent Incident ID from
        /// TechSupport db.
        /// </summary>
        /// <returns>Latest incident ID</returns>
        public int GetLastIncidentID()
        {
            return this.incidentDBSource.GetLastIncidentID();
        }
    }
}
