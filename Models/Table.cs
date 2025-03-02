using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorScoreAppPostgre.Models
{
    [Table("Tables")]
    public class Table
    {
        [Key]
        [Column("TableID")]
        public int TableId { get; set; }

        [ForeignKey(nameof(TrialSeat))]
        [Column("TrialSeatID")]
        public int TrialSeatId { get; set; }

        [Column("TableCountID")]
        public int TableCountId { get; set; }

        [Column("Score")]
        public int? Score { get; set; }

        [Column("Rank")]
        public int? Rank { get; set; }

        [Column("LoginUserID")]
        public string? LoginUserId { get; set; }

        public TrialSeat TrialSeat { get; set; } = null!;
    }
}
