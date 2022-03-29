﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    public class BowlersDbContext : DbContext
    {
        private static DbContextOptions options;

        public BowlersDbContext(DbContextOptions<BowlersDbContext> options) : base(options)
        {

        }

        public DbSet<Bowler> Bowlers { get; set; }

    }
}
