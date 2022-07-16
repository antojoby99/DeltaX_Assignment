using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Add_Producer_API.Models
{
    public class Producer
    { 
        [Key]
        public string Producer_Name { get; set; }
        public string Bio { get; set; }

        public DateTime Date_of_birth { get; set; }

        public string Comapny { get; set; }

        public string Gender { get; set; }


    }
}
