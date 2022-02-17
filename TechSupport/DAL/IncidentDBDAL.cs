using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Data Access Layer (DAL) for TechSupport database.
    /// </summary>
    public class IncidentDBDAL
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
            this.ValidateIncidentExists(incident);
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
                            incident.Customer = GetCustomerByID(incident);
                            incident.ProductCode = reader["ProductCode"].ToString();
                            if (!reader.IsDBNull(2))
                            {
                                incident.TechID = Convert.ToInt32(reader["TechID"].ToString());
                                incident.Technician = GetTechnicianByID(incident);
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
            this.ValidateIncidentNotNull(incident);
            if (InvalidNewIncidentFields(incident))
            {
                throw new ArgumentException("Invalid incident. One or more values are either null or invalid");
            }
            if (incident.CustomerID == 0)
            {
                incident.CustomerID = this.GetCustomerIDByName(incident);
            }
            if (incident.ProductCode == null || incident.ProductCode == "")
            {
                incident.ProductCode = this.GetProductCodeByName(incident);
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

        public void UpdateIncident(Incident incident)
        {
            this.ValidateIncidentExists(incident);           
            string updateStatement = "UPDATE Incidents " +
                                     "SET TechID = @techid, \"Description\" = replace(@description, '\n', char(13)+char(10)) " +
                                     "WHERE IncidentID = @incidentid";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(updateStatement, connection))
                {
                    if (incident.Technician == null)
                    {
                        selectCommand.Parameters.AddWithValue("techid", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("techid", this.GetTechnicianIDByTechnicianName(incident));
                    }
                    selectCommand.Parameters.AddWithValue("description", incident.Description);
                    selectCommand.Parameters.AddWithValue("incidentid", incident.IncidentID);
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
            this.ValidateIncidentNotNull(incident);
            return incident.DateClosed.ToShortDateString() != "1/1/0001";
        }

        /// <summary>
        /// Closes an incident, sets
        /// DateClosed to current date.
        /// </summary>
        /// <param name="incident"></param>
        public void CloseOpenIncident(Incident incident)
        {
            this.ValidateIncidentExists(incident);
            string updateStatement = "UPDATE Incidents " +
                                     "SET DateClosed = @today " +
                                     "WHERE IncidentID = @incidentid";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(updateStatement, connection))
                {                   
                    selectCommand.Parameters.AddWithValue("today", incident.DateClosed);
                    selectCommand.Parameters.AddWithValue("incidentid", incident.IncidentID);
                    selectCommand.ExecuteScalar();
                }
            }
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
        private string GetTechnicianByID(Incident incident)
        {
            this.ValidateIncidentNotNull(incident);
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

        private int GetTechnicianIDByTechnicianName(Incident incident)
        {
            this.ValidateTechnicianNameExists(incident);
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
        /// Retrieves customer names from TechSupport db.
        /// </summary>
        /// <returns>List of customer names</returns>
        public List<string> GetCustomerNames()
        {
            List<string> techSupportCustomerNames = new List<string>();
            string selectStatement = "SELECT Name FROM Customers";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            techSupportCustomerNames.Add(reader["Name"].ToString());
                        }
                    }
                }
            }

            return techSupportCustomerNames;
        }

        /// <summary>
        /// Retrieves the name of a Customer
        /// using their assigned ID.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns>Customer name assigned to ID</returns>
        private string GetCustomerByID(Incident incident)
        {
            this.ValidateIncidentNotNull(incident);
            if (incident.CustomerID < 1)
            {
                throw new ArgumentException("CustomerID cannot be less than 1");
            }
            string customerName = "";
            string selectStatement = "SELECT Name FROM Customers WHERE CustomerID = @customerid";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("customerid", incident.CustomerID);
                    customerName = Convert.ToString(selectCommand.ExecuteScalar());
                }
            }

            return customerName;
        }

        /// <summary>
        /// Retrieves a customer's ID
        /// from TechSupport db via their name.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns>CustomerID</returns>
        private int GetCustomerIDByName(Incident incident)
        {
            this.ValidateIncidentNotNull(incident);
            if (incident.Customer == null || incident.Customer == "")
            {
                throw new ArgumentException("Cannot use null or empty customer name");
            }
            int customerID = 0;
            string selectStatement = "SELECT CustomerID " +
                                     "FROM Customers " +
                                     "WHERE Name = @name";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("name", incident.Customer);
                    customerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }

            return customerID;
        }

        /// <summary>
        /// Retrieves product names from TechSupport db.
        /// </summary>
        /// <returns>List of Product names</returns>
        public List<string> GetProductNames()
        {
            List<string> techSupportProductNames = new List<string>();
            string selectStatement = "SELECT Name FROM Products";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            techSupportProductNames.Add(reader["Name"].ToString());
                        }
                    }
                }
            }

            return techSupportProductNames;
        }

        /// <summary>
        ///  Retrieves a product's code
        ///  from TechSupport db via their name.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns>ProductCode</returns>
        private string GetProductCodeByName(Incident incident)
        {
            this.ValidateIncidentNotNull(incident);
            if (incident.Product == null || incident.Product == "")
            {
                throw new ArgumentException("Cannot use null or empty product name");
            }
            string productCode = "";
            string selectStatement = "SELECT ProductCode " +
                                     "FROM Products " +
                                     "WHERE Name = @name";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("name", incident.Product);
                    productCode = Convert.ToString(selectCommand.ExecuteScalar());
                }
            }


            return productCode;
        }       

        /// <summary>
        /// Checks if product is registered to a customer.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns></returns>
        public bool ProductIsRegisteredToCustomer(Incident incident)
        {
            this.ValidateIncidentNotNull(incident);
            if (incident.Customer == null || incident.Customer == "")
            {
                throw new ArgumentException("Customer name cannot be null or empty");
            }
            if (incident.Product == null || incident.Product == "")
            {
                throw new ArgumentException("Product name cannot be null or empty");
            }

            bool registrationExists = false;
            string selectStatement = "SELECT COUNT(*) " +
                "FROM Registrations r " +
                "JOIN Customers c ON c.Name = @customer " +
                "JOIN Products p ON p.Name = @product " +
                "WHERE r.CustomerID = c.CustomerID " +
                "AND r.ProductCode = p.ProductCode";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("customer", incident.Customer);
                    selectCommand.Parameters.AddWithValue("product", incident.Product);
                    registrationExists = Convert.ToBoolean(selectCommand.ExecuteScalar());
                }
            }

            return registrationExists;
        }

        /// <summary>
        /// Validates that an incident object is not null.
        /// </summary>
        /// <param name="incident"></param>
        private void ValidateIncidentNotNull(Incident incident)
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
        private void ValidateIncidentExists(Incident incident)
        {
            this.ValidateIncidentNotNull(incident);
            string selectStatement =  "SELECT COUNT(*) " +
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
        private void ValidateTechnicianNameExists(Incident incident)
        {
            this.ValidateIncidentNotNull(incident);
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
