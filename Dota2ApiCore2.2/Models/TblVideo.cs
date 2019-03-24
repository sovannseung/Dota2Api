using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Api.Models
{
    public class TblVideo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VideoId { get; set; }
        [Required]
        public string VideoTitle { get; set; }
        [Required]
        public string VideoUrl { get; set; }
        public int MatchNum { get; set; }
        public DateTime MatchDate { get; set; }
        [Required]
        public string EventStage { get; set; }
        public int TournementId { get; set; }
        public int MainStageId { get; set; }
        public int TeamAId { get; set; }
        public int TeamBId { get; set; }
        public string TeamWin { get; set; }
        public int UserCreate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
