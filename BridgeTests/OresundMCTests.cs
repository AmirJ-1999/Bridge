using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary;

namespace BridgeTests
{
    [TestClass]
    public class OresundMCTests
    {
        /// <summary>
        /// Tests the regular MC price (235 kr).
        /// </summary>
        [TestMethod]
        public void Price_NoBrobizz_ShouldReturn235()
        {
            // Arrange
            OresundMC mc = new OresundMC { Brobizz = false };

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(235, price, 0.01);
        }

        /// <summary>
        /// Tests Brobizz discounted price for MC (92 kr).
        /// </summary>
        [TestMethod]
        public void Price_WithBrobizz_ShouldReturn92()
        {
            // Arrange
            OresundMC mc = new OresundMC { Brobizz = true };

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(92, price, 0.01);
        }

        /// <summary>
        /// Tests VehicleType returns "Oresund MC".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnOresundMC()
        {
            // Arrange
            OresundMC mc = new OresundMC();

            // Act
            string type = mc.VehicleType();

            // Assert
            Assert.AreEqual("Oresund MC", type);
        }
    }
}