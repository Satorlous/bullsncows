using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsNCows
{
    class Game
    {
        /// <summary>
        /// Имя игрока
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Сгенерированное число
        /// </summary>
        public int[] Answer { get; set; }
        /// <summary>
        /// Введенное число
        /// </summary>
        private int[] Number { get; set; }
        /// <summary>
        /// Счет игрока
        /// </summary>
        private int Score;

        /// <summary>
        /// Создание экземпляра игры с именем игрока
        /// </summary>
        /// <param name="name">Имя игрока</param>
        public Game(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Проверка числа
        /// </summary>
        /// <param name="_Number">Введенное число</param>
        public Dictionary<string, int[]> CheckNumber(int[] _Number)
        {
            Number = _Number;
            return NumChecker.CheckNumber(Answer, Number);
        }

        /// <summary>
        /// Старт игры
        /// </summary>
        public void StartGame()
        {
            Score = 0;
            GetNumber();
        }

        /// <summary>
        /// Получение случаного числа
        /// </summary>
        private void GetNumber()
        {
            Answer = NumberGenerator.GetNumber();
        }

        /// <summary>
        /// Сохранение счета
        /// </summary>
        private void SaveScore()
        {
            Score += 1;
        }
    }
}
