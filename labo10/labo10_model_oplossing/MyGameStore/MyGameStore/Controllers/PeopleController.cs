using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using static AP.MyGameStore.DAL.Interfaces.IPeopleRepository;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            this.peopleService = peopleService;
        }


        [HttpGet]
        public IActionResult GetAll(string LastNameFilter = null, Gender? GenderFilter = null, string EmailFilter = null, Sort? sortBy = null)
        {
            return Ok(peopleService.GetAll(LastNameFilter, GenderFilter, EmailFilter, sortBy));
        }


        [HttpPost]
        public IActionResult Add([FromBody] Person person)
        {
            try
            {
                peopleService.Add(person);
                return Created("", person);
            }
            catch (RelationNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove(int id, [FromHeader(Name = "X-AccessKey")] int key)
        {
            //if (key != 123456789)
            //    return Unauthorized();

            try
            {
                peopleService.Delete(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] Person updatedPerson)
        {
            if (id != updatedPerson.Id)
                return BadRequest();

            try
            {
                var person = peopleService.Update(updatedPerson);
                return Ok(person);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (RelationNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var p = peopleService.GetById(id);
            return p != null ? Ok(p) : NotFound();
        }





    }
}
