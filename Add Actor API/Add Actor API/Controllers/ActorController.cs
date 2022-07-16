using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Add_Actor_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Add_Actor_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly Contextclass _dbcontext;

        public ActorController(Contextclass context)
        {
            _dbcontext = context;
        }
        [Route("ViewActors")]
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_dbcontext.Actors.ToList());
        }
        [Route("AddActor")]
        [HttpPost]
        public IActionResult AddActor(Actor obj)
        {
            _dbcontext.Actors.Add(obj);
            _dbcontext.SaveChanges();
            return Ok("Actor details are added to database");
        }


    }
}
