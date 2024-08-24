using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    public class Program
    {
        #region Методы

        /// <summary>
        /// Точка входа в программу
        /// </summary>
        public static void Main(string[] args)
        {
            var phoneBook = Phonebook.Instance; //Ссылка на объект Phonebook при помощи SingleTone

            while (true)
            {
                Console.WriteLine("Справочник абонента: ");
                Console.WriteLine("1. Добавить абонента ");
                Console.WriteLine("2. Удалить абонента");
                Console.WriteLine("3. Найти номер абонента по номеру");
                Console.WriteLine("4. Найти номер по имени");
                Console.WriteLine("5. Выход");
                Console.WriteLine("Выберите номер действия: ");

                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        AddAbonent(phoneBook);
                        break;
                    case "2":
                        DeleteAbonent(phoneBook);
                        break;
                    case "3":
                        FindAbonentNumber(phoneBook);
                        break;
                    case "4":
                        FindAbonentName(phoneBook);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор, попробуйте снова");
                        break;
                }
            }
        }

        ///<summary>
        ///Добавляем абонента в телефонную книгу. 
        ///</summary>
        /// <param name="phoneBook">Объект книги в которую добавляем абонента.</param>
        static void AddAbonent(Phonebook phoneBook)
        {
            Console.Write("Введите имя абонента: ");

            string name = Console.ReadLine();

            Console.Write("Введите номер телефона: ");

            string numberPhone = Console.ReadLine();

            if (phoneBook.AddAbonent(new Abonent(name, numberPhone)))
            {
                Console.WriteLine("Абонент добавлен");
            }
            else
            {
                Console.WriteLine("Такой абонент уже существует. Добавьте новый!");
            }
        }

        ///<summary>
        ///Удаляем абонента из телефонной книги. 
        ///</summary>
        /// <param name="phoneBook">Объект книги из которой удаляем абонента.</param>
        static void DeleteAbonent(Phonebook phoneBook)
        {
            Console.Write("Введите номер телефона для удаления: ");

            string phoneNumber = Console.ReadLine();

            if (phoneBook.DeleteAbonent(phoneNumber))
            {
                Console.WriteLine("Абонент удалён");
            }
            else
            {
                Console.WriteLine("Абонент не найден");
            }
        }

        ///<summary>
        ///Поиск абонента по номеру телефона.
        ///</summary>
        /// <param name="phoneBook">Объект книги по которому ищем абонента.</param>
        static void FindAbonentNumber(Phonebook phoneBook)
        {
            Console.Write("Введите номер телефона для поиска: ");

            string phoneNumber = Console.ReadLine();

            Abonent abonent = phoneBook.GetAbonentPhoneNumber(phoneNumber);

            if (abonent != null)
            {
                Console.WriteLine($"Абонент найден: {abonent.Name} - {abonent.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("Абонент не найден");
            }
        }

        ///<summary>
        ///Поиск абонента по имени.
        ///</summary>
        /// <param name="phoneBook">Объект книги по которому ищем абонента.</param>
        static void FindAbonentName(Phonebook phoneBook)
        {
            Console.Write("Введите имя для поиска: ");

            string name = Console.ReadLine();

            string phoneNumber = phoneBook.GetPhoneNumber(name);

            if (phoneNumber != null)
            {
                Console.WriteLine($"Номер телефона для {name}: {phoneNumber}");
            }
            else
            {
                Console.WriteLine("Абонент не найден");
            }
        }

        #endregion

    }
}
