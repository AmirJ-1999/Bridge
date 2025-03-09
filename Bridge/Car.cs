using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a car vehicle with license plate and date properties.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the cars license plate.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with the car.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the fixed price for crossing the bridge.
        /// </summary>
        /// <returns>Fixed price of 230.</returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>Returns the string "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}
