using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeTests
{
    [TestClass]
    public class VehicleTests
    {
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
