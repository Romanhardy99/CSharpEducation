using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class FullTimeEmployee : Employee
    {
        #region Конструктор

        /// <summary>
        /// Конструктор для создания экземпляра полного сотрудника.
        /// </summary>
        /// <param name="name">Имя сотрудника.</param>
        /// <param name="baseSalary">Базовая зп.</param>
        public FullTimeEmployee(string name, decimal baseSalary) : base(name, baseSalary) { }

        #endregion

        #region Методы

        /// <summary>
        /// Расчитывает зарплату полного сотрудника.
        /// </summary>
        /// <returns>Базовая запрлата сотрудника.</returns>
        public override decimal CalculateSalary()
        {
            return BaseSalary;
        }

        /// <summary>
        /// Возвращает строкое представление информации о полном сотруднике.
        /// </summary>
        /// <returns>Строка с именем и зарплатой сотрудника.</returns>
        public override string ToString()
        {
            return $"Имя: {Name} Зарплата: {BaseSalary:C}";
        }

        #endregion

    }
}
