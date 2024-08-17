using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var phonebook = Phonebook.Instance;

            while (true)
            {
                Console.WriteLine("Справочник абонента: ");
                Console.WriteLine("1. Добавить абонента");
                Console.WriteLine("2. Удалить абонента");
                Console.WriteLine("3. Найти номер абонента по номеру");
                Console.WriteLine("4. Найти номер по имени");
                Console.WriteLine("5. Выход");

                Console.WriteLine("Выберите номер действия: ");

                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        AddAbonent(phonebook);
                        break;
                    case "2":
                        DeleteAbonent(phonebook);
                        break;
                    case "3":
                        FindAbonentNumber(phonebook);
                        break;
                    case "4":
                        FindAbonentName(phonebook);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор, попробуйте снова");
                        break;

                }

                static void AddAbonent(Phonebook phonebook)
                {
                    Console.Write("Введите имя абонента: ");
                    string name = Console.ReadLine();

                    Console.Write("Введите номер телефона: ");
                    string numberPhone = Console.ReadLine();

                    if (phonebook.AddAbonent(new Abonent(name, numberPhone)))
                    {
                        Console.WriteLine("Абонент добавлен");
                    }
                    else
                    {
                        Console.WriteLine("Такой абонент уже существует. Добавьте новый!");
                    }
                }

                static void DeleteAbonent(Phonebook phonebook)
                {
                    Console.Write("Введите номер телефона для удаления: ");
                    string phoneNumber = Console.ReadLine();
                    if (phonebook.DeleteAbonent(phoneNumber))
                    {
                        Console.WriteLine("Абонент удалён");
                    }
                    else
                    {
                        Console.WriteLine("Абонент не найден");
                    }
                }

                static void FindAbonentNumber(Phonebook phonebook)
                {
                    Console.Write("Введите номер телефона для поиска: ");
                    string phoneNumber = Console.ReadLine();

                    Abonent abonent = phonebook.GetAbonentPhoneNumber(phoneNumber);
                    if (abonent != null)
                    {
                        Console.WriteLine($"Абонент найден: {abonent.Name} - {abonent.PhoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Абонент не найден");
                    }

                }

                static void FindAbonentName(Phonebook phonebook)
                {
                    Console.Write("Введите имя для поиска: ");
                    string name = Console.ReadLine();

                    string phoneNumber = phonebook.GetPhoneNumber(name);
                    if (phoneNumber != null)
                    {
                        Console.WriteLine($"Номер телефона для {name}: {phoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Абонент не найден");
                    }
                }
            }


        }
    }
}
