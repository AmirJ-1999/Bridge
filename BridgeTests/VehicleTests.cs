using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeTests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        // Test that the Licenseplate property can be set and retrieved.
        [ExpectedException(typeof(ArgumentException))]
        // Test that the Licenseplate property throws an exception when the license plate is longer than 7 characters.
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
