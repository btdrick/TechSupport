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
        private static List<Incident> _incidents = new List<Incident>
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
