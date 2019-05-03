using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2ApiCore2._2.Models
{
    public class viewVideo
    {
        public int VideoId { get; set; }
        public string VideoTitle { get; set; }
        public string VideoUrl { get; set; }
        public int TeamAId { get; set; }
        public string TeamALogo_Url { get; set; }
        public int TeamBId { get; set; }
        public string TeamBLogo_Url { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
