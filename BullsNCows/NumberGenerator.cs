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
        private const int LengthNumber = 4;

        /// <summary>
        /// Массив с возвращаемым числом
        /// </summary>
        private static int[] Number = new int[LengthNumber];

        /// <summary>
        /// Максимальное значение для генерации
        /// </summary>
        private const int Max = 10;

        /// <summary>
        /// Минимальное значение для генерации
        /// </summary>
        private const int Min = 1;

        /// <summary>
        /// Возврат случайно сгенерированного числа
        /// </summary>
        /// <returns>4 значное число в виде 4 размерного массиве</returns>
        public static int[] GetNumber()
        {
            Number = new int[LengthNumber];
            Number[LengthNumber - 1] = Max;
            int current = 0;
            while (Number[LengthNumber - 1] == Max)
            {
                int buf = rand.Next(Min, Max);
                if (CheckNumber(buf) != Max)
                {
                    Number[current++] = buf;
                }
            }
            return Number;           
        }

        /// <summary>
        /// Проверка числа на уникальность
        /// </summary>
        /// <param name="_number">Число для проверки на уникальность</param>
        /// <returns></returns>
        private static int CheckNumber(int _number)
        {
            if (Number.Contains(_number))
            {
                return Max;
            }
            else
            {
                return _number;
            }
        }
    }
}
