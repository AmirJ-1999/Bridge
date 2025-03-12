using Bridge;

namespace OresundbronTicketLibrary
{
    /// <summary>
    /// A MC class for Oresundbron bridge with specific prices.
    /// </summary>
    public class OresundMC : MC
    {
        /// <summary>
        /// Calculates the price of the Oresund MC based on the use of Brobizz.
        /// </summary>
        /// <returns>Returns the price as a double. If Brobizz is used, the price is 92; otherwise, it is 235.</returns>
        public override double Price()
        {
            return Brobizz ? 92 : 235;
        }
        
        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>Returns the string "Oresund MC".</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}