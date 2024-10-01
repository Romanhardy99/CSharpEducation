using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    /// <summary>
    /// Исключение, которое выбрасывается, когда пытаются добавить существующего пользователя.
    /// </summary>
    internal class UserAlreadyExistsException : Exception
    {
        /// <summary>
        /// Инициализирует новый объект класса. 
        /// </summary>
        /// <param name="message">Сообщение описывающий исключение.</param>
        public UserAlreadyExistsException(string message)
            : base(message) { }
    }
}
