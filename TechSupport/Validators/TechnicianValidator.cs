using System;
using TechSupport.Model;

namespace TechSupport.Validators
{
    public class TechnicianValidator
    {

        /// <summary>
        /// Validates that an technician object is not null.
        /// </summary>
        /// <param name="incident"></param>
        public static void ValidateTechnicianNotNull(Technician technician)
        {
            if (technician == null)
            {
                throw new ArgumentException("Technician cannot be null", "technician");
            }
        }
    }
}
