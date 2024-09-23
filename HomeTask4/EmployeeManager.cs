using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class EmployeeManager<T> : IEmployeeManager<T> where T : Employee
    {
        #region Поле

        private List<T> employees = new List<T>();

        #endregion

        #region Методы

        /// <summary>
        /// Добавляет сотрудника в списке.
        /// </summary>
        /// <param name="employee">Сотрудник для добавления.</param>
        public void Add(T employee)
        {
            employees.Add(employee);
        }

        /// <summary>
        /// Получает сотрудника по имени.
        /// </summary>
        /// <param name="name">Имя сотрудника.</param>
        /// <returns>Найденный сотрудник или null, если сотрудник не найден.</returns>
        public T Get(string name)
        {
            return employees.Find(e => e.Name == name);
        }
        
        /// <summary>
        /// Обновляет информацию о сотруднике.
        /// </summary>
        /// <param name="employee">Сотрудник с обновлёнными данными.</param>
        public void Update(T employee)
        {
            var existingEmployee = Get(employee.Name);

            if (existingEmployee != null)
            {
                existingEmployee.BaseSalary = employee.BaseSalary;

                Console.WriteLine("Данные сотрудника обновлены");
            }
            else
            {
                Console.WriteLine("Сотрудник не найден");
            }
        }

        /// <summary>
        /// Удаляет сотрудника из списка.
        /// </summary>
        /// <param name="employee">Сотрудник для удаления.</param>
        public void Delete(T employee)
        {
            employees.Remove(employee);

            Console.WriteLine("Сотрудник удалён");
        }

        /// <summary>
        /// Возвращает список всех сотрудников.
        /// </summary>
        /// <returns>Список сотрудников.</returns>
        public List<T> GetAll()
        {
            return employees;
        }

        #endregion

    }
}
