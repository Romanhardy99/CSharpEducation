using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    /// <summary>
    /// Класс представляющий частичного сотрудника.
    /// Наследует функциональность от класса Employee и добавляет свойства для почасовой ставки и отработанных часов.
    /// </summary>
    public class PartTimeEmployee : Employee
    {
        #region Поля и свойства

        /// <summary>
        /// Свойство, представляющее почасовую ставку частичного сотрудника.
        /// </summary>
        public decimal HourlyRate { get; set; }

        /// <summary>
        /// Свойство, представляющее количество отработанных часов частичного сотрудника.
        /// </summary>
        public int HoursWorked { get; set; }

        #endregion

        #region Базовый класс

        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Отработанное время: {HoursWorked}, Почасовая ставка {HourlyRate}, Зарплата: {CalculateSalary():C}";
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор для создания частичного сотрудника.
        /// </summary>
        /// <param name="name">Имя сотрудника.</param>
        /// <param name="hourlyRate">Почасовая ставка.</param>
        /// <param name="hoursWorked">Количество отработанных часов.</param>
        public PartTimeEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name, 0)
        {
            HourlyRate = hourlyRate;

            HoursWorked = hoursWorked;
        }

        #endregion
    }
}
