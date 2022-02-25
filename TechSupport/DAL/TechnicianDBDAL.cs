using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the TechSupport DB Technicians table.
    /// </summary>
    public class TechnicianDBDAL
    {
        /// <summary>
        /// Retrieves Technician names from TechSupport db.
        /// </summary>
        /// <returns>List of technician names</returns>
        public List<string> GetTechnicianNames()
        {
            List<string> techSupportTechnicianNames = new List<string>();
            string selectStatement = "SELECT Name FROM Technicians";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            techSupportTechnicianNames.Add(reader["Name"].ToString());
                        }
                    }
                }
            }

            return techSupportTechnicianNames;
        }

        /// <summary>
        /// Retrieves the name of a Technician
        /// using their assigned ID.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns>Technician name assigned to ID</returns>
        public static string GetTechnicianByID(Incident incident)
        {
            DBDALValidator.ValidateIncidentNotNull(incident);
            if (incident.TechID < 1)
            {
                throw new ArgumentException("TechnicianID cannot be less than 1");
            }
            string technicianName = "";
            string selectStatement = "SELECT Name FROM Technicians WHERE TechID = @technicianid";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("technicianid", incident.TechID);
                    technicianName = Convert.ToString(selectCommand.ExecuteScalar());
                }
            }

            return technicianName;
        }

        public static int GetTechnicianIDByTechnicianName(Incident incident)
        {
            DBDALValidator.ValidateTechnicianNameExists(incident);
            int techID = 0;
            string selectStatement = "SELECT TechID FROM Technicians WHERE Name = @technician";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("technician", incident.Technician);
                    techID = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }

            return techID;
        }

        
    }
}
