using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    /// <summary>
    /// Интерфейс для управления сотрудниками, включая добавление, получение, обновление и удаление.
    /// </summary>
    /// <typeparam name="T">Тип сотрудника, производный от класса Employee.</typeparam>
    public interface IEmployeeManager<T> where T : Employee
    {
        #region Методы

        /// <summary>
        /// Добавляет сотрудника.
        /// </summary>
        /// <param name="employee">Сотрудник для добавления.</param>
        void Add(T employee);

        /// <summary>
        /// Получает сотрудника по имени.
        /// </summary>
        /// <param name="name">Имя сотрудника.</param>
        /// <returns>Сотрудник, если найден, иначе null.</returns>
        T Get(string name);

        /// <summary>
        /// Обновляет данные сотрудника.
        /// </summary>
        /// <param name="employee">Сотрудник с обновленными данными.</param>
        void Update(T employee);

        /// <summary>
        /// Удаляет сотрудника.
        /// </summary>
        /// <param name="employee">Сотрудник для удаления.</param>
        void Delete(T employee);

        #endregion
    }
}
