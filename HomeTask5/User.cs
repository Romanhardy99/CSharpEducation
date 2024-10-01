using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    /// <summary>
    /// Пользователь.
    /// Обеспечивает основные свойства и методы для управления и отображения информации пользователя.
    /// </summary>
    internal class User
    {
        #region Поля и свойства

        /// <summary>
        /// Идентификатор пользователя.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Почта пользователя.
        /// </summary>
        public string Email { get; set; }

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор.
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
