using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Add_Edit_Delete_Movie_API.Models;

namespace Add_Edit_Delete_Movie_API.Models
{
    public class Contextclass : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public Contextclass(DbContextOptions<Contextclass> options)
           : base(options)
        {

        }
    }
}
