using System;

namespace Bridge
{
    /// <summary>
    /// Represents a Motorcycle (MC) vehicle.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returns the fixed price for crossing the bridge with an MC.
        /// </summary>
        /// <returns>The fixed price of 120 kr.</returns>
        public override double Price()
        {
            return 120;
        }

        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>Returns the string "MC".</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
