using InterkontinentalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterkontinentalAPI.Controllers
{
    [Route("game")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("get-active-game")]
        public async Task<IActionResult> GetActiveGame()
        {
            var gameId = await _gameService.GetActiveGameId();
            if (gameId == 0)
                return NotFound();

            return Ok(gameId);
        }

        [HttpGet("create")]
        public async Task<IActionResult> CreateGame()
        {
            var gameId = await _gameService.Create();

            return Ok(gameId);
        }

        [HttpGet("end/{id:int}")]
        public async Task<IActionResult> EndGame([FromRoute]int id)
        {
            var endResult = await _gameService.End(id);
            if(endResult)
                return Ok("Gra została zakończona pomyślnie");

            return BadRequest("Gra nie została zakończona pomyślnie. Powodem mogło być jej nieistnienie lub to, że była już zakończona");
        }

        [HttpGet("{gameId}/field-increment/{fieldId}")]
        public async Task<IActionResult> IncrementFieldCounter([FromRoute] int gameId, [FromRoute] int fieldId)
        {
            var count = await _gameService.Increment(gameId, fieldId);
            if (count == 0)
                return NotFound("Takie pole nie istnieje");

            return Ok(count);
        }

        [HttpGet("{gameId}/field-decrement/{fieldId}")]
        public async Task<IActionResult> DecrementFieldCounter([FromRoute] int gameId, [FromRoute] int fieldId)
        {
            var count = await _gameService.Decrement(gameId, fieldId);
            if (count == -1)
                return BadRequest("Nie można dekrementować pola o wartości 0 lub nieistniejącego");

            return Ok(count);
        }

        [HttpGet("fields")]
        public async Task<IActionResult> GetFields()
        {
            var fields = await _gameService.GetFields();

            return Ok(fields);
        }

        [HttpGet("{gameId:int}/get-active-counters")]
        public async Task<IActionResult> GetActiveCounters([FromRoute] int gameId)
        {
            var counterDtos = await _gameService.GetCounters(gameId);
            return Ok(counterDtos);
        }

        [HttpGet("get-statistics")]
        public async Task<IActionResult> GetStatistics([FromQuery] int start = 0, [FromQuery] int end = 2)
        {
            var statistics = await _gameService.GetStatistics(start, end);
            return Ok(statistics);
        }

        [HttpGet("number-of-games")]
        public async Task<IActionResult> GetNumberOfGames()
        {
            var numberOfGames = _gameService.GetNumberOfGames();

            return Ok(numberOfGames);
        }
    }
}
