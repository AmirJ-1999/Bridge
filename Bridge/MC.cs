using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents MotorCycle (MC) vehicle with license plate and date properties.
    /// </summary>
    public class MC
    {
        /// <summary>
        /// Gets or sets the Motocycle license plate.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Get or sets the date associated with the Motorcycle.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the fixed price for crossing the bridge with a Motorcycle.
        /// </summary>
        /// <returns>The fixed price of 120 kr.</returns>
        public double Price()
        {
            return 120;
        }

        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>Returns the string "MC".</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
