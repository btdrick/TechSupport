using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the TechSupport DB Products table.
    /// </summary>
    public class ProductDBDAL
    {
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
        public string GetProductCodeByName(Incident incident)
        {
            DBDALValidator.ValidateIncidentNotNull(incident);
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
    }
}
