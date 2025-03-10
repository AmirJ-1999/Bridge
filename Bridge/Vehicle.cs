using System;

namespace Bridge
{
    /// <summary>
    /// Represents a generic vehicle.
    /// </summary>
    public abstract class Vehicle
    {
        private string _licenseplate;

        /// <summary>
        /// Gets or sets the license plate (max 7 chars).
        /// </summary>
        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("Licenseplate cannot exceed 7 characters.");
                _licenseplate = value;
            }
        }

        /// <summary>
        /// Date of the bridge crossing.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Indicates whether Brobizz discount applies.
        /// </summary>
        public bool Brobizz { get; set; } = false;

        /// <summary>
        /// Calculates the price with optional Brobizz discount.
        /// </summary>
        /// <returns>Price as double.</returns>
        public double GetPriceWithDiscount()
        {
            double price = Price();
            return Brobizz ? price * 0.90 : price;
        }

        public abstract double Price();
        public abstract string VehicleType();
    }
}