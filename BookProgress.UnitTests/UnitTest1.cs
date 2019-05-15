using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookProgress.UnitTests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void IsHalfPassed_LessThanHalf_ReturnsFalse()
        {
            //Arrange
            var reservation = new Book(1,1);
            //Act
            var result = Book.IsHalfPassed(reservation);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsHalfPassed_MoreThanHalf_ReturnsTrue()
        {
            //Arrange
            var reservation1 = new Book(100, 1);
            //Act
            reservation1.current_page = 51;
            var result = Book.IsHalfPassed(reservation1);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsHalfPassed_MoreThanWhole_ReturnsFalse()
        {
            //Arrange
            var reservation1 = new Book(100, 1);
            //Act
            reservation1.current_page = 200;
            var result = Book.IsHalfPassed(reservation1);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
