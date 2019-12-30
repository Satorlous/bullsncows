using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsNCows
{
    class Controller
    {
        /// <summary>
        /// Экземпляр игры
        /// </summary>
        private Game Game;

        private Journal Journal;

        /// <summary>
        /// Старт игры
        /// </summary>
        /// <param name="name">Имя игрока</param>
        public void StartGame(string name)
        {
            Game = new Game(name);
            Game.StartGame();
            Journal = new Journal();
        }

        /// <summary>
        /// Проверка введенного числа
        /// </summary>
        /// <param name="number">введенное число</param>
        public Dictionary<string,int[]> CheckNumber(string number)
        {
            if(number.Length != 4)
            {
                return null;
            }
            int[] Number = new int[number.Length];
            for(int i =0; i< Number.Length; i++)
            {
                Number[i] = -1;
            }
            for(int i =0; i < number.Length; i++)
            {
                if(int.TryParse(number[i].ToString(), out int a))
                {
                    if(Number.Contains(a))
                    {
                        return null;
                    }
                    Number[i] = a;
                }
                else
                {
                    return null;
                }
            }
            return Game.CheckNumber(Number);
        }

        /// <summary>
        /// Сохранить игру
        /// </summary>
        public void SaveGame()
        {
            Journal.SaveGame(Game);
        }

        /// <summary>
        /// Загрузить игру
        /// </summary>
        /// <param name="IdGame">Id загружаемой игры</param>
        public void LoadGame(int IdGame)
        {

        }

        /// <summary>
        /// Получить сохраненные игры
        /// </summary>
        public void GetGames()
        {

        }
    }
}
