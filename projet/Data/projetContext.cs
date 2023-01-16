using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projet.Models;

namespace projet.Data
{
    public class projetContext : DbContext
    {
        public projetContext (DbContextOptions<projetContext> options)
            : base(options)
        {
        }

        public DbSet<projet.Models.Hotel> Hotel { get; set; }

        public DbSet<projet.Models.Review> Review { get; set; }
        public DbSet<projet.Models.Review> Reviews { get; set; }

        public DbSet<projet.Models.Room> Room { get; set; }

        public DbSet<projet.Models.Users> Users { get; set; }
    }
}
