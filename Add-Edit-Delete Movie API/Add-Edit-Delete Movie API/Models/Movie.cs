using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Add_Edit_Delete_Movie_API.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public string MovieName { get; set;}
        
        [Required]
        public string plot { get; set; }

        [Required]
        public DateTime DateofRelease { get; set; }

        public string Producer { get; set; }

        public string Actor { get; set; }

        public byte[] poster { get; set; }

    }
}
