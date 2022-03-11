using System;

namespace TechSupport.Model
{
    /// <summary>
    /// This class models a Tech Support Technician.
    /// </summary>
    public class Technician
    {
        public int TechnicianID { get; set; }
        public string TechnicianName { get; set; }
        public string TechnicianEmail { get; set; }
        public string TechnicianPhone { get; set; }

        /// <summary>
        /// 0-param constructor
        /// </summary>
        public Technician()
        {

        }
    }
}
