using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Add_Actor_API.Models
{
    public class Actor
    {

        [Required]
        [Key]
        public string Name { get; set; }


        public string Bio { get; set; }

        public DateTime DateofBirth { get; set; }

        public string Gender { get; set; }
    }

}
