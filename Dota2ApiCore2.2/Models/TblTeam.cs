using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Api.Models
{
    public class TblTeam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string Tag { get; set; }
        public string Logo_Url { get; set; }
        public string Description { get; set; }

        //[InverseProperty("TblTeamA")]
        //public ICollection<TblGroupStageMatch> TblTeamAs { get; set; }

        //[InverseProperty("TblTeamB")]
        //public ICollection<TblGroupStageMatch> TblTeamBs { get; set; }

        //public ICollection<TblTournementTeam> TblTournementTeam { get; set; }
    }
}
