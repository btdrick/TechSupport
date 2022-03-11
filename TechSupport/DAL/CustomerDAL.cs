using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the TechSupport DB Customers table.
    /// </summary>
    public class CustomerDAL
    {
        /// <summary>
        /// Retrieves customer names from TechSupport db.
        /// </summary>
        /// <returns>List of customer names</returns>
        public static List<string> GetCustomerNames()
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
        public static string GetCustomerByID(Incident incident)
        {
            IncidentValidator.ValidateIncidentNotNull(incident);
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
        public static int GetCustomerIDByName(Incident incident)
        {
            IncidentValidator.ValidateIncidentNotNull(incident);
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
    }
}
