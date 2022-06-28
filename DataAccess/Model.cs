using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication1RainerStropek.DataAccess
{
    public class GameGenre
    {
        public int Id { get; set; }
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
        [JsonIgnore]
        public List<Game>? games { get; set; }

    }

    public class Game
    {
        public int ID { get; set; }
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
        public GameGenre? Genre { get; set; }
        public int? GameGenreId { get; set; }
        public int personalRating { get; set; }
    }
}
