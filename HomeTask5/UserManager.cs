using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    /// <summary>
    /// Менеджер для управления пользователем.
    /// Позволяет добавлять, удалять, получать информацию о пользователе и выводить список.
    /// </summary>
    internal class UserManager
    {
        #region Поля и свойства

        /// <summary>
        /// Коллекция.
        /// </summary>
        private List<User> users = new List<User>();

        #endregion

        #region Методы

        /// <summary>
        /// Добавить пользователя.
        /// </summary>
        /// <param name="user">Пользователь для добавления.</param>
        /// <exception cref="UserAlreadyExistsException">Исключение, выбрасываемое при попытке добавить пользователя с уже существующим 
        /// идентификатором в список.</exception>
        public void AddUser(User user)
        {
            if (users.Exists(u => u.Id == user.Id))
            {
                throw new UserAlreadyExistsException($"Пользователь с id {user.Id} существует.");
            }
            this.users.Add(user);
        }

        /// <summary>
        /// Удалить пользователя.
        /// </summary>
        /// <param name="id">Идентификатор для поиска пользователя.</param>
        /// <exception cref="UserNotFoundException">Исключение, выбрасываемое, когда пользователь с указанным идентификатором не найден.</exception>
        public void RemoveUser(int id)
        {
            User user = users.Find(u => u.Id == id);

            if (user == null)
            {
                throw new UserNotFoundException("Пользователь не найден.");
            }
            this.users.Remove(user);
        }

        /// <summary>
        /// Получить пользователя по ID.
        /// </summary>
        /// <param name="id">Идентификатор для поиска пользователя.</param>
        /// <returns></returns>
        /// <exception cref="UserNotFoundException">Исключение, выбрасываемое, когда пользователь с указанным идентификатором не найден.</exception>
        public User GetUser(int id)
        {
            User user = users.Find(user => user.Id == id);

            if (user == null)
            {
                throw new UserNotFoundException("Пользователь не найден.");
            }
            return user;
        }

        /// <summary>
        /// Отобразить всех пользователей.
        /// Если список пуст, выводит сообщение.
        /// </summary>
        public void ListUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Нет пользователей в списке.");
                return;
            }
            foreach (User user in users)
            {
                Console.WriteLine($"Пользователь: {user.Id}, {user.Name}, {user.Email}");
            }
        }

        #endregion

    }
}
