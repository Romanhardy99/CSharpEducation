using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeTask3
{
    /// <summary>
    /// Телефонный справочник.
    /// </summary>
    public class Phonebook
    {
        private static readonly Lazy<Phonebook> instance = new Lazy<Phonebook>(() => new Phonebook()); //Поле содержит отложенную инициализацию.
        private readonly List<Abonent> abonents;
        private readonly string filePath = "phonebook.txt";

        #region Конструктор

        /// <summary>
        /// Приватный конструктор.
        /// </summary>
        private Phonebook()
        {
            abonents = new List<Abonent>();

            LoadFromFile();
        }

        #endregion

        #region Свойства

        public static Phonebook Instance => instance.Value; /// Свойство предоставляет доступ к единственному экземпляру класса при первом его создании.

        #endregion

        #region Методы

        /// <summary>
        /// Добавление абонента в справочник при отсутствии имени и номера.
        /// </summary>
        /// <param name="abonent">Абонент, который должен быть добавлен в справочник.</param>
        /// <returns>Возвращает тру если абонент добавлен.</returns>
        public bool AddAbonent(Abonent abonent)
        {
            if (abonents.Any(a => a.PhoneNumber == abonent.PhoneNumber))
            {
                return false;
            }

            abonents.Add(abonent);

            SaveToFile();

            return true;
        }

        /// <summary>
        /// Удаление абонента из справочника по номеру.
        /// </summary>
        /// <param name="phoneNumber">Номер который необходимо удалить.</param>
        /// <returns>Возвращает тру если абонент удален.</returns>
        public bool DeleteAbonent(string phoneNumber)
        {
            var abonent = abonents.FirstOrDefault(a => a.PhoneNumber == phoneNumber);

            if (abonent != null)
            {
                abonents.Remove(abonent);

                SaveToFile();

                return true;
            }
            return false;
        }

        /// <summary>
        /// Поиск абонента по номеру.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона абонента по которому происходит поиск.</param>
        /// <returns>Возвращает абонента если тру.</returns>
        public Abonent GetAbonentPhoneNumber(string phoneNumber)
        {
            return abonents.FirstOrDefault(a => a.PhoneNumber == phoneNumber);
        }

        /// <summary>
        /// Поиск абонента по имени.
        /// </summary>
        /// <param name="name">Имя абонента по которому происходит поиск</param>
        /// <returns>Возвращает абонента если тру.</returns>
        public string GetPhoneNumber(string name)
        {
            var abonent = abonents.FirstOrDefault(a => a.Name == name);

            return abonent?.PhoneNumber;
        }

        /// <summary>
        /// Загружает список абонентов из файла.
        /// </summary>
        private void LoadFromFile()
        {
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length == 2)
                {
                    abonents.Add(new Abonent(parts[0], parts[1]));
                }
            }
        }

        /// <summary>
        /// Сохраняет текущий список абонентов в файл.
        /// </summary>
        private void SaveToFile()
        {
            var lines = abonents.Select(a => $"{a.Name},{a.PhoneNumber}");

            File.WriteAllLines(filePath, lines);
        }

        #endregion

    }
}

