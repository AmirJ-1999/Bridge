using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary;

namespace BridgeTests
{
    [TestClass]
    public class OresundCarTests
    {
        /// <summary>
        /// Tests the regular price (460 kr) without Brobizz.
        /// </summary>
        [TestMethod]
        public void Price_NoBrobizz_ShouldReturn460()
        {
            // Arrange
            OresundCar car = new OresundCar { Brobizz = false };

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(460, price, 0.01);
        }

        /// <summary>
        /// Tests Brobizz discounted price (178 kr).
        /// </summary>
        [TestMethod]
        public void Price_WithBrobizz_ShouldReturn178()
        {
            // Arrange
            OresundCar car = new OresundCar { Brobizz = true };

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(178, price, 0.01);
        }

        /// <summary>
        /// Tests VehicleType returns "Oresund car".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnOresundCar()
        {
            // Arrange
            OresundCar car = new OresundCar();

            // Act
            string type = car.VehicleType();

            // Assert
            Assert.AreEqual("Oresund car", type);
        }
    }
}
