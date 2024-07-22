namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны два катета
            double cathetus1 = 3.0;
            double cathetus2 = 4.0;

            // Вычисление гипотенузы по теореме Пифагора
            double hypotenuse = Math.Sqrt(cathetus1 * cathetus1 + cathetus2 * cathetus2);
            Console.WriteLine($"Длина гипотенузы, если известны катеты {cathetus1} и {cathetus2}: {hypotenuse}");

            // Известны один катет и гипотенуза
            double knownCathetus = 3.0;
            double knownHypotenuse = 5.0;

            // Вычисление второго катета по теореме Пифагора
            double otherCathetus = Math.Sqrt(knownHypotenuse * knownHypotenuse - knownCathetus * knownCathetus);
            Console.WriteLine($"Длина второго катета, если известны катет {knownCathetus} и гипотенуза {knownHypotenuse}: {otherCathetus}");
        }
    }
}
