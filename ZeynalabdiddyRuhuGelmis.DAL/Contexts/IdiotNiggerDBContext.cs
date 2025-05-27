using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ZeynalabdiddyRuhuGelmis.DAL.Models;

namespace ZeynalabdiddyRuhuGelmis.DAL.Contexts
{
    public class IdiotNiggerDBContext : DbContext
    {
        private readonly string _niggerstring = "Database=HogRiders;Server=localhost;Trusted_connection=True;TrustServerCertificate=True";

        public DbSet<NiggaThatNeedHelp> niggasThatNeedHelp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_niggerstring);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
