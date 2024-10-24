using Phonebook;

namespace PhoneNumberValidatorTests
{
    [TestFixture]
    public class PhoneNumberValidatorTests 
    {
        [Test]
        public void Validate_ShouldNotThrow_WhenNumberIsValid()
        {
            // Arrange
            var validNumber = new PhoneNumber("+1 (234) 567-8901", PhoneNumberType.Mobile);

            // Act & Assert
            Assert.DoesNotThrow(() => PhoneNumberValidator.Validate(validNumber));
        }

        [Test]
        public void Validate_ShouldThrowArgumentException_WhenNumberIsInvalid()
        {
            // Arrange
            var invalidNumber = new PhoneNumber("1234567890", PhoneNumberType.Mobile);

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => PhoneNumberValidator.Validate(invalidNumber));
            Assert.That(ex.Message, Is.EqualTo("Phone number is invalid"));
        }

        [Test]
        public void ValidateList_ShouldNotThrow_WhenAllNumbersAreValid()
        {
            // Arrange
            var validNumbers = new List<PhoneNumber>
            {
                new PhoneNumber("+1 (234) 567-8901", PhoneNumberType.Mobile),
                new PhoneNumber("+44 (123) 456-7890", PhoneNumberType.Work)
            };

            // Act & Assert
            Assert.DoesNotThrow(() => PhoneNumberValidator.ValidateList(validNumbers));
        }

        [Test]
        public void ValidateList_ShouldThrowArgumentException_WhenAnyNumberIsInvalid()
        {
            // Arrange
            var mixedNumbers = new List<PhoneNumber>
            {
                new PhoneNumber("+1 (234) 567-8901", PhoneNumberType.Mobile),
                new PhoneNumber("1234567890", PhoneNumberType.Mobile) // Некорректный номер
            };

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => PhoneNumberValidator.ValidateList(mixedNumbers));
            Assert.That(ex.Message, Is.EqualTo("Phone number is invalid"));
        }
    }
}
