using System;

namespace TechSupport.Model
{
    /// <summary>
    /// This class models a Tech Support Technician.
    /// </summary>
    public class Technician
    {
        public int TechnicianID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        /// <summary>
        /// 0-param constructor
        /// </summary>
        public Technician()
        {

        }
    }
}
