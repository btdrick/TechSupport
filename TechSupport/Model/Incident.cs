using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// This class models a Tech Support Incident Report.
    /// </summary>
    public class Incident
    {
        public string Title { get; }
        public string Description { get; }
        public int CustomerID { get; }

        public Incident(string title, string description, int customerid)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Incident title cannot be null or empty", "title");
            }
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Incident description cannot be null or empty", "description");
            }
            if (customerid < 1)
            {
                throw new ArgumentException("Invalid CustomerID", "customerid");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerid;
        }
    }
}
