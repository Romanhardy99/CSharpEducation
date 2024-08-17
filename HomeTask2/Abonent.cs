namespace HomeTask3
{
    public class Abonent
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Abonent(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override bool Equals(object obj)
        {
            return obj is Abonent abonent && PhoneNumber == abonent.PhoneNumber;
        }

        public override int GetHashCode()
        {
            return PhoneNumber.GetHashCode();
        }
    }
}
