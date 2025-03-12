using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using Bridge;
using System.Linq;

namespace BridgeTests
{
    [TestClass]
    public class TicketRepositoryTests
    {
        private TicketRepository repository;

        [TestInitialize]
        public void Setup()
        {
            repository = new TicketRepository();

            // Clear the repository before each test
            repository.ClearAllTickets();
        }

        /// <summary>
        /// Tests that a ticket is successfully added to the repository.
        /// </summary>
        [TestMethod]
        public void AddTicket_ShouldAddTicketToRepository()
        {
            // Arrange
            Vehicle car = new StoreBaeltCar { Licenseplate = "AB1234", Brobizz = false };

            // Act
            repository.AddTicket(car);
            bool isTicketAdded = repository.GetAllTickets().Contains(car);

            // Assert
            Assert.IsTrue(isTicketAdded);
        }

        /// <summary>
        /// Tests that retrieving tickets by license plate returns the correct number of tickets.
        /// </summary>
        [TestMethod]
        public void GetTicketsByLicenseplate_ShouldReturnCorrectTicketCount()
        {
            // Arrange
            Vehicle car1 = new StoreBaeltCar { Licenseplate = "AJ1999", Brobizz = true };
            Vehicle car2 = new StoreBaeltCar { Licenseplate = "AJ1999", Brobizz = false };
            Vehicle car3 = new StoreBaeltCar { Licenseplate = "AJ1234", Brobizz = true };

            repository.AddTicket(car1);
            repository.AddTicket(car2);
            repository.AddTicket(car3);

            // Act
            var filteredTickets = repository.GetTicketsByLicenseplate("AJ1999");

            // Assert
            Assert.AreEqual(2, filteredTickets.Count());
        }

        /// <summary>
        /// Tests that retrieving tickets by license plate returns the correct specific ticket.
        /// </summary>
        [TestMethod]
        public void GetTicketsByLicenseplate_ShouldContainCorrectTicket()
        {
            // Arrange
            Vehicle car = new StoreBaeltCar { Licenseplate = "AJ12345", Brobizz = true };

            repository.AddTicket(car);

            // Act
            var filteredTickets = repository.GetTicketsByLicenseplate("AJ12345");

            // Assert
            Assert.IsTrue(filteredTickets.Contains(car));
        }
    }
}
