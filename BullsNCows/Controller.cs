using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;

namespace BullsNCows
{
    class Controller
    {
        /// <summary>
        /// Экземпляр игры
        /// </summary>
        private Game Game;

        private static Journal Journal = new Journal();

        /// <summary>
        /// Старт игры
        /// </summary>
        /// <param name="name">Имя игрока</param>
        public void StartGame(string name)
        {
            Game = new Game(name);
            Game.StartGame();
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
        public void SaveGame(string number)
        {
            Game.EndGame = false;
            if (CheckNumber(number)["Bulls"].Count(x => x == 1) == 4)
            {
                Game.EndGame = true;
            }
            Journal.SaveGame(Game);
        }

        /// <summary>
        /// Загрузить игру
        /// </summary>
        /// <param name="IdGame">Id загружаемой игры</param>
        public List<string> LoadGame(int IdGame)
        {
            Journal journal = Journal.LoadGame(IdGame);
            if (journal == null)
                return null;
            int[] answer = new int[4];
            int currnet = 0;
            foreach (var item in journal.Answer)
            {
                answer[currnet++] = int.Parse(item.ToString());
            }
            var history = JsonConvert.DeserializeObject<List<string>>(journal.History);
            Game = new Game { Answer = answer, PlayerName = journal.Name, Score = journal.Score, History = history};
            return history;
        }

        /// <summary>
        /// Получить сохраненные игры
        /// </summary>
        public object GetGames(bool StatusGames,string PlayerName = null)
        {
            var response = Journal.GetGames(StatusGames,PlayerName);
            if (response is string)
            {
                return response;
            }
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id",typeof(int));
            dataTable.Columns["Id"].Caption = "ID";
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns["Name"].Caption = "Игрок";
            dataTable.Columns.Add("DateTime", typeof(DateTime));
            dataTable.Columns["DateTime"].Caption = "Дата игры";
            dataTable.Columns.Add("Score", typeof(int));
            dataTable.Columns["Score"].Caption = "Счет";
            foreach (var Item in (List<Journal>)response)
            {
                dataTable.Rows.Add(Item.Id, Item.Name, Item.DateTime, Item.Score);
            }
            return dataTable;
        }
    }
}
