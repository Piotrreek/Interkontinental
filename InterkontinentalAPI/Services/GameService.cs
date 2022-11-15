using InterkontinentalAPI.Entities;
using InterkontinentalAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace InterkontinentalAPI.Services
{
    public interface IGameService
    {
        Task<int> Create();
        Task<bool> End(int id);
        Task<List<IGrouping<string, FieldDto>>> GetFields();
        Task<int> Increment(int gameId, int fieldId);
        Task<int> Decrement(int gameId, int fieldId);
        Task<int> GetActiveGameId();
        Task<List<CounterDto>> GetCounters(int gameId);
        Task<List<GameDto>> GetStatistics(int start, int end);
        int GetNumberOfGames();
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
            game.Start = DateTime.Now;
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

        public async Task<List<IGrouping<string, FieldDto>>> GetFields()
        {
            var fields = await _context.Fields
                .AsNoTracking()
                .ToListAsync();
            var fieldsDtos = fields.Select(f => new FieldDto()
            {
                Id = f.Id,
                Name = f.Name,
                Type = f.Type
            })
                .GroupBy(fd => fd.Type)
                .ToList();

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

        public async Task<int> GetActiveGameId()
        {
            var game = await _context.Games
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.HasEnded == false);
            return game?.Id ?? 0;
        }

        public async Task<List<CounterDto>> GetCounters(int gameId)
        {
            var counters = await _context.Counters
                .AsNoTracking()
                .Where(c => c.GameId == gameId)
                .ToListAsync();

            return counters.Select(c => new CounterDto
            {
                Count = c.Count,
                FieldId = c.FieldId
            }).ToList();
        }

        public async Task<List<GameDto>> GetStatistics(int start, int end)
        {
            var games = await _context.Games
                .AsNoTracking()
                .Where(g => g.HasEnded)
                .Where(g => g.Id > start && g.Id <= end)
                .ToListAsync();

            var counters = await _context.Counters
                .AsNoTracking()
                .Where(c => c.GameId > start && c.GameId <= end)
                .ToListAsync();

            var gamesCounters = games
                .GroupJoin(counters, g => g.Id, c => c.GameId, (g, c) =>
                        new GameDto()
                        {
                            Counters = c.Select(cc => new CounterDto
                            {
                                Count = cc.Count,
                                FieldId = cc.FieldId
                            }),
                            End = g.End.ToShortDateString() + "  " + g.End.ToShortTimeString(),
                            Start = g.Start.ToShortDateString() + "  " + g.Start.ToShortTimeString(),
                        }).ToList();

            return gamesCounters;
        }

        public int GetNumberOfGames()
        {
            var numberOfGames = _context.Games
                .AsNoTracking()
                .Count();

            return numberOfGames;
        }
    }
}
