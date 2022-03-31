using System;
using System.Linq;

namespace ContactsApp
{
    /// <summary>
    /// Класс хранящий информацию о номере телефона
    /// </summary>
    public class PhoneNumber : IEquatable<PhoneNumber>
    {
        /// <summary>
        /// Максимальная длина номера
        /// </summary>
	    private const int MaxLength = 11;

        /// <summary>
        /// Номер телефона
        /// </summary>
        private long _number;

        /// <summary>
        /// Задает номер телефона
        /// Тефонный номер должен быть 11 цифр и начинаться с 7
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public long Number
        {
            get => _number;
            set
            {
                if (value.ToString().First() == '7' && value.ToString().Length ==11)
                {
                    _number = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Ошибка. Номер должен содержать 11 цифр, первая цифра должна быть 7");
                }
            }
        }

        /// <summary>
        /// Сравнивает два объекта
        /// </summary>
        public bool Equals(PhoneNumber other)
        {
	        return Number == other.Number;
        }
    }
}
