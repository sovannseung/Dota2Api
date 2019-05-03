using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Api.Models
{
    public class TblTournement
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TournementId { get; set; }
        [Required]
        public string TournementName { get; set; }
        public string TournementFullName { get; set; }
        [Required]
        public string TournementImageUrl { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Status { get; set; }
        public long PricePool { get; set; }
        public string Location { get; set; }
        public string Overview { get; set; }

        //public ICollection<TblTournementTeam> TblTournementTeam { get; set; }
    }
}
