
using Microsoft.EntityFrameworkCore;

namespace WebApplication1RainerStropek.DataAccess
{
    public class VideoGameDataContext : DbContext
    {
        //an empty constructor 
        public VideoGameDataContext(DbContextOptions<VideoGameDataContext> options) : base(options)
        {


        }
        //two data sets for games and the genres
        public DbSet<Game> games{ get; set; }
        public DbSet<GameGenre> gameGenres{ get; set; }
    }
}
