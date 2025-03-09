using System;

namespace Bridge
{
    /// <summary>
    /// Abstract class representing a general vehicle.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Gets or sets the vehicle's license plate.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with the vehicle crossing the bridge.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price for crossing the bridge.
        /// </summary>
        /// <returns>Price as a double.</returns>
        public abstract double Price();

        /// <summary>
        /// Returns the vehicle type as a string.
        /// </summary>
        /// <returns>Vehicle type.</returns>
        public abstract string VehicleType();
    }
}