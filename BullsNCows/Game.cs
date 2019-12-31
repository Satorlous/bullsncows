using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsNCows
{
    public class Game
    {
        /// <summary>
        /// Имя игрока
        /// </summary>
        public string PlayerName { get; set; }
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
        public int Score { get; set; }
        /// <summary>
        /// Закончилась игра или нет
        /// </summary>
        public bool EndGame { get; set; }

        public List<string> History { get; set; }

        private Dictionary<string, int[]> CowsBulls;

        public Game() { }

        /// <summary>
        /// Создание экземпляра игры с именем игрока
        /// </summary>
        /// <param name="playername">Имя игрока</param>
        public Game(string playername)
        {
            PlayerName = playername;
            History = new List<string>();
            CowsBulls = new Dictionary<string, int[]>();
        }

        /// <summary>
        /// Проверка числа
        /// </summary>
        /// <param name="_Number">Введенное число</param>
        public Dictionary<string, int[]> CheckNumber(int[] _Number)
        {
            Number = _Number;
            CowsBulls = NumChecker.CheckNumber(Answer, Number);
            SaveScore();
            return CowsBulls;
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
            History.Insert(0,
                String.Format("{0} {1} {2}",
                    String.Join("",Number),
                    CowsBulls["Bulls"].Count(x => x ==1), 
                    CowsBulls["Cows"].Count(x => x == 1))
                );
        }
    }
}
