﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public abstract class Employee
    {
        #region Свойства

        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">Имя сотрудника.</param>
        /// <param name="baseSalary">Базовая зп сотрудника.</param>
        public Employee(string name, decimal baseSalary)
        {
            Name = name;

            BaseSalary = baseSalary;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Абстрактный метод для расчета зарплаты сотрудника.
        /// </summary>
        /// <returns>Зарплата сотрудника.</returns>
        public abstract decimal CalculateSalary();

        /// <summary>
        /// Переопределение метода для отображения информации о сотруднике.
        /// </summary>
        /// <returns>Строковое представление сотрудника.</returns>
        public abstract override string ToString();

        #endregion
    }
}