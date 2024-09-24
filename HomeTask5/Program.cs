namespace HomeTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UserManager userManager = new UserManager();

            UserInterface(userManager);

        }

        public static void UserInterface(UserManager userManager)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Меню");

                Console.WriteLine("1. Добавить пользователя");

                Console.WriteLine("2. Удалить пользователя");

                Console.WriteLine("3. Показать пользователя");

                Console.WriteLine("4. Показать всех пользователей");

                Console.WriteLine("5. Выход");

                Console.WriteLine();

                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddUser(userManager);
                        break;
                    case "2":
                        RemoveUser(userManager);
                        break;
                    case "3":
                        GetUser(userManager);
                        break;
                    case "4":
                        ListUsers(userManager);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
                Console.WriteLine();

                Console.WriteLine("Нажмите любую клавишу для продолжения...");

                Console.ReadKey();
            }
        }

        public static void AddUser(UserManager userManager)
        {
            try
            {
                Console.Write("Введите Id: ");

                int id = int.Parse(Console.ReadLine());

                Console.Write("Введите имя: ");

                string name = Console.ReadLine();

                Console.Write("Введите почту: ");

                string email = Console.ReadLine();

                User user = new User(id, name, email);

                userManager.AddUser(user);

                Console.WriteLine("Пользователь добавлен.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Id должен быть числом.");
            }
            catch (UserAlreadyExistsException)
            {
                Console.WriteLine("Пользователь уже существует. Попробуйте заного.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавлении пользователя: {ex.Message}");
            }
        }

        public static void RemoveUser(UserManager userManager)
        {
            try
            {
                Console.Write("Введите Id пользователя для удаления: ");

                int id = int.Parse(Console.ReadLine());

                userManager.RemoveUser(id);

                Console.WriteLine("Пользователь удален.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Id должен быть числом.");
            }
            catch (UserNotFoundException)
            {
                Console.WriteLine("Пользователь не найден.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении пользователя: {ex.Message}.");
            }
        }

        public static void GetUser(UserManager userManager)
        {
            try
            {
                Console.Write("Введите id для отображения пользователя: ");

                int id = int.Parse(Console.ReadLine());

                User user = userManager.GetUser(id);

                Console.WriteLine($"ID Пользователя: {user.Id}, Имя пользователя: {user.Name}, Почта пользователя: {user.Email}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Id должен быть числом.");
            }
            catch (UserNotFoundException)
            {
                Console.WriteLine("Пользователь не найден.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении пользователя: {ex.Message}.");
            }
        }

        public static void ListUsers(UserManager userManager)
        {
            try
            {
                userManager.ListUsers();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при отображении списка пользователй: {ex.Message}");
            }
        }

    }
}
