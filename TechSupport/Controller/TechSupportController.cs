﻿using System;
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
        private readonly IncidentDAL incidentDBSource;
        private readonly CustomerDAL customerDBSource;        
        private readonly ProductDAL productDBSource;
        private readonly RegistrationsDAL registrationDBSource;

        /// <summary>
        /// 0-param constructor.
        /// </summary>
        public TechSupportController()
        {
            this.incidentDBSource = new IncidentDAL();
            this.customerDBSource = new CustomerDAL();
            this.productDBSource = new ProductDAL();
            this.registrationDBSource = new RegistrationsDAL();
        }        

        //***TECHSUPPORT DB INCIDENT FUNCTIONS***

        /// <summary>
        /// Add an open incident to TechSupport db source.
        /// </summary>
        /// <param name="incident"></param>
        public void AddOpenIncident(Incident incident)
        {
            IncidentValidator.ValidateIncidentNotNull(incident);
            this.incidentDBSource.AddOpenIncident(incident);
        }

        /// <summary>
        /// Returns true if incident has been closed.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns></returns>
        public bool IsIncidentClosed(Incident incident)
        {
            IncidentValidator.ValidateIncidentNotNull(incident);
            return this.incidentDBSource.IsIncidentClosed(incident);
        }

        /// <summary>
        /// Closes an incident
        /// </summary>
        /// <param name="incident"></param>
        public void CloseIncident(Incident oldIncident, Incident newIncident)
        {
            IncidentValidator.ValidateIncidentExists(oldIncident);
            IncidentValidator.ValidateIncidentExists(newIncident);
            this.incidentDBSource.CloseOpenIncident(oldIncident, newIncident);
        }

        /// <summary>
        /// Updates a row from 
        /// TechSupport db Incidents table.
        /// </summary>
        /// <param name="incident"></param>
        public void UpdateIncident(Incident oldIncident, Incident newIncident)
        {
            IncidentValidator.ValidateIncidentExists(oldIncident);
            IncidentValidator.ValidateIncidentExists(newIncident);
            this.incidentDBSource.UpdateIncident(oldIncident, newIncident);
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
            IncidentValidator.ValidateIncidentNotNull(incident);
            return this.incidentDBSource.GetIncidentByID(incident);
        }

        //***TECHSUPPORT DB CUSTOMER FUNCTIONS***

        /// <summary>
        /// Gets all customers from TechSupport db source.
        /// </summary>
        /// <returns>List of customer names</returns>
        public List<string> GetCustomerNames()
        {
            return this.customerDBSource.GetCustomerNames();
        }

        //***TECHSUPPORT DB PRODUCT FUNCTIONS***

        /// <summary>
        /// Gets all products from TechSupport db source.
        /// </summary>
        /// <returns>List of product names</returns>
        public List<string> GetProductNames()
        {
            return this.productDBSource.GetProductNames();
        }

        //***TECHSUPPORT DB REGISTRATION FUNCTIONS***

        /// <summary>
        /// Validates whether a customer has registered a product
        /// by customer name and product name.
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="productName"></param>
        /// <returns>True if registration exists</returns>
        public bool ProductIsRegisteredToCustomer(Incident incident)
        {
            IncidentValidator.ValidateIncidentNotNull(incident);
            if (incident.Customer == null || incident.Customer == "")
            {
                throw new ArgumentException("Customer name cannot be null or empty");
            }
            if (incident.Product == null || incident.Product == "")
            {
                throw new ArgumentException("Product name cannot be null or empty");
            }
            return this.registrationDBSource.ProductIsRegisteredToCustomer(incident);
        }
    }
}
