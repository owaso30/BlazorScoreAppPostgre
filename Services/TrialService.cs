using BlazorScoreAppPostgre.Data;
using BlazorScoreAppPostgre.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorScoreAppPostgre.Services
{
    public class TrialService
    {
        private readonly ApplicationDbContext _context;

        public TrialService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Trial>> GetValuesAsync(string userId)
        {
            var values = await _context.Trials.Where(e => e.LoginUserId == userId).ToListAsync();
            return values;
        }

        public async Task UpdateValueAsync(string userId, Trial value)
        {
            var existing = await _context.Trials.FindAsync(value.TrialId);
            if (existing != null && existing.LoginUserId == userId)
            {
                value.LoginUserId = userId;
                _context.Entry(existing).CurrentValues.SetValues(value);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteValueAsync(string userId, int id)
        {
            var existing = await _context.Trials.FindAsync(id);
            if (existing != null && existing.LoginUserId == userId)
            {
                _context.Trials.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddValueAsync(string userId, Trial value)
        {
            value.LoginUserId = userId;
            _context.Trials.Add(value);
            await _context.SaveChangesAsync();
        }
    }
}