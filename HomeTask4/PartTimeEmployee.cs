using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class PartTimeEmployee : Employee
    {
        #region Свойства

        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

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

        #region Методы

        /// <summary>
        /// Рассчитывает зарплату частичного сотрудника.
        /// </summary>
        /// <returns>Произведение почасовой ставки на количество отработанных часов.</returns>
        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        /// <summary>
        /// Возвращает строковое представление информации о частичном сотруднике.
        /// </summary>
        /// <returns>Строка с именем, количеством отработанных часов, почасовой ставкой и зарплатой.</returns>
        public override string ToString()
        {
            return $"Имя: {Name}, Отработанное время: {HoursWorked}, Почасовая ставка {HourlyRate}, Зарплата: {CalculateSalary():C}";
        }

        #endregion
    }
}
