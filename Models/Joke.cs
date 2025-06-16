using System.ComponentModel.DataAnnotations;

namespace jokeswebapp.Models
{
    public class Joke
    {
        [Key]
        public int Id { get; set; }  // ✅ Primary Key

        [Required]
        public string JokeQuestion { get; set; }

        [Required]
        public string JokeAnswer { get; set; }
    }
}
