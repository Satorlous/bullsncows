using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsNCows
{
    /// <summary>
    /// Класс для генерации рандомного числа
    /// </summary>
    class NumberGenerator
    {
        /// <summary>
        /// Экземпляр класса Random
        /// </summary>
        private static Random rand = new Random();

        /// <summary>
        /// Длина возвращаемого числа 
        /// </summary>
        private const int NumberLength = 4;

        /// <summary>
        /// Массив с возвращаемым числом
        /// </summary>
        private static int[] Number = new int[NumberLength];

        /// <summary>
        /// Максимальное значение для генерации
        /// </summary>
        private const int Max = 10;

        /// <summary>
        /// Минимальное значение для генерации
        /// </summary>
        private const int Min = 0;

        /// <summary>
        /// Возврат случайно сгенерированного числа
        /// </summary>
        /// <returns>Четырехзначное число в виде массива длиной 4</returns>
        public static int[] GetNumber()
        {
            Number = new int[NumberLength];
            Number[NumberLength - 1] = Max;
            int current = 0;
            while (Number[NumberLength - 1] == Max)
            {                
                int buf = current != 0 ? rand.Next(Min, Max) : rand.Next(Min + 1, Max);
                if (CheckNumber(buf) != Max)
                {                   
                    Number[current++] = buf;
                }
            }
            return Number;           
        }

        /// <summary>
        /// Проверка цифры на уникальность в числе
        /// </summary>
        /// <param name="_number">Цифра для проверки на уникальность в числе</param>
        private static int CheckNumber(int _number)
        {
            if (Number.Contains(_number))          
                return Max;                      
            return _number;           
        }
    }
}
