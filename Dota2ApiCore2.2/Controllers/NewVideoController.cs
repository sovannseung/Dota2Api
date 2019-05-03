using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dota2ApiCore2._2.Data;
using Dota2ApiCore2._2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dota2ApiCore2_2.Controllers
{
    //[Route("api/[controller]/[action]")]
    public class NewVideoController : Controller
    {
        private ApplicationDbContext _dbContext;

        public NewVideoController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get(int VideoId)
        {
            var video = _dbContext.TblVideos.Find(VideoId);

            if (video == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(video);
            }
        }

        // GET api/NewVideo/Paging
        //[HttpGet("[action]"]
        [HttpGet]
        public IActionResult Paging(int? pageNumber, int? pageSize)
        {
            var currentPageNumber = pageNumber ?? 1;
            var currentPageSize = pageSize ?? 10;

            //var videos = _dbContext.TblVideos
            //              .OrderByDescending(v => v.MatchDate)
            //              .Join(_dbContext.TblTeams, v => v.TeamAId, tA => tA.TeamId, (v, tA) =>
            //              new
            //              {
            //                  v,
            //                  tA,
            //                  tA.Logo_Url,
            //              }).Join(_dbContext.TblTeams, vB => vB.v.TeamBId, tB => tB.TeamId, (v, tB) =>
            //             new
            //             {
            //                 v.v.VideoId,
            //                 v.v.VideoTitle,
            //                 v.v.VideoUrl,
            //                 v.v.TeamAId,
            //                 TeamALogo_Url = v.tA.Logo_Url,
            //                 v.v.TeamBId,
            //                 TeamBLogo_Url = tB.Logo_Url
            //             });

            //var videos = _dbContext.viewVideos.FromSql("Select VideoId, VideoTitle, VideoUrl, TeamAId, TA.Logo_Url As TeamALogo_Url, TeamBId, TB.Logo_Url As TeamBLogo_Url From TblVideos V Inner Join TblTeams TA On V.TeamAId = TA.TeamId Inner Join TblTeams TB On V.TeamBId = TB.TeamId");
            //var videos = _dbContext.Query<viewVideo>().ToList();
            //var videos = _dbContext.Query<viewVideo>().FromSql("Select VideoId, VideoTitle, VideoUrl, TeamAId, TA.Logo_Url As TeamALogo_Url, TeamBId, TB.Logo_Url As TeamBLogo_Url From TblVideos V Inner Join TblTeams TA On V.TeamAId = TA.TeamId Inner Join TblTeams TB On V.TeamBId = TB.TeamId");

            var videos = _dbContext.viewVideos.ToList().
                         Skip((currentPageNumber - 1) * currentPageSize).
                         Take(currentPageSize);

            return Ok(videos);
        }

    }
}