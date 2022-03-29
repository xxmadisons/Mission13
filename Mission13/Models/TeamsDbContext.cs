using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    public class TeamsDbContext : DbContext
    {
        private static DbContextOptions options;

        public TeamsDbContext(DbContextOptions<TeamsDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
    }
}
