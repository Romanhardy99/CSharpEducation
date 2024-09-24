using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    /// <summary>
    /// Класс для представления пользователя в системе управления пользователями.
    /// Обеспечивает основные свойства и методы для управления и отображения информации пользователя.
    /// </summary>
    internal class User
    {
        
        #region Поля и свойства

        /// <summary>
        /// Получает или устанавливает идентификатор пользователя.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Получает или устанавливает имя пользователя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Получает или устанавливает почтовый адрес пользователя.
        /// </summary>
        public string Email { get; set; }

        #endregion

        #region Конструктор

        /// <summary>
        /// Инициализирует новый экземпляр пользователя с заданным id, именем и почтой.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <param name="name">Имя пользователя.</param>
        /// <param name="email">Почта пользователя.</param>
        public User(int id, string name, string email)
        {
            this.Id = id;

            this.Name = name;

            this.Email = email;
        }

        #endregion

    }
}
