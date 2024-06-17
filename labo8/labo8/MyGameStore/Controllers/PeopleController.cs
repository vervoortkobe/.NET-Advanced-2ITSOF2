using Bogus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AP.MyGameStore.API.Controllers
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

        [HttpGet]   //api/people?lastnamefilter=Janssens&EmailFilter="@ap.be"
        public IActionResult GetAllPeople([FromQuery] string LastNameFilter = null, Gender? GenderFilter = null, string EmailFilter = null, Sort? sortBy = null)
        {
            var list = service.GetAll();
            return Ok(list);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPerson(int id)
        {
            try
            {
                return Ok(service.GetById(id));

            }
            catch (Exception)
            {

                throw;
            }
            var person = context.People.Include(p => p.Employer).FirstOrDefault(p => p.Id == id);
            if (person != null)
                return Ok(person);

            return NotFound();
        }


        [HttpPost]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            var p = service.Add(person);
            return Created("", p);
        }


        [Route("{id}")]  //api/people/id
        [HttpDelete]
        public IActionResult DeletePerson(int id, [FromHeader(Name = "X-AccessKey")] string AccessKey)
        {
            if (AccessKey != "123456789") return Unauthorized();

            var existing = context.People.Find(id);
            if (existing == null)
                return NotFound();

            context.People.Remove(existing);
            context.SaveChanges();

            return NoContent();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdatePerson(int id, [FromBody] Person updatedPerson)
        {
            Person person = null;
            if (id != updatedPerson.Id) return BadRequest();

        }
    }
}
