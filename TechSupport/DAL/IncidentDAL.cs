using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the TechSupport DB Incidents table.
    /// </summary>
    public class IncidentDAL
    {
        /// <summary>
        /// Retrieves incidents from TechSupport db.
        /// </summary>
        /// <returns>List of all incident objects</returns>
        public List<Incident> GetIncidents()
        {
            List<Incident> openIncidents = new List<Incident>();
            string selectStatement = "SELECT i.ProductCode, i.DateOpened, c.Name AS 'Customer', t.Name AS 'Technician', i.Title " +
                                        "FROM Incidents i " +
                                        "LEFT JOIN Customers c ON i.CustomerID = c.CustomerID " +
                                        "LEFT JOIN Technicians t ON i.TechID = t.TechID " +
                                        "WHERE i.DateClosed IS NULL";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Incident incident = new Incident
                            {
                                ProductCode = reader["ProductCode"].ToString(),
                                DateOpened = (DateTime)reader["DateOpened"],
                                Customer = reader["Customer"].ToString(),
                                Technician = reader["Technician"].ToString(),
                                Title = reader["Title"].ToString()
                            };
                            openIncidents.Add(incident);
                        }
                    }
                }
            }

            return openIncidents;
        }

        /// <summary>
        /// Retrieves Incident information based on
        /// an incident object with an ID value.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns>Incident object assigned to ID</returns>
        public Incident GetIncidentByID(Incident incident)
        {
            IncidentValidator.ValidateIncidentExists(incident);
            string selectStatement = "SELECT i.CustomerID, i.ProductCode, i.TechID, i.Title, i.DateOpened, i.DateClosed, i.\"Description\" " +
                                     "FROM Incidents i WHERE i.IncidentID = @incidentid";


            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("incidentid", incident.IncidentID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            incident.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            CustomerDAL customerDAL = new CustomerDAL();
                            incident.Customer = customerDAL.GetCustomerByID(incident);
                            incident.ProductCode = reader["ProductCode"].ToString();
                            if (!reader.IsDBNull(2))
                            {
                                incident.TechID = Convert.ToInt32(reader["TechID"].ToString());
                                incident.Technician = this.GetTechnicianByID(incident);
                            }
                            incident.Title = reader["Title"].ToString();
                            incident.DateOpened = (DateTime)reader["DateOpened"];
                            if (!reader.IsDBNull(5))
                            {
                                incident.DateClosed = (DateTime)reader["DateClosed"];
                            }
                            incident.Description = reader["Description"].ToString();
                        }
                    }
                }
            }

            return incident;
        }

        /// <summary>
        /// Adds a new open incident to the TechSupport db.
        /// </summary>
        /// <param name="incident"></param>
        public void AddOpenIncident(Incident incident)
        {
            IncidentValidator.ValidateIncidentNotNull(incident);
            if (InvalidNewIncidentFields(incident))
            {
                throw new ArgumentException("Invalid incident. One or more values are either null or invalid");
            }
            if (incident.CustomerID == 0)
            {
                CustomerDAL customerDAL = new CustomerDAL();
                incident.CustomerID = customerDAL.GetCustomerIDByName(incident);
            }
            if (incident.ProductCode == null || incident.ProductCode == "")
            {
                ProductDAL productDAL = new ProductDAL();
                incident.ProductCode = productDAL.GetProductCodeByName(incident);
            }

            string insertStatement = "INSERT INTO Incidents (CustomerID, ProductCode, DateOpened, Title, \"Description\") " +
                                     "VALUES(@customerid, @productcode, @dateopened, @title, @description) " +
                                     "SELECT SCOPE_IDENTITY()";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(insertStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("customerid", incident.CustomerID);
                    selectCommand.Parameters.AddWithValue("productcode", incident.ProductCode);
                    selectCommand.Parameters.AddWithValue("dateopened", incident.DateOpened);
                    selectCommand.Parameters.AddWithValue("title", incident.Title);
                    selectCommand.Parameters.AddWithValue("description", incident.Description);
                    incident.IncidentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Updates row in Incidents table
        /// matching incidentID.
        /// </summary>
        /// <param name="oldIncident"></param>
        /// <param name="newIncident"></param>
        public void UpdateIncident(Incident oldIncident, Incident newIncident)
        {
            IncidentValidator.ValidateIncidentExists(oldIncident);
            IncidentValidator.ValidateIncidentExists(newIncident);
            string updateStatement = "UPDATE Incidents " +
                                     "SET TechID = @techid, \"Description\" = replace(@newDescription, '\n', char(13)+char(10)) " +
                                     "WHERE IncidentID = @oldIncidentid " + 
                                     "AND DateClosed IS NULL " +
                                     "AND \"Description\" = @oldDescription";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(updateStatement, connection))
                {
                    if (newIncident.Technician == null)
                    {
                        selectCommand.Parameters.AddWithValue("techid", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("techid", this.GetTechnicianIDByTechnicianName(newIncident));
                    }
                    selectCommand.Parameters.AddWithValue("newDescription", newIncident.Description);
                    selectCommand.Parameters.AddWithValue("oldIncidentid", oldIncident.IncidentID); 
                    selectCommand.Parameters.AddWithValue("oldDescription", oldIncident.Description);
                    selectCommand.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Returns true if an incident has been closed.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns>Incident closed?</returns>
        public bool IsIncidentClosed(Incident incident)
        {
            IncidentValidator.ValidateIncidentNotNull(incident);
            return incident.DateClosed.ToShortDateString() != "1/1/0001";
        }

        /// <summary>
        /// Closes an incident, sets
        /// DateClosed to current date.
        /// </summary>
        /// <param name="incident"></param>
        public void CloseOpenIncident(Incident oldIncident, Incident newIncident)
        {
            IncidentValidator.ValidateIncidentExists(oldIncident);
            IncidentValidator.ValidateIncidentExists(newIncident);
            string updateStatement = "UPDATE Incidents " +
                                     "SET DateClosed = @today " +
                                     "WHERE IncidentID = @oldIncidentid " +
                                     "AND DateClosed IS NULL " +
                                     "AND \"Description\" = @oldDescription";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(updateStatement, connection))
                {                   
                    selectCommand.Parameters.AddWithValue("today", newIncident.DateClosed);
                    selectCommand.Parameters.AddWithValue("oldIncidentid", oldIncident.IncidentID);
                    selectCommand.Parameters.AddWithValue("oldDescription", oldIncident.Description);
                    selectCommand.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Retrieves the name of a Technician
        /// using their assigned ID.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns>Technician name assigned to ID</returns>
        public string GetTechnicianByID(Incident incident)
        {
            IncidentValidator.ValidateIncidentNotNull(incident);
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

        /// <summary>
        /// Retrieves the TechID for the technician
        /// assigned to an Incident.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns></returns>
        public int GetTechnicianIDByTechnicianName(Incident incident)
        {
            IncidentValidator.ValidateTechnicianNameExists(incident);
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

        /// <summary>
        /// Validates whether an incident object has the fields 
        /// needed to be added to the TechSupport db.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns>True if incident object is valid to add</returns>
        private bool InvalidNewIncidentFields(Incident incident)
        {
            if (((incident.Customer == null || incident.Customer == "") && incident.CustomerID <= 0) ||
                ((incident.Product == null || incident.Product == "") && 
                (incident.ProductCode == null || incident.ProductCode == "")) ||
                incident.DateOpened == null || incident.Title == null || incident.Title == "" ||
                incident.Description == null || incident.Description == "")
            {
                return true;
            }
            
            return false;
            
        }
    }
}
