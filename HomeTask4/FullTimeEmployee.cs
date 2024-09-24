using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    /// <summary>
    /// Класс представляющий полного сотрудника.
    /// Наследует функциональность от класса Employee и реализует мeтоды для расчета зарплаты и представления информации о сотруднике.
    /// </summary>
    public class FullTimeEmployee : Employee
    {

        #region Базовый класс

        public override decimal CalculateSalary()
        {
            return BaseSalary;
        }

        public override string ToString()
        {
            return $"Имя: {Name} Зарплата: {BaseSalary:C}";
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Инициализирует новый экземпляр класса полного сотрудника с заданным именем и базовой зарплатой.
        /// </summary>
        /// <param name="name">Имя сотрудника.</param>
        /// <param name="baseSalary">Базовая зп.</param>
        public FullTimeEmployee(string name, decimal baseSalary) : base(name, baseSalary) { }

        #endregion
    }
}
