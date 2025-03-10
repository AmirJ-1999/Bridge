using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        // Test that the Price method returns the fixed price of 230 kr.
        public void Price_ShouldReturnFixedPrice()
        {
            // Arrange
            Car car = new Car();

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(230, price);
        }

        [TestMethod]
        // Test that the VehicleType method returns "Car".
        public void VehicleType_ShouldReturnCar()
        {
            // Arrange
            Car car = new Car();

            // Act
            string type = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", type);
        }

        [TestMethod]
        // Test that the GetPriceWithDiscount method returns the price with the Brobizz discount applied.
        public void GetPriceWithDiscount_ShouldReturnPriceWithBrobizzDiscount()
        {
            // Arrange
            Car car = new Car { Brobizz = true };

            // Act
            double discountedPrice = car.GetPriceWithDiscount();

            // Assert (with delta tolerance)
            Assert.AreEqual(207, discountedPrice, 0.001);
        }
    }
}