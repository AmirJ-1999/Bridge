using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeTests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void Price_ShouldReturnFixedPrice()
        {
            // Arrange
            MC mc = new MC();

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(120, price);
        }

        [TestMethod]
        public void VehicleType_ShouldReturnMC()
        {
            // Arrange
            MC mc = new MC();

            // Act
            string type = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", type);
        }
    }
}