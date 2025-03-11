using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeTests
{
    [TestClass]
    public class CarTests
    {
        /// <summary>
        /// Test that the Price method returns the fixed price of 230 kr.
        /// </summary>
        [TestMethod]
        public void Price_ShouldReturnFixedPrice()
        {
            // Arrange
            Car car = new Car();

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(230, price);
        }

        /// <summary>
        /// Test that the VehicleType method correctly returns "Car".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnCar()
        {
            // Arrange
            Car car = new Car();

            // Act
            string type = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", type);
        }

        /// <summary>
        /// Test that the GetPriceWithDiscount method applies the 10% Brobizz discount correctly.
        /// </summary>
        [TestMethod]
        public void GetPriceWithDiscount_ShouldReturnPriceWithBrobizzDiscount()
        {
            // Arrange
            Car car = new Car { Brobizz = true };

            // Act
            double discountedPrice = car.GetPriceWithDiscount();

            // Assert
            Assert.AreEqual(207, discountedPrice, 0.001);
        }
    }
}