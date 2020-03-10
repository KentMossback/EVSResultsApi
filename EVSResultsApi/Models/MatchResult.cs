using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVSResultsApi.Models
{
    public class MatchResult
    {
        public int MatchId { get; set; }
        public int LagA { get; set; }
        public int LagB { get; set; }
        public int LagA_Set1 { get; set; }
        public int LagA_Set2 { get; set; }
        public int LagA_Set3 { get; set; }
        public int LagB_Set1 { get; set; }
        public int LagB_Set2 { get; set; }
        public int LagB_Set3 { get; set; }
    }
}
