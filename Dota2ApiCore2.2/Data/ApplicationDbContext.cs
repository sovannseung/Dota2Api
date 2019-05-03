using Dota2Api.Models;
using Dota2ApiCore2._2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2ApiCore2._2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TblTeam> TblTeams { get; set; }
        public DbSet<TblTournement> TblTournements { get; set; }
        public DbSet<TblTournementTeam> TblTournementTeams { get; set; }
        public DbSet<TblGroupStage> TblGroupStages { get; set; }
        public DbSet<TblVideo> TblVideos { get; set; }
        public DbSet<TblMainStage> TblMainStages { get; set; }
        public DbSet<TblPricePool> TblPricePools { get; set; }

        public DbQuery<viewVideo> viewVideos { get; set; }
        public DbQuery<viewGroupStage> viewGroupStages { get; set; }
        public DbQuery<viewMainStage> viewMainStages { get; set; }

        public DbQuery<vPricePool> vPricePools { get; set; }
    }
}
