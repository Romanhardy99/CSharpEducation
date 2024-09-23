namespace HomeTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public void UserInterface()
        {
            Console.WriteLine("Меню");
            Console.WriteLine("1. Добавить пользователя");
            Console.WriteLine("2. Удалить пользователя");
            Console.WriteLine("3. Показать всех пользователей");
            Console.WriteLine("4. Выход");
            Console.WriteLine();
            Console.Write("Выберите действие: ");
        }

        public void AddUser()
        {
            try
            {
                return;
            }
            catch (Exception) { Console.WriteLine("Ошибка."); }
        }
        public void RemoveUser()
        {
            try
            {
                return;
            }
            catch (Exception) { Console.WriteLine("Ошибка."); }
        }

        public void GetUser()
        {
            try
            {
                return;
            }
            catch (Exception) { Console.WriteLine("Ошибка."); }
        }
    }
}
