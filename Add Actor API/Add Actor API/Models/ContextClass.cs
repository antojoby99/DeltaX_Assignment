using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Add_Actor_API.Models
{
    public class Contextclass : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        public Contextclass(DbContextOptions<Contextclass> options)
           : base(options)
        {

        }
    }
}
