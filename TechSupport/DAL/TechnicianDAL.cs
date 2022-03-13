using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;
using TechSupport.Validators;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the TechSupport DB Technicians table.
    /// </summary>
    public class TechnicianDAL
    {

        /// <summary>
        /// Returns list of Technician objects 
        /// from Technicians table.
        /// </summary>
        /// <returns></returns>
        public static List<Technician> GetAllTechniciansWithIncidentHistory()
        {
            List<Technician> technicians = new List<Technician>();
            string selectStatement = "SELECT DISTINCT t.TechID, t.Name, t.Email, t.Phone " +
                                        "FROM Technicians t " +
                                        "JOIN Incidents i ON i.TechID = t.TechID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Technician technician = new Technician
                            {
                                TechnicianID = Convert.ToInt32(reader["TechID"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString(),
                            };
                            technicians.Add(technician);
                        }
                    }
                }
            }

            return technicians;
        }

        /// <summary>
        /// Retrieves Technician names from TechSupport db.
        /// </summary>
        /// <returns>List of technician names</returns>
        public static List<string> GetTechnicianNames()
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
        /// Returns a list of open incidents
        /// that are assigned to a Technician
        /// </summary>
        /// <param name="technician"></param>
        /// <returns></returns>
        public static List<Incident> GetOpenIncidentsAssignedToTechnician(Technician technician)
        {
            TechnicianValidator.ValidateTechnicianNotNull(technician);
            List<Incident> incidents = new List<Incident>();
            string selectStatement = "SELECT p.Name AS 'Product', i.DateOpened, c.Name AS 'Customer', i.Title " +
                                     "FROM Incidents i " +
                                     "LEFT JOIN Customers c ON i.CustomerID = c.CustomerID " +
                                     "LEFT JOIN Products p ON i.ProductCode = p.ProductCode " +
                                     "WHERE i.DateClosed IS NULL " +
                                     "AND i.TechID = @techID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("techID", technician.TechnicianID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Incident incident = new Incident
                            {
                                Product = reader["Product"].ToString(),
                                DateOpened = (DateTime)reader["DateOpened"],
                                Customer = reader["Customer"].ToString(),
                                Title = reader["Title"].ToString()
                            };                           
                            incidents.Add(incident);
                        }
                    }
                }
            }

            return incidents;
        }
    }
}
