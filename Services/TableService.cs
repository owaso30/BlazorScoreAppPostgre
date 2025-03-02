using BlazorScoreAppPostgre.Data;
using BlazorScoreAppPostgre.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorScoreAppPostgre.Services
{
    public class TableService
    {
        private readonly ApplicationDbContext _context;

        public TableService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Table>> GetValuesAsync(string userId)
        {
            var values = await _context.Tables.Where(e => e.LoginUserId == userId).ToListAsync();
            return values;
        }

        public async Task UpdateValueAsync(string userId, Table value)
        {
            var existing = await _context.Tables.FindAsync(value.TableId);
            if (existing != null && existing.LoginUserId == userId)
            {
                value.LoginUserId = userId;
                _context.Entry(existing).CurrentValues.SetValues(value);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteValueAsync(string userId, int id)
        {
            var existing = await _context.Tables.FindAsync(id);
            if (existing != null && existing.LoginUserId == userId)
            {
                _context.Tables.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddValueAsync(string userId, Table value)
        {
            value.LoginUserId = userId;
            _context.Tables.Add(value);
            await _context.SaveChangesAsync();
        }
    }
}