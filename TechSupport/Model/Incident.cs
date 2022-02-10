using System;

namespace TechSupport.Model
{
    /// <summary>
    /// This class models a Tech Support Incident Report.
    /// </summary>
    public class Incident
    {
        public DateTime DateOpened { get; set; }
        public string Product { get; set; }
        public string ProductCode { get; set; }
        public string Title { get; set;  }
        public string Description { get; set; }
        public string Technician { get; set; }
        public string Customer { get; set; }
        public int CustomerID { get; set;  }        
        
        /// <summary>
        /// 0-param constructor
        /// </summary>
        public Incident()
        {

        }
        
        /// <summary>
        /// 3-param constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="customerid"></param>
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
                throw new ArgumentException("CustomerID must be greater than 0", "customerid");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerid;
        }
    }
}
