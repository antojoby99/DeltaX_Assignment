using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Add_Producer_API.Models
{
    public class Contextclass : DbContext
    {
        public DbSet<Producer> Producer { get; set; }

        public Contextclass(DbContextOptions<Contextclass> options)
           : base(options)
        {

        }
    }
}
