using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;

namespace BridgeTests
{
    [TestClass]
    public class StoreBaeltCarTests
    {
        /// <summary>
        /// Test that price without any discount returns the full price (230 kr).
        /// </summary>
        [TestMethod]
        public void Price_NoDiscounts_ShouldReturn230()
        {
            // Arrange
            StoreBaeltCar car = new StoreBaeltCar { Date = new DateTime(2025, 12, 1), Brobizz = false }; // Monday

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(230, price, 0.01);
        }

        /// <summary>
        /// Test that weekend discount (15%) is correctly applied on Saturday or Sunday.
        /// </summary>
        [TestMethod]
        public void Price_WeekendDiscountOnly_ShouldReturn195_5()
        {
            // Arrange
            StoreBaeltCar car = new StoreBaeltCar { Date = new DateTime(2025, 12, 6), Brobizz = false }; // Saturday

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(195.5, price, 0.01);
        }

        /// <summary>
        /// Test that Brobizz discount (10%) is correctly applied on a weekday (Monday).
        /// </summary>
        [TestMethod]
        public void Price_BrobizzDiscountOnly_ShouldReturn207()
        {
            // Arrange
            StoreBaeltCar car = new StoreBaeltCar { Date = new DateTime(2025, 12, 1), Brobizz = true }; // Monday

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(207, price, 0.01);
        }

        /// <summary>
        /// Test that both weekend discount (15%) and Brobizz discount (10%) are applied correctly (in that order).
        /// </summary>
        [TestMethod]
        public void Price_WeekendAndBrobizzDiscount_ShouldReturn175_95()
        {
            // Arrange
            StoreBaeltCar car = new StoreBaeltCar { Date = new DateTime(2025, 12, 7), Brobizz = true }; // Sunday

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(175.95, price, 0.01);
        }
    }
}