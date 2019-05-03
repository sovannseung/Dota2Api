using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2ApiCore2._2.Models
{
    public class TblPricePool
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PricePoolId { get; set; }
        public int TournementId { get; set; }
        public int RankFrom { get; set; }
        public int RankTo { get; set; }
        public int PricePoolUSD { get; set; }
        public int DPCPoints { get; set; }
        public int? TeamId { get; set; }
    }
}
