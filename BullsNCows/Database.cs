namespace BullsNCows
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Journal")
        {
        }

        public virtual DbSet<Journal> JournalSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Journal>()
                .Property(e => e.History)
                .IsUnicode(false);
        }
    }
}
