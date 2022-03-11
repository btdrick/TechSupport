using System;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the TechSupport DB Registrations table.
    /// </summary>
    public class RegistrationsDAL
    {
        /// <summary>
        /// Checks if product is registered to a customer.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns></returns>
        public static bool ProductIsRegisteredToCustomer(Incident incident)
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
    }
}
