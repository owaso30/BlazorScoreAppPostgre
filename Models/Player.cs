using BlazorScoreAppPostgre.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorScoreAppPostgre.Models
{
    [Table("Players")]
    [Index(nameof(PlayerName), IsUnique = true)]  // PlayerName列に一意のインデックスを追加
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   // 自動採番を無効にする
        [Column("PlayerID")]
        public int PlayerId { get; set; }

        [Column("PlayerName")]
        [StringLength(20)]
        public string? PlayerName { get; set; }

        [Column("LoginUserID")]
        public string? LoginUserId { get; set; }

        public ICollection<TrialSeat> TrialSeats { get; } = new List<TrialSeat>();
    }
}
