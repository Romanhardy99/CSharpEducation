using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    /// <summary>
    ///  Класс для представления сотрудника в системе управления сотрудниками.
    ///  Обеспечивает основные свойства и методы для расчета зарплаты и отображения информации о сотруднике.
    /// </summary>
    public abstract class Employee
    {
        #region Поля и свойства

        /// <summary>
        /// Получает или задаёт имя сотрудника.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Получает или задаёт базовую зарплату сотрудника.
        /// </summary>
        public decimal BaseSalary { get; set; }

        #endregion

        #region Методы

        /// <summary>
        /// Расчитывает зарплату сотрудникам
        /// </summary>
        /// <returns>Зарплата сотрудника.</returns>
        public abstract decimal CalculateSalary();

        #endregion

        #region Конструктор

        /// <summary>
        /// Инициализирует новый экземпляр класса сотрудника с заданным именем и базовой зарплатой.
        /// </summary>
        /// <param name="name">Имя сотрудника.</param>
        /// <param name="baseSalary">Базовая зп сотрудника.</param>
        public Employee(string name, decimal baseSalary)
        {
            Name = name;

            BaseSalary = baseSalary;
        }

        #endregion
    }
}
