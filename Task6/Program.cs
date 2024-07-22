namespace Task6
{
    internal class Program
    {
        const double Pi = 3.141592653589793;
        static void Main(string[] args)
        {
            

            double radius;

            while (true)
            {
                Console.Write("Введите радиус круга: ");

                string radiusInput = Console.ReadLine();

                if (double.TryParse(radiusInput, out radius))
                {


                    double area = Pi * radius * radius;

                    Console.WriteLine($"Площадь круга: {area}");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректные данные!");
                }
                

            }
        }
    }
}
