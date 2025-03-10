using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeTests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        // Test that the Price method returns the fixed price of 120 kr.
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
        // Test that the VehicleType method returns "MC".
        public void VehicleType_ShouldReturnMC()
        {
            // Arrange
            MC mc = new MC();

            // Act
            string type = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", type);
        }

        [TestMethod]
        // Test that the GetPriceWithDiscount method returns the price with the Brobizz discount applied.
        public void GetPriceWithDiscount_ShouldReturnPriceWithBrobizzDiscount()
        {
            // Arrange
            MC mc = new MC { Brobizz = true };

            // Act
            double discountedPrice = mc.GetPriceWithDiscount();

            // Assert
            Assert.AreEqual(108, discountedPrice, 0.001);
        }
    }
}
