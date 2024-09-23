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

        public void Add(User user)
        {
            if (user == null)
            {
                this.users.Add(user);
            }
            else
            {
                throw new ArgumentNullException("Пользователь с таким id существует");
            }
        }

        public void RemoveUser(int id)
        {
            try
            {
                var user = users.FirstOrderDefault(users => users.Id == id);

                if (user == null)
                {
                    throw new ArgumentNullException("Пользователь не найден");
                }
                users.Remove(user);
                Console.WriteLine("Пользователь удален");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при удалении");
            }
            return;
        }

        public void GetUser(int id)
        {
            return;
        }

        public List<User> GetAllUser()
        {
            return this.users;
        }
    }
}
