using Phonebook;

namespace PhoneNumberTypeTests
{

    [TestFixture]
    public class PhoneNumberTypeTests
    {
        [Test]
        public void PhoneNumberType_ShouldHaveExpectedValues()
        {
            Assert.AreEqual(3, Enum.GetValues(typeof(PhoneNumberType)).Length);
            Assert.IsTrue(Enum.IsDefined(typeof(PhoneNumberType), PhoneNumberType.Personal));
            Assert.IsTrue(Enum.IsDefined(typeof(PhoneNumberType), PhoneNumberType.Work));
            Assert.IsTrue(Enum.IsDefined(typeof(PhoneNumberType), PhoneNumberType.Mobile));
        }

        [Test]
        public void PhoneNumberType_NumericalValues_ShouldBeCorrect()
        {
            Assert.AreEqual(0, (int)PhoneNumberType.Personal);
            Assert.AreEqual(1, (int)PhoneNumberType.Work);
            Assert.AreEqual(2, (int)PhoneNumberType.Mobile);
        }

        [Test]
        public void PhoneNumberType_ShouldReturnCorrectNames()
        {
            Assert.AreEqual("Personal", PhoneNumberType.Personal.ToString());
            Assert.AreEqual("Work", PhoneNumberType.Work.ToString());
            Assert.AreEqual("Mobile", PhoneNumberType.Mobile.ToString());
        }
    }
}
