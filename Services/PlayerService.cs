using BlazorScoreAppPostgre.Data;
using BlazorScoreAppPostgre.Models;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorScoreAppPostgre.Services
{
    public class PlayerService
    {
        private readonly ApplicationDbContext _context;

        public PlayerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Player>> GetValuesAsync(string userId)
        {
            var values = await _context.Players.Where(e => e.LoginUserId == userId).ToListAsync();
            return values;
        }

        public async Task UpdateValueAsync(string userId, Player value)
        {
            var existing = await _context.Players.FindAsync(value.PlayerId);
            if (existing != null && existing.LoginUserId == userId)
            {
                value.LoginUserId = userId;
                _context.Entry(existing).CurrentValues.SetValues(value);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteValueAsync(string userId, int id)
        {
            var existing = await _context.Players.FindAsync(id);
            if (existing != null && existing.LoginUserId == userId)
            {
                _context.Players.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddValueAsync(string userId, Player value)
        {
            value.LoginUserId = userId;
            _context.Players.Add(value);
            await _context.SaveChangesAsync();
        }
    }
}