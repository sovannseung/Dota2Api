using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2ApiCore2._2.Models
{
    public class viewMainStage
    {
        public int MainStageId { get; set; }
        public int TournementId { get; set; }
        public string BracketType { get; set; }
        public int Levels { get; set; }
        public int TeamAId { get; set; }
        public string TeamAName { get; set; }
        public int TeamBId { get; set; }
        public string TeamBName { get; set; }
    }
}
