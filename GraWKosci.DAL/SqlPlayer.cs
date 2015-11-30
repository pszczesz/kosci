using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GraWKosci.DAL {
    public class SqlPlayer {
        public int Id { get; set; }
        [Required(ErrorMessage = "Podaj nazwę gracza")]
        public string Name { get; set; }
        [DefaultValue(0)]
        public int Score { get; set; }
         
    }
}