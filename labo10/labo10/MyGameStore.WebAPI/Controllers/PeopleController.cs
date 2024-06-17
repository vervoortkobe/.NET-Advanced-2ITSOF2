using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MyGameStore.Controllers
{
    public class PeopleController : APIv1Controller
    {
        private readonly IPeopleService peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            this.peopleService = peopleService;
        }

        [HttpGet]   //api/people?lastname=Janssens
        public IActionResult GetAllPeople([FromQuery] string lastName, [FromQuery] int pageNr = 1, [FromQuery]int pageSize = 10)
        {
            return Ok(peopleService.GetAll(pageNr, pageSize));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPerson(int id)
        {

            var person = peopleService.GetById(id);
            if (person == null)
                return NotFound(); 

            return Ok(person);
        }

        [HttpPost]
        public IActionResult CreatePerson([FromBody]Person person)
        {
            try
            {
                return Created("", peopleService.Add(person));
            }
            catch (RelationNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        [Route("{id}")]  //api/people/id
        [HttpDelete]
        public IActionResult DeletePerson (int id, [FromHeader(Name ="X-AccessKey")]string AccessKey)
        {
            if(AccessKey != "123456789") return Unauthorized();

            try
            {
                peopleService.Delete(id);
                return NoContent();
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdatePerson(int id, [FromBody]Person updatedPerson)
        {
            if (id != updatedPerson.Id) return BadRequest();

            try
            {
                return Ok(peopleService.Update(updatedPerson));
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch(RelationNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
