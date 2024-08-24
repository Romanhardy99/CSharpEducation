namespace HomeTask3
{
    /// <summary>
    /// Объект абонент.
    /// </summary>
    public class Abonent
    {
        #region Свойства
        /// <summary>
        /// Имя абонента.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер телефона абонента.
        /// </summary>
        public string PhoneNumber { get; set; }
        #endregion

        #region Конструктор
        /// <summary>
        /// Инициализируем экземпляр. 
        /// </summary>
        /// <param name="name">Параметр имя абонента.</param>
        /// <param name="phoneNumber">Параметр номер телефона абонента.</param>
        public Abonent(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        #endregion

        #region Методы
        /// <summary>
        /// Проверяем равен ли текущий объект другому объекту по номеру телефона.
        /// </summary>
        /// <param name="obj">Объект, который нужно сравнить с текущим объектом.</param>
        /// <returns>Возвращает значение тру если текущий объект равен другому объекту</returns>
        public override bool Equals(object obj)
        {
            return obj is Abonent abonent && PhoneNumber == abonent.PhoneNumber;
        }

        /// <summary>
        /// Возвращает числовое значение.
        /// </summary>
        /// <returns>Вернет хэш объекта</returns>
        public override int GetHashCode()
        {
            return PhoneNumber.GetHashCode();
        }
        #endregion
    }
}
