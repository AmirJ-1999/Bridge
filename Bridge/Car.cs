using System;

namespace Bridge
{
    /// <summary>
    /// Represents a car vehicle.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returns the fixed price for crossing the bridge with a Car.
        /// </summary>
        /// <returns>Fixed price of 230 kr.</returns>
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>Returns the string "Car".</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
