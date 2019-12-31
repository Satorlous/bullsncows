namespace BullsNCows
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JournalSet")]
    public partial class Journal
    {
        /// <summary>
        /// ID Игры
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя игрока
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        /// <summary>
        /// Загаданное число
        /// </summary>
        [Required]
        [StringLength(20)]
        public string Answer { get; set; }
        /// <summary>
        /// Дата и время игры
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// История ходов
        /// </summary>
        [Column(TypeName = "text")]
        [Required]
        public string History { get; set; }
        /// <summary>
        /// Счет иргока
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// Флаг окончена игры или нет
        /// </summary>
        public bool End { get; set; }

        /// <summary>
        /// Созранение игры
        /// </summary>
        /// <param name="game">Экземпляр игры</param>
        public void SaveGame(Game game)
        {
            JournalContext.Add(game);
        }

        /// <summary>
        /// Загрузка игр
        /// </summary>
        /// <param name="StatusGames">Флаг состояния игр</param>
        /// <returns></returns>
        public object GetGames(bool StatusGames,string PlayerName = null)
        {
            return JournalContext.GetGames(PlayerName,StatusGames);
        }

        /// <summary>
        /// Загрузка игры
        /// </summary>
        /// <param name="IdGame">Id игры</param>
        /// <returns></returns>
        public Journal LoadGame(int IdGame)
        {
            Journal journal = JournalContext.Loadgame(IdGame);
            return journal;
        }
    }
}
