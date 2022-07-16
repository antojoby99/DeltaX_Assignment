using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Add_Edit_Delete_Movie_API.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Add_Edit_Delete_Movie_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly Contextclass _dbcontext;

        public MovieController(Contextclass context)
        {
            _dbcontext = context;
        }



        [Route("ViewMovies")]
        [HttpGet]
        public IActionResult View()
        {
            return Ok(_dbcontext.Movies.ToList());
        }


        [Route("AddMovie")]
        [HttpPost]
        public IActionResult Create(Movie obj)
        {
            _dbcontext.Movies.Add(obj);
            _dbcontext.SaveChanges();
            return Ok("Movie Details are Added to Database");
        }

        [Route("EditMovie")]
        [HttpPut]
        public IActionResult UpdateStudent(Movie obj)
        {
            _dbcontext.Movies.Update(obj);
            _dbcontext.SaveChanges();
            return Ok("Student details are updated in database");
        }

        [HttpDelete("{MovieName}")]
        public IActionResult DeleteStudent(string MovieName)
        {
            Movie obj = _dbcontext.Movies.Find(MovieName);

            if (obj != null)
            {
                _dbcontext.Movies.Remove(obj);
                _dbcontext.SaveChanges();
                return Ok("Movie details are deleted from database");
            }
            else
            {
                return NotFound("Requested Movie name does not exists");
            }
        }

        [Route("Producer_Names")]
        [HttpGet]
        public IActionResult ProducerNames()
        {
            using (HttpClient client = new HttpClient())
            {
               
                client.BaseAddress = new Uri("https://localhost:44318/api/");
                var responseTask = client.GetAsync("Producer/ViewProducer");
                responseTask.Wait();
                var result = responseTask.Result;


                List<Producer> lsProducer = new List<Producer>();

                if (result.IsSuccessStatusCode)
                {
                    
                    string jsonData = result.Content.ReadAsStringAsync().Result;


                    lsProducer = JsonConvert.DeserializeObject<List<Producer>>(jsonData);

                    return Ok(lsProducer.Select(x=>x.Producer_Name).ToList());
                    
                }
                else
                {
                    return BadRequest();
                    
                }

            };

        }

        [Route("Actor_Names")]
        [HttpGet]
        public IActionResult ActorNames()
        {
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44307/api/");
                var responseTask = client.GetAsync("Actor/ViewActors");
                responseTask.Wait();
                var result = responseTask.Result;


                List<Actor> lsActors = new List<Actor>();

                if (result.IsSuccessStatusCode)
                {

                    string jsonData = result.Content.ReadAsStringAsync().Result;


                    lsActors = JsonConvert.DeserializeObject<List<Actor>>(jsonData);

                    return Ok(lsActors.Select(x => x.Name).ToList());

                }
                else
                {
                    return BadRequest();

                }

            };

        }


    }
}
