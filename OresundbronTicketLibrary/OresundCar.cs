using Bridge;

namespace OresundbronTicketLibrary
{
    /// <summary>
    /// A Car class for Oresundbron bridge with specific prices.
    /// </summary>
    public class OresundCar : Car
    {
        /// <summary>
        /// Calculates the price of the Oresund car based on the use of Brobizz.
        /// </summary>
        /// <returns>Returns the price as a double. If Brobizz is used, the price is 178; otherwise, it is 460.</returns>
        public override double Price()
        {
            return Brobizz ? 178 : 460;
        }
        
        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>Returns the string "Oresund Car".</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}