using System;

namespace Bridge
{
    /// <summary>
    /// Abstract class represents a generic vehicle.
    /// </summary>
    public abstract class Vehicle
    {
        private string _licenseplate;

        /// <summary>
        /// Gets or sets the vehicle's license plate. Cannot exceed 7 characters.
        /// </summary>
        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("License plate cannot exceed 7 characters.");
                _licenseplate = value;
            }
        }

        /// <summary>
        /// Gets or sets the date associated with the vehicle crossing the bridge.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price for crossing the bridge.
        /// </summary>
        public abstract double Price();

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        public abstract string VehicleType();
    }
}