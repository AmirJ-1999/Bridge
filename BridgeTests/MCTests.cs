using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeTests
{
    [TestClass]
    public class MCTests
    {
        /// <summary>
        /// Test that the Price method returns the fixed price of 120 kr.
        /// </summary>
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

        /// <summary>
        /// Test that the VehicleType method correctly returns "MC".
        /// </summary>
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

        /// <summary>
        /// Test that the GetPriceWithDiscount method applies the 10% Brobizz discount correctly.
        /// </summary>
        [TestMethod]
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