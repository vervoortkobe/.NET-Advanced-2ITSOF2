using Microsoft.AspNetCore.Mvc;
using MyGameStore.DAL;
using MyGameStore.Model;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly MyGameStoreContext context;

        public PeopleController(MyGameStoreContext context)
        {
            this.context = context;
        }

        [HttpGet]   //api/people?lastname=Janssens
        public IActionResult GetAllPeople([FromQuery] string lastName)
        {
            if (!string.IsNullOrEmpty(lastName))
            {
                //TODO: improve with LINQ
                List<Person> filtered = new List<Person>();
                foreach (var p in context.People)
                {
                    if (p.LastName == lastName)
                    {
                        filtered.Add(p);
                    }
                }
                return Ok(filtered);
            }
            else
                return Ok(context.People);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPerson(int id)
        {
            var person = context.People.FirstOrDefault(p => p.Id == id);
            if (person != null)
                return Ok(person);

            return NotFound();
        }


        [HttpPost]
        public IActionResult CreatePerson([FromBody]Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
            return Created("", person);
        }

        
        [Route("{id}")]  //api/people/id
        [HttpDelete]
        public IActionResult DeletePerson (int id, [FromHeader(Name ="X-AccessKey")]string AccessKey)
        {
            if(AccessKey != "123456789") return Unauthorized();
            
            var existing = context.People.Find(id);
            if (existing == null)
                return NotFound();

            context.People.Remove(existing);
            context.SaveChanges();
            
            return NoContent();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdatePerson(int id, [FromBody]Person updatedPerson)
        {
            Person person = null;
            if (id != updatedPerson.Id) 
                return BadRequest();
            
            context.People.FirstOrDefault(p => p.Id == id);
            if (person == null)
                return NotFound();

            person.FirstName = updatedPerson.FirstName;
            person.LastName = updatedPerson.LastName;
            person.BirthDate = updatedPerson.BirthDate;
            person.Gender = updatedPerson.Gender;
            context.SaveChanges();
            return Ok(person);
        }
    }
}
