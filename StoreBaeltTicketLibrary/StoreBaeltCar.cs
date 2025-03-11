using System;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Specialized Car class for Storebæltsbroen with weekend and Brobizz discounts.
    /// </summary>
    public class StoreBaeltCar : Car
    {
        /// <summary>
        /// Calculates the final price including weekend and Brobizz discounts.
        /// </summary>
        public new double Price()
        {
            double price = base.Price();

            // Weekend discount (15%)
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price *= 0.85; // 15% discount
            }

            // Brobizz discount applied afterwards
            return Brobizz ? price * 0.90 : price;
        }
    }
}