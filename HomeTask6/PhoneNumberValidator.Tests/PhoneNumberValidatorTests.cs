using NUnit.Framework;
using Phonebook;

namespace PhoneNumberValidator.Tests
{

    public class PhoneNumberValidatorTests
    {
        [Test]
        public void Validate_ValidPhoneNumber_DoesNotThrowException()
        {
            // Arrange
            var validPhoneNumber = new PhoneNumber("+7 (123) 123-1234", PhoneNumberType.Mobile);

            // Act & Assert
            Assert.DoesNotThrow(() => Phonebook.PhoneNumberValidator.Validate(validPhoneNumber));
        }

        [Test]
        public void Validate_InvalidPhoneNumber_ThrowsArgumentException()
        {
            // Arrange
            var invalidPhoneNumber = new PhoneNumber("+7234567890", PhoneNumberType.Mobile);

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => Phonebook.PhoneNumberValidator.Validate(invalidPhoneNumber));
            Assert.That(ex.Message, Is.EqualTo("Phone number is invalid"));
        }

        [Test]
        public void ValidateList_ValidPhoneNumbers_DoesNotThrowException()
        {
            // Arrange
            var validPhoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber("+7 (234) 567-4890", PhoneNumberType.Mobile),
                new PhoneNumber("+7 (031) 234-4567", PhoneNumberType.Work)
            };

            // Act & Assert
            Assert.DoesNotThrow(() => Phonebook.PhoneNumberValidator.ValidateList(validPhoneNumbers));
        }

        [Test]
        public void ValidateList_InvalidPhoneNumbers_ThrowsArgumentException()
        {
            // Arrange
            var phoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber("+7 (234) 567-4890", PhoneNumberType.Mobile),
                new PhoneNumber("4567890", PhoneNumberType.Personal) // Invalid
            };

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => Phonebook.PhoneNumberValidator.ValidateList(phoneNumbers));
            Assert.That(ex.Message, Is.EqualTo("Phone number is invalid"));
        }
    }
}