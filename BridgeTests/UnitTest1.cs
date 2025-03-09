using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BridgeTests
{
    [TestClass]
    public class CarTests
    {
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
    }
}