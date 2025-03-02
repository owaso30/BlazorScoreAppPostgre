using BlazorScoreAppPostgre.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorScoreAppPostgre.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Trial> Trials { get; set; }
        public DbSet<TrialSeat> TrialSeats { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}
