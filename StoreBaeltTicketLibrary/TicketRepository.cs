using System.Collections.Generic;
using System.Linq;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Repository class for managing tickets at Storebæltbroen.
    /// </summary>
    public class TicketRepository : ITicketRepository
    {
        // Static list to store tickets
        private static readonly List<Vehicle> _tickets = new List<Vehicle>();

        /// <summary>
        /// Adds a new ticket to the repository.
        /// </summary>
        public void AddTicket(Vehicle ticket)
        {
            _tickets.Add(ticket);
        }

        /// <summary>
        /// Retrieves all tickets stored in the repository.
        /// </summary>
        public IEnumerable<Vehicle> GetAllTickets()
        {
            return _tickets;
        }

        /// <summary>
        /// Retrieves tickets filtered by a given license plate.
        /// </summary>
        public IEnumerable<Vehicle> GetTicketsByLicenseplate(string licenseplate)
        {
            return _tickets.FindAll(t => t.Licenseplate == licenseplate);
        }

        /// <summary>
        /// Clears all tickets from the repository. 
        /// Used mainly for testing purposes.
        /// </summary>
        public void ClearAllTickets()
        {
            _tickets.Clear();
        }
    }
}