using BlazorScoreAppPostgre.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorScoreAppPostgre.Models
{
    [Table("Trials")]
    public class Trial
    {
        [Key]
        [Column("TrialID")]
        public int TrialId { get; set; }

        [Column("TrialDateTime")]
        private DateTime _TrialDateTime;
        public DateTime TrialDateTime 
        { 
            get => _TrialDateTime; 
            set => _TrialDateTime = value.ToUniversalTime();
        }

        [Column("StartReturn")]
        public string? StartReturn { get; set; } = "25-30";

        [Column("BonusByRanking")]
        public string? BonusByRanking { get; set; } = "10-30";

        [Column("ChipsPrice")]
        public int? ChipsPrice { get; set; } = 0;

        [Column("YakitoriPrice")]
        public int? YakitoriPrice { get; set; } = 0;

        [Column("TobiPrice")]
        public int? TobiPrice { get; set; } = 0;

        [Column("YakumanPrice")]
        public int? YakumanPrice { get; set; } = 0;

        [Column("LoginUserID")]
        public string? LoginUserId { get; set; }

        public ICollection<TrialSeat> TrialSeats { get; } = new List<TrialSeat>();
    }
}
