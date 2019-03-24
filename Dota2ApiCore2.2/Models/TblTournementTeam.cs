using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Api.Models
{
    public class TblTournementTeam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TournementTeamId { get; set; }
        public string StandFor { get; set; }

        public int TournementId { get; set; }
        public TblTournement TblTournement { get; set; }

        public int TeamId { get; set; }
        public TblTeam TblTeam { get; set; }
    }
}
