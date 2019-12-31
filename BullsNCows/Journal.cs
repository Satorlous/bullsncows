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
        /// ID ����
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ��� ������
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        /// <summary>
        /// ���������� �����
        /// </summary>
        [Required]
        [StringLength(20)]
        public string Answer { get; set; }
        /// <summary>
        /// ���� � ����� ����
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// ������� �����
        /// </summary>
        [Column(TypeName = "text")]
        [Required]
        public string History { get; set; }
        /// <summary>
        /// ���� ������
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// ���� �������� ���� ��� ���
        /// </summary>
        public bool End { get; set; }

        /// <summary>
        /// ���������� ����
        /// </summary>
        /// <param name="game">��������� ����</param>
        public void SaveGame(Game game)
        {
            JournalContext.Add(game);
        }

        /// <summary>
        /// �������� ���
        /// </summary>
        /// <param name="StatusGames">���� ��������� ���</param>
        /// <returns></returns>
        public object GetGames(bool StatusGames,string PlayerName = null)
        {
            return JournalContext.GetGames(PlayerName,StatusGames);
        }

        /// <summary>
        /// �������� ����
        /// </summary>
        /// <param name="IdGame">Id ����</param>
        /// <returns></returns>
        public Journal LoadGame(int IdGame)
        {
            Journal journal = JournalContext.Loadgame(IdGame);
            return journal;
        }
    }
}
