using System.Collections.Generic;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Defines the methods for a Ticket repository.
    /// </summary>
    public interface ITicketRepository
    {
        /// <summary>
        /// Adds a ticket to the repository.
        /// </summary>
        void AddTicket(Vehicle ticket);

        /// <summary>
        /// Gets all tickets from the repository.
        /// </summary>
        IEnumerable<Vehicle> GetAllTickets();

        /// <summary>
        /// Gets all tickets associated with a specific license plate.
        /// </summary>
        IEnumerable<Vehicle> GetTicketsByLicenseplate(string licenseplate);
    }
}