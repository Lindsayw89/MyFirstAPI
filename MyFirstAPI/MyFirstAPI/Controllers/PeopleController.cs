using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Models;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private static readonly List<Person> _people = new List<Person>

         {
     new Person
     {
         Id = 1,
         Name = "Luke Skywalker",
         HairColor = "blond"
     },
     new Person
     {
         Id = 5,
         Name = "Leia Organa",
         HairColor = "brown"
     }
 };

        // GET api/values
        [HttpGet]


        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_people); // return the whole list of people
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person == null) return NotFound();
            return Ok(person);
        }


        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Person newPerson)
        {
            _people.Add(newPerson);
            return CreatedAtAction("Get", newPerson, new { id = new Random().Next() });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person updatedPerson)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person == null) return BadRequest();
            person.Name = updatedPerson.Name;
            person.HairColor = updatedPerson.Name;
            // in real app, save the data to a database
            return Ok(_people);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person != null) 
            {
                _people.Remove(person);
               // return NoContent();
                return Ok(_people);
            }
            return BadRequest();
        }
    }
}
