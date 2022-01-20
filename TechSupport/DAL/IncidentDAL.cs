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
            new Incident("Lost Password", "none", 34)
        };
    }
}
