using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly PeopleDb db;

        public PeopleController(PeopleDb db)
          {
            this.db = db;
          }


        [HttpGet]
        public IActionResult Get()
        {
            /*     var people = new List<Person>
             {
                 new Person
                 {
                     FirstName = "Michal",
                     LastName = "Wozniak",
                     Id = 1
                 }
             }; */
            var people = db.People.ToList();
            return Ok(people);
        }
    }


    
}