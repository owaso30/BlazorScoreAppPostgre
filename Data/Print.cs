using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorScoreAppPostgre.Data
{
    public class Print
    {
        public int usercount { get; set; }
        public string? startdate { get; set; }
        public string? enddate { get; set; }
        public string[]? usermane { get; set; } = new string[40];
        public string[]? tablecount { get; set; } = new string[40];
        public string[]? scoresum { get; set; } = new string[40];
        public string[]? scoreave { get; set; } = new string[40];
        public string[]? rankave { get; set; } = new string[40];
        public string[]? yakumancount { get; set; } = new string[40];
        public string[]? ratio_1 { get; set; } = new string[40];
        public string[]? ratio_2 { get; set; } = new string[40];
        public string[]? ratio_3 { get; set; } = new string[40];
        public string[]? ratio_4 { get; set; } = new string[40];
        public string[]? recent5 { get; set; } = new string[40];
    }
}
