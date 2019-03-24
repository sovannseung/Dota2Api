using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dota2ApiCore2._2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dota2ApiCore2_2.Controllers
{
    [Route("api/[controller]")]
    public class TournementController : ControllerBase
    {
        private ApplicationDbContext _dbContext;

        public TournementController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/Tournement/Paging
        [HttpGet("[action]")]
        public IActionResult Paging(int? pageNumber, int? pageSize)
        {
            var currentPageNumber = pageNumber ?? 1;
            var currentPageSize = pageSize ?? 10;

            var tournement = _dbContext.TblTournements.OrderByDescending(o => o.FromDate);

            return Ok(tournement.Skip((currentPageNumber - 1) * currentPageSize).Take(currentPageSize));
        }
    }
}