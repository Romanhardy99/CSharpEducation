namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age = 30;
            string Name = "Roman";
            double Temp = 22;
            bool isMale = true;
            bool isFemale = false;

            Console.WriteLine($"Возраст: {Age} \nИмя: {Name} \nТемпература: {Temp}");

            if (isMale)
            {
                Console.WriteLine("Ваш пол: Мужской");
            }
            else if (isFemale) 
            {
                Console.WriteLine("Ваш пол: Женский");
            }
        }
    }
}
