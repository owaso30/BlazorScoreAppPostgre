using BlazorScoreAppPostgre.Data;
using BlazorScoreAppPostgre.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorScoreAppPostgre.Services
{
    public class TrialSeatService
    {
        private readonly ApplicationDbContext _context;

        public TrialSeatService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TrialSeat>> GetValuesAsync(string userId)
        {
            var values = await _context.TrialSeats.Where(e => e.LoginUserId == userId).ToListAsync();
            return values;
        }

        public async Task UpdateValueAsync(string userId, TrialSeat value)
        {
            var existing = await _context.TrialSeats.FindAsync(value.TrialSeatId);
            if (existing != null && existing.LoginUserId == userId)
            {
                value.LoginUserId = userId;
                _context.Entry(existing).CurrentValues.SetValues(value);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteValueAsync(string userId, int id)
        {
            var existing = await _context.TrialSeats.FindAsync(id);
            if (existing != null && existing.LoginUserId == userId)
            {
                _context.TrialSeats.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddValueAsync(string userId, TrialSeat value)
        {
            value.LoginUserId = userId;
            _context.TrialSeats.Add(value);
            await _context.SaveChangesAsync();
        }
    }
}