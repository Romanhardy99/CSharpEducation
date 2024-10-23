using Phonebook;
using NUnit.Framework;
using System.Reflection.Metadata;

namespace PhoneNumber.Tests
{

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var expectedNumber = "123456789";
            var expectedType = PhoneNumberType.Mobile;

            // Act
            var phoneNumber = new Phonebook.PhoneNumber(expectedNumber, expectedType);

            // Assert
            Assert.AreEqual(expectedNumber, phoneNumber.Number);
            Assert.AreEqual(expectedType, phoneNumber.Type);
        }

        [Test]
        public void Number_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedNumber = "987654321";
            var phoneNumber = new Phonebook.PhoneNumber(expectedNumber, PhoneNumberType.Personal);

            // Act & Assert
            Assert.AreEqual(expectedNumber, phoneNumber.Number);
        }

        [Test]
        public void Type_ShouldReturnCorrectValue()
        {
            // Arrange
            var expectedType = PhoneNumberType.Work;
            var phoneNumber = new Phonebook.PhoneNumber("555555555", expectedType);

            // Act & Assert
            Assert.AreEqual(expectedType, phoneNumber.Type);
        }
    }
}
