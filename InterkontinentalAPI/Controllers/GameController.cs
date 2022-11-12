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
    }
}
