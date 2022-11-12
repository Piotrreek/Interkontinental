using InterkontinentalAPI.Entities;
using InterkontinentalAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InterkontinentalAPI.Services
{
    public interface IGameService
    {
        Task<int> Create();
        Task<bool> End(int id);
        Task<List<FieldDto>> GetFields();
        Task<int> Increment(int gameId, int fieldId);
        Task<int> Decrement(int gameId, int fieldId);
    }

    public class GameService : IGameService
    {
        private readonly InterkontinentalContext _context;

        public GameService(InterkontinentalContext context)
        {
            _context = context;
        }

        public async Task<int> Create()
        {
            var game = new Game();
            await _context.AddAsync(game);
            await _context.SaveChangesAsync();

            for (var i = 1; i < 51; i++)
            {
                var counter = new Counter()
                {
                    FieldId = i,
                    GameId = game.Id,
                };
                _context.Counters.Add(counter);
            }
            await _context.SaveChangesAsync();

            return game.Id;
        }

        public async Task<bool> End(int id)
        {
            var game = await _context.Games.FirstOrDefaultAsync(g => g.Id == id);
            if(game is null || game.HasEnded)
                return false;

            game.End = DateTime.Now;
            game.HasEnded = true;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<FieldDto>> GetFields()
        {
            var fields = await _context.Fields
                .AsNoTracking()
                .ToListAsync();
            var fieldsDtos = fields.Select(f => new FieldDto()
            {
                Id = f.Id,
                Name = f.Name,
            }).ToList();

            return fieldsDtos;
        }

        public async Task<int> Increment(int gameId, int fieldId)
        {
            var counter = await _context.Counters
                .FirstOrDefaultAsync(c => c.FieldId == fieldId && c.GameId == gameId);
            if(counter is null)
                return 0;

            counter.Count++;
            await _context.SaveChangesAsync();

            return counter.Count;
        }

        public async Task<int> Decrement(int gameId, int fieldId)
        {
            var counter = await _context.Counters
                .FirstOrDefaultAsync(c => c.FieldId == fieldId && c.GameId == gameId);
            if (counter is null)
                return -1;

            counter.Count--;
            await _context.SaveChangesAsync();

            return counter.Count;
        }
    }
}
