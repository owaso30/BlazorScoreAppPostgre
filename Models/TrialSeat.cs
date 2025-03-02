using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorScoreAppPostgre.Models
{
    [Table("TrialSeats")]
    public class TrialSeat
    {
        [Key]
        [Column("TrialSeatID")]
        public int TrialSeatId { get; set; }

        [ForeignKey(nameof(Trial))]
        [Column("TrialID")]
        public int TrialId { get; set; }

        [ForeignKey(nameof(Player))]
        [Column("PlayerID")]
        public int PlayerId { get; set; }

        [Column("SeatID")]
        public int SeatId { get; set; }

        [Column("LoginUserID")]
        public string? LoginUserId { get; set; }

        public Trial Trial { get; set; } = null!;

        public Player Player { get; set; } = null!;

        public ICollection<Table> Tables { get; } = new List<Table>();
    }
}
