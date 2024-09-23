using System.Drawing;

namespace HomeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            EmployeeManager<Employee> employeeManager = new EmployeeManager<Employee>();

            while (true)
            {
                Console.Clear();

                DrawMenu();

                Console.WriteLine("Выберите действиe: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddFullTimeEmployee(employeeManager);
                        break;
                    case "2":
                        AddPartTimeEmployee(employeeManager);
                        break;
                    case "3":
                        GetEmployeeInfo(employeeManager);
                        break;
                    case "4":
                        UpdateEmployee(employeeManager);
                        break;
                    case "5":
                        DeleteEmployee(employeeManager);
                        break;
                    case "6":
                        ShowAllEmployee(employeeManager);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова!");
                        break;
                }
            }
        }

        #region Методы

        ///<summary>
        ///Отрисовка интерфейса пользователя.
        ///</summary>
        static void DrawMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|             Главное Меню            |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|1. Добавить полного сотрудника.      |");
            Console.WriteLine("|2. Добавить частичного сотрудника.   |");
            Console.WriteLine("|3. Получить информацию о сотруднике. |");
            Console.WriteLine("|4. Обновить данные о сотруднике.     |");
            Console.WriteLine("|5. Удалить сотрудника.               |");
            Console.WriteLine("|6. Показать всех сотрудников.        |");
            Console.WriteLine("|7. Выход.                            |");
            Console.WriteLine("|-------------------------------------|");
            Console.ResetColor();
        }
        
        /// <summary>
        /// Добавление полного сотрудника.
        /// </summary>
        /// <param name="manager">Менеджер сотрудников.</param>
        static void AddFullTimeEmployee(EmployeeManager<Employee> manager)
        {
            while (true)
            {

                Console.Write("Введите имя сотрудника: ");

                string name = Console.ReadLine();

                try
                {
                    if (manager.Get(name) != null)
                    {
                        throw new Exception("Такой сотрудник существует! Добавьте сотрудника с другим именем.");
                    }

                    decimal salary;

                    while (true)
                    {
                        Console.Write("Введите зарплату: ");

                        string salaryInput = Console.ReadLine();

                        if (decimal.TryParse(salaryInput, out salary) && salary > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Некорректное значение. Попробуйте снова");
                        }
                    }

                    FullTimeEmployee employee = new FullTimeEmployee(name, salary);

                    manager.Add(employee);

                    Console.WriteLine("Полный сотрудник добавлен");

                    Console.ReadKey();

                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Добавление частичного сотрудника.
        /// </summary>
        /// <param name="manager">Менеджер сотрудников.</param>
        static void AddPartTimeEmployee(EmployeeManager<Employee> manager)
        {
            while (true)
            {
                Console.Write("Введите имя сотрудника: ");

                string name = Console.ReadLine();

                try
                {
                    if (manager.Get(name) != null)
                    {
                        throw new Exception("Такой сотрудник существует! Добавьте сотрудника с другим именем.");
                    }

                    decimal hourlyRate;

                    while (true)
                    {
                        Console.Write("Введите почасовую ставку: ");

                        string hourlyRateInput = Console.ReadLine();

                        if (decimal.TryParse(hourlyRateInput, out hourlyRate) && hourlyRate > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Некорректное кол-во часов. Попробуйте снова.");
                        }
                    }

                    int hoursWorked;

                    while (true)
                    {
                        Console.Write("Введите количество отработанных часов: ");

                        string hoursWorkedInput = Console.ReadLine();

                        if (int.TryParse(hoursWorkedInput, out hoursWorked) && hoursWorked > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Некорректное количество часовю Попробуйте снова");
                        }
                    }
                    PartTimeEmployee employee = new PartTimeEmployee(name, hourlyRate, hoursWorked);

                    manager.Add(employee);

                    Console.WriteLine("Частичный сотрудник добавлен");

                    Console.ReadKey();

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Получение инфы от сотруднике.
        /// </summary>
        /// <param name="manager">Менеджер сотрудников.</param>
        static void GetEmployeeInfo(EmployeeManager<Employee> manager)
        {
            Console.Write("Введите имя сотрудника: ");

            string name = Console.ReadLine();

            var employee = manager.Get(name);

            if (employee != null)
            {
                Console.WriteLine(employee.ToString());
            }
            else
            {
                Console.WriteLine("Сотрудник не найден");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Обновляет данные сотрудника.
        /// </summary>
        /// <param name="manager">Менеджер сотрудников.</param>
        static void UpdateEmployee(EmployeeManager<Employee> manager)
        {
            Console.Write("Введите имя сотрудника для обновления: ");

            string name = Console.ReadLine();

            var employee = manager.Get(name);

            if (employee != null)
            {
                Console.Write("Введите новую ЗП: ");

                decimal newSalary = Convert.ToDecimal(Console.ReadLine());

                employee.BaseSalary = newSalary;

                manager.Update(employee);
            }
            else
            {
                Console.WriteLine("Сотрудник не найден");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Удаляет сотрудника.
        /// </summary>
        /// <param name="manager">Менеджер сотрудников.</param>
        static void DeleteEmployee(EmployeeManager<Employee> manager)
        {
            Console.Write("Введите имя сотрудника для удаления: ");

            string name = Console.ReadLine();

            var employee = manager.Get(name);

            if (employee != null)
            {
                manager.Delete(employee);
            }
            else
            {
                Console.WriteLine("Сотрудник не найден");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Показывает всех добавленных сотрудников.
        /// </summary>
        /// <param name="manager">Менеджер сотрудников.</param>
        static void ShowAllEmployee(EmployeeManager<Employee> manager)
        {
            var employees = manager.GetAll();

            if (employees.Count == 0)
            {
                Console.WriteLine("Нет сотрудников.");
            }
            else
            {
                Console.WriteLine("Сотрудники: ");

                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
            Console.ReadKey();
        }

        #endregion

    }
}
