using System;
using System.Collections;
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
    public class TournementController : ControllerBase
    {
        private ApplicationDbContext _dbContext;

        public TournementController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/Tournement/TournementList
        [HttpGet]
        public IActionResult TournementList(int? pageNumber, int? pageSize, string time = "Ongoing")
        {
            var currentPageNumber = pageNumber ?? 1;
            var currentPageSize = pageSize ?? 10;

            if (time == "Pasted")
            {
                var tournement = _dbContext.TblTournements
                                 .Where(w => w.ToDate < DateTime.Now)
                                 .ToList();

                if (tournement.Count == 0)
                    return NotFound();
                else
                    return Ok(tournement);
            }
            else if (time == "Ongoing")
            {
                var tournement = _dbContext.TblTournements
                                 .Where(w => DateTime.Now >= w.FromDate && DateTime.Now <= w.ToDate)
                                 .ToList();

                if (tournement.Count == 0)
                    return NotFound();
                else
                    return Ok(tournement);
            }
            else if (time == "Upcoming")
            {
                var tournement = _dbContext.TblTournements
                                 .Where(w => w.FromDate > DateTime.Now)
                                 .ToList();

                if (tournement.Count == 0)
                    return NotFound();
                else
                    return Ok(tournement);
            }
            else // All
            {
                var tournement = _dbContext.TblTournements
                                 .ToList();

                if (tournement.Count == 0)
                    return NotFound();
                else
                    return Ok(tournement);
            }
                
        }

        // GET api/Tournement/Participants?TournementId=1
        [HttpGet]
        public IActionResult Participants(int id)
        {

            var participant = _dbContext.TblTournementTeams
                              .Join(_dbContext.TblTeams, TournementTeams => TournementTeams.TeamId, Teams => Teams.TeamId, (TournementTeams, Teams) =>
                                 new
                                 {
                                     TournementTeams.TournementTeamId,
                                     TournementTeams.StandFor,
                                     TournementTeams.TournementId,
                                     TournementTeams.TeamId,
                                     Teams.TeamName,
                                     Teams.Logo_Url
                                 })
                               .Where(T => T.TournementId == id)
                               .OrderBy(T => T.TeamName)
                               .ToList();

            if (participant.Count == 0)
                return NotFound();
            else
                return Ok(participant);
        }

        // GET api/Tournement/GroupStage?TournementId=1
        [HttpGet]
        public IActionResult GroupStage(int id)
        {
            var groupstage = _dbContext.viewGroupStages
                             .Where(g => g.TournementId == id)
                             .GroupBy(k => k.GroupName, v => v, (k, v) => new { groupName = k, groupDetails = v.ToList() })
                             .ToList();

            if (groupstage.Count == 0)
                return NotFound();
            else
                return Ok(groupstage);
        }

        // GET api/Tournement/PricePool?TournementId=1
        //[HttpGet("{TournementId}")]
        [HttpGet]
        public IActionResult PricePool(int id)
        {
            var pricepool = _dbContext.vPricePools
                            .FromSql("Select PricePoolId, TournementId, RankFrom, RankTo, PricePoolUSD, DPCPoints,​TblTeams.TeamId, TeamName From TblPricePools Left Join TblTeams On TblPricePools.TeamId = TblTeams.TeamId ")
                            .Where(w => w.TournementId == id)
                            .ToList();

            if (pricepool.Count == 0)
                return NotFound();
            else
                return Ok(pricepool);
        }

        // GET api/Tournement/MainStage?TournementId=1
        [HttpGet]
        public IActionResult MainStage(int id)
        {
            var mainstage = _dbContext.viewMainStages
                            .Where(w => w.TournementId == id)
                            .ToList();

            if (mainstage.Count == 0)
                return NotFound();
            else
                return Ok(mainstage);
        }
    }
}