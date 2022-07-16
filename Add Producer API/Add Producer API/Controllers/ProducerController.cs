using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Add_Producer_API.Models;
using Microsoft.EntityFrameworkCore;


namespace Add_Producer_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private readonly Contextclass _context;

        public ProducerController(Contextclass context)
        {
            _context = context;
        }
        [Route("ViewProducer")]
        [HttpGet]
        public IActionResult View()
        {
            return Ok(_context.Producer.ToList());
        }

        [Route("AddProducer")]
        [HttpPost]
        public IActionResult Create(Producer obj)
        {
            _context.Producer.Add(obj);
            _context.SaveChanges();
            return Ok("Producer Details are Added to Database");
        }
    }
}
