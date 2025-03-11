using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BridgeTests
{
    [TestClass]
    public class VehicleTests
    {
        /// <summary>
        /// Test that the Licenseplate property throws an exception 
        /// when the assigned license plate exceeds 7 characters.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Licenseplate_WhenLongerThan7Characters_ShouldThrowException()
        {
            // Arrange
            Vehicle car = new Car();

            // Act
            car.Licenseplate = "12345678"; // 8 characters, exceeds the limit of 7

            // Assert is handled by ExpectedException attribute
        }
    }
}