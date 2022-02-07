using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Data Access Layer (DAL) for incidents submitted by user.
    /// </summary>
    public class IncidentDAL
    {
        /// <summary>
        /// List containing Incident objects.
        /// </summary>
        private static readonly List<Incident> _incidents = new List<Incident>
        {
            //Default incidents
            new Incident("Lost Password", "none", 34),
            new Incident("Mobile Login Issue", "Login button not functional on mobile application", 3)
        };

        /// <summary>
        /// Returns the list of Incident objects.
        /// </summary>
        /// <returns>Incidents List</returns>
        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Returns a list of incidents by CustomerID.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>Incidents by CustomerID</returns>
        public List<Incident> GetIncidentsByCustomerID(int customerID)
        {
            if (customerID < 1)
            {
                throw new ArgumentException("CustomerID must be value greater than 0", "customerID");
            }

            List<Incident> searchResults = new List<Incident>();
            searchResults = _incidents.FindAll(incident => incident.CustomerID == customerID);

            if (searchResults.Capacity == 0)
            {
                throw new ArgumentException("Customer either does not exist or hasn't submitted an incident report");
            }
            return searchResults;
        }

        /// <summary>
        /// Adds an Incident object to the list.
        /// </summary>
        /// <param name="incident"></param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            _incidents.Add(incident);
        }
    }
}
