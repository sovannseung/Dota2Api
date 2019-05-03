using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Api.Models
{
    public class TblGroupStage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupStageId { get; set; }

        public int TournementId { get; set; }
        public TblTournement TblTournement { get; set; }

        public int TeamId { get; set; }
        public TblTeam TblTeam { get; set; }

        public string GroupName { get; set; }
    }
}
