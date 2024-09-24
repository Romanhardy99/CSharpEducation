using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    /// <summary>
    /// Исключение, которое выбрасывается, когда не удается найти пользователя.
    /// </summary>
    internal class UserNotFoundException : Exception
    {
        /// <summary>
        /// Инициализирует новый объект класса. 
        /// </summary>
        /// <param name="message">Сообщение описывающий исключение.</param>
        public UserNotFoundException(string message)
        : base(message) { }
    }
}
