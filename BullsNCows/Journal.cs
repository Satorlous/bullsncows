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
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Answer { get; set; }

        public DateTime DateTime { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string History { get; set; }

        public int Score { get; set; }

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

        public Journal LoadGame(int IdGame)
        {
            Journal journal = JournalContext.Loadgame(IdGame);
            return journal;
        }
    }
}
