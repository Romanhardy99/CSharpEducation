using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    internal class UserManager
    {
        List<User> users = new List<User>();

        public void AddUser(User user)
        {
            if (users.Exists(u => u.Id == user.Id))
            {
                throw new UserAlreadyExistsException("Пользователь с таким id существует.");
            }
            this.users.Add(user);
        }

        public void RemoveUser(int id)
        {
            User user = users.Find(u => u.Id == id);

            if (user == null)
            {
                throw new UserNotFoundException("Пользователь не найден.");
            }
            this.users.Remove(user);
        }

        public User GetUser(int id)
        {
            User user = users.Find(user => user.Id == id);

            if (user == null)
            {
                throw new UserNotFoundException("Пользователь не найден.");
            }
            return user;
        }

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
    }
}
