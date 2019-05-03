using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2ApiCore2._2.Models
{
    public class viewGroupStage
    {
        public int GroupStageId { get; set; }
        public int TournementId { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string GroupName { get; set; }
        public string Logo_Url { get; set; }
        public int Win { get; set; }
        public int Lose { get; set; }
        public int Point { get; set; }
    }
}
