using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Newtonsoft.Json;

namespace BullsNCows
{
    class JournalContext : DbContext
    {
        public JournalContext() : base("DBConnection")
        { }

        public DbSet<Journal> Records { get; set; }

        /// <summary>
        /// Сохранение игры
        /// </summary>
        /// <param name="game"></param>
        public static void Add(Game game)
        {
            AsyncAdd(game);
        }

        /// <summary>
        /// Сохранения результата в БД
        /// </summary>
        /// <param name="game"></param>
        private static void AsyncAdd(Game game)
        {
            Task.Run(() =>
            {
                using (JournalContext db = new JournalContext())
                {
                    try
                    {
                        Journal journal = new Journal
                        {
                            Answer = String.Join("", game.Answer),
                            DateTime = DateTime.Now,
                            Name = game.Name,
                            Score = game.Score,
                            History = JsonConvert.SerializeObject(game.History),
                            End = game.EndGame,
                        };
                        db.Records.Add(journal);
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException e)
                    {
                        string s = "";
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            s = String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                s += String.Format("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                    }
                }
            });
        }
    }
}
