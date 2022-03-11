using System;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class serves as a precondition
    /// validator for TechSupport DB actions.
    /// </summary>
    public class IncidentValidator
    {
        /// <summary>
        /// Validates that an incident object is not null.
        /// </summary>
        /// <param name="incident"></param>
        public static void ValidateIncidentNotNull(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("Incident cannot be null", "incident");
            }
        }

        /// <summary>
        /// Validates a row exists within
        /// TechSupport db Incidents table
        /// by Incident ID.
        /// </summary>
        /// <param name="incident"></param>
        public static void ValidateIncidentExists(Incident incident)
        {
            ValidateIncidentNotNull(incident);
            string selectStatement = "SELECT COUNT(*) " +
                                      "FROM Incidents " +
                                      "WHERE IncidentID = @incidentid";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("incidentid", incident.IncidentID);

                    if (!Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        throw new ArgumentException("An incident with that ID does not exist");
                    }
                }
            }
        }

        /// <summary>
        /// Checks if the Incident is
        /// assigned to a valid technician by name.
        /// </summary>
        /// <param name="incident"></param>
        public static void ValidateTechnicianNameExists(Incident incident)
        {
            ValidateIncidentNotNull(incident);
            string selectStatement = "SELECT COUNT(*) " +
                                     "FROM Technicians " +
                                     "WHERE Name = @technician";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("technician", incident.Technician);
                    if (!Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        throw new ArgumentException("A technician with that name does not exist");
                    }
                }
            }
        }
    }
}
