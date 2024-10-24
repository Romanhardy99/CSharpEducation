namespace Phonebook.Tests;

public class PhonebookTests
{
    private Phonebook phonebook;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        this.phonebook = new Phonebook();
    }

    [TearDown]
    public void TearDown()
    {
        this.phonebook.ClearPhonebookList();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        this.phonebook = null;
    }

    [Test]
    public void AddSubscriber_NewSubscriber_AddedSuccessfully()
    {
        //arrange
        var expectedSubscriber = new Subscriber(Guid.NewGuid(), "Roman", new List<PhoneNumber>());

        //act
        this.phonebook.AddSubscriber(expectedSubscriber);

        //assert
        Assert.That(this.phonebook.GetSubscriber(expectedSubscriber.Id), Is.EqualTo(expectedSubscriber));
    }

    [Test]
    public void CreateSubscriber_WithEmptyId_ThrowsException()
    {
        Guid subscriberId = Guid.Empty;
        string subscriberName = string.Empty;
        Assert.Throws<ArgumentNullException>(() => new Subscriber(subscriberId, subscriberName, new List<PhoneNumber>()));
    }

    [Test]
    public void AddSubscriber_SubscriberAlreadyExists_ThrowsException()
    {
        // Arrange
        var subscriber = new Subscriber(Guid.NewGuid(), "Egor", new List<PhoneNumber>());
        this.phonebook.AddSubscriber(subscriber);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => this.phonebook.AddSubscriber(subscriber));
    }

    [Test]
    public void GetSubscriber_SubscriberExists_ReturnsSubscriber()
    {
        // Arrange
        var subscriber = new Subscriber(Guid.NewGuid(), "Ivan", new List<PhoneNumber>());
        this.phonebook.AddSubscriber(subscriber);

        // Act
        var result = this.phonebook.GetSubscriber(subscriber.Id);

        // Assert
        Assert.That(result, Is.EqualTo(subscriber));
    }

    [Test]
    public void GetSubscriber_SubscriberDoesNotExist_ThrowsException()
    {
        // Act & Assert
        Assert.Throws<InvalidOperationException>(() =>
        {
            this.phonebook.GetSubscriber(Guid.NewGuid());
        });
    }

    [Test]
    public void GetAll_ReturnsAllSubscribers()
    {
        // Arrange
        var subscriber1 = new Subscriber(Guid.NewGuid(), "Alex", new List<PhoneNumber>());
        var subscriber2 = new Subscriber(Guid.NewGuid(), "Max", new List<PhoneNumber>());
        this.phonebook.AddSubscriber(subscriber1);
        this.phonebook.AddSubscriber(subscriber2);

        // Act
        var result = this.phonebook.GetAll();

        // Assert
        Assert.That(result, Is.EquivalentTo(new[] { subscriber1, subscriber2 }));
    }

    [Test]
    public void AddNumberToSubscriber_NumberAddedSuccessfully()
    {
        // Arrange
        var subscriber = new Subscriber(Guid.NewGuid(), "Egor", new List<PhoneNumber>());
        var newNumber = new PhoneNumber("1234567890", PhoneNumberType.Mobile); 
        this.phonebook.AddSubscriber(subscriber);

        // Act
        this.phonebook.AddNumberToSubscriber(subscriber, newNumber);
        var updatedSubscriber = this.phonebook.GetSubscriber(subscriber.Id);

        // Assert
        Assert.That(updatedSubscriber.PhoneNumbers, Contains.Item(newNumber));
    }

    [Test]
    public void RenameSubscriber_SubscriberRenamedSuccessfully()
    {
        // Arrange
        var subscriber = new Subscriber(Guid.NewGuid(), "Artem", new List<PhoneNumber>());
        this.phonebook.AddSubscriber(subscriber);
        var newName = "Vlad";

        // Act
        this.phonebook.RenameSubscriber(subscriber, newName);
        var renamedSubscriber = this.phonebook.GetSubscriber(subscriber.Id);

        // Assert
        Assert.That(renamedSubscriber.Name, Is.EqualTo(newName));
    }

    [Test]
    public void DeleteSubscriber_SubscriberDeletedSuccessfully()
    {
        // Arrange
        var subscriber = new Subscriber(Guid.NewGuid(), "Timur", new List<PhoneNumber>());
        this.phonebook.AddSubscriber(subscriber);

        // Act
        this.phonebook.DeleteSubscriber(subscriber);

        // Assert
        Assert.Throws<InvalidOperationException>(() => this.phonebook.GetSubscriber(subscriber.Id));
    }

    [Test]
    public void ClearPhonebookList_AllSubscribersCleared()
    {
        // Arrange
        var subscriber1 = new Subscriber(Guid.NewGuid(), "Artem", new List<PhoneNumber>());
        var subscriber2 = new Subscriber(Guid.NewGuid(), "Vadim", new List<PhoneNumber>());
        this.phonebook.AddSubscriber(subscriber1);
        this.phonebook.AddSubscriber(subscriber2);

        // Act
        this.phonebook.ClearPhonebookList();

        // Assert
        Assert.That(this.phonebook.GetAll().Count(), Is.EqualTo(0));
    }

}
