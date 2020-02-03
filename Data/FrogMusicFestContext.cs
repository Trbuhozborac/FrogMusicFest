using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FrogMusicFest.Models;

namespace FrogMusicFest.Data
{
    public class FrogMusicFestContext : DbContext
    {
        public FrogMusicFestContext (DbContextOptions<FrogMusicFestContext> options)
            : base(options)
        {
        }

        public DbSet<FrogMusicFest.Models.Izvodjac> Izvodjac { get; set; }
    }
}
