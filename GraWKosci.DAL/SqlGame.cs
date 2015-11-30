using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GraWKosci.DAL {
    public class SqlGame {
        public SqlGame() {
            Time = DateTime.Now;
        }
        public int Id { get; set; }
        [DefaultValue("Gra")]
        public string GameName { get; set; }
        
        public DateTime Time { get; set; }
        public virtual IQueryable<SqlPlayer> Players { get; set; }
    }
}