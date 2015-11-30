using System;
using System.Data.Entity;

namespace GraWKosci.DAL {
    public class KosciContext :DbContext {
        public KosciContext() :base() {
            
        }
        public DbSet<SqlGame> SqlGames { get; set; }
        public DbSet<SqlPlayer> SqlPlayers { get; set; }
    }
}