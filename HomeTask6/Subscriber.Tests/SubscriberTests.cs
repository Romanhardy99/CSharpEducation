using Phonebook;

namespace Subscriber.Tests
{
    [TestFixture]
    public class SubscriberTests
    {

        [Test]
        public void Equals_ShouldReturnTrueForSameId()
        {
            //Arrange
            var id = Guid.NewGuid();
            var phoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber("12345", PhoneNumberType.Mobile)
            };
            var subscriber1 = new Phonebook.Subscriber(id, "Jon", phoneNumbers);
            var subscriber2 = new Phonebook.Subscriber(id, "Max", phoneNumbers);

            //Act
            var result = subscriber1.Equals(subscriber2);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void GetHashCode_ShouldReturnId()
        {
            //Arrange
            var id = Guid.NewGuid();
            var subscriber = new Phonebook.Subscriber(id, "Egor", new List<PhoneNumber>());

            //Act
            var result = subscriber.GetHashCode();

            //Assert
            Assert.AreEqual(id.GetHashCode(), result);
        }

        [Test]
        public void Constructor_ShouldInitProp()
        {
            //Arrange
            var name = "name";
            var phoneNumbers = new List<PhoneNumber> { new PhoneNumber("12345", PhoneNumberType.Mobile) };

            //Act
            var subscriber = new Phonebook.Subscriber(name, phoneNumbers);
            
            //Assert
            Assert.AreEqual(name, subscriber.Name);
            Assert.AreEqual(phoneNumbers, subscriber.PhoneNumbers);
            Assert.AreNotEqual(Guid.Empty, subscriber.Id);  
        }
    }
}
