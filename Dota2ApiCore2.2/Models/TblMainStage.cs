using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Api.Models
{
    public class TblMainStage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MainStageId { get; set; }
        public int MainStagePairId { get; set; }
        public int TournementId { get; set; }
        public TblTournement TblTournement { get; set; }
        [Column(Order = 0)]
        public string BracketType { get; set; }
        [Column(Order = 1)]
        public int Levels { get; set; }
        [Column(Order = 2)]
        public int TeamAId { get; set; }
        [Column(Order = 3)]
        public int TeamBId { get; set; }

    }
}
