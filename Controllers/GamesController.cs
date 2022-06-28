using Microsoft.AspNetCore.Mvc;
using WebApplication1RainerStropek.DataAccess;

namespace WebApplication1RainerStropek.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GamesController:ControllerBase
    {
        private readonly VideoGameDataContext Dbcontext;

        public GamesController(VideoGameDataContext dbcontext)
        {
            Dbcontext = dbcontext;
        }
        [HttpGet]
        public IEnumerable<Game> getAllGames()
        {
            return this.Dbcontext.games;
        }
        [HttpPost]
        public async Task<Game> AddGame([FromBody]Game newGame)
        {
            Dbcontext.Add(newGame);
           await Dbcontext.SaveChangesAsync();
            return newGame;
        }
        [HttpGet]
        [Route("{id}")]
        public Game GetGameByID(int id)
        {
            return Dbcontext.games.FirstOrDefault(g => g.ID == id);
        }

    }
}
