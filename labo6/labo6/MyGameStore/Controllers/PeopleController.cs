using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using MyGameStore.Model;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        //private static List<Person> list = new List<Person>();
        
        private GamestoreContext context { get; }

        public PeopleController(GamestoreContext context)
        {
            /*list.Add(new Person(list.Count + 1, "Kobe", "Vervoort", "vervoortkobe@outlook.com", "man", "Turnhout"));
            list.Add(new Person(list.Count + 1, "Thomas", "Mol", "mol.thomas@hotmail.com", "man", "Dordrecht"));
            list.Add(new Person(list.Count + 1, "Noa", "Van den berghe", "noavdb@noavdb.com", "man", "Antwerpen"));
            list.Add(new Person(list.Count + 1, "Yoshi", "Allaerts", "yoshi.allaerts@gmail.com", "man", "Zoersel"));
            list.Add(new Person(list.Count + 1, "Emma", "Laureys", "emma.laureys@icloud.com", "vrouw", "Schilde"));*/

            this.context = context;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] string? lastName)
        {
            /*if(lastName == null) return Ok(list);
            else
            {
                var resultList = new List<Person>();
                foreach (var p in list)
                {
                    if (p.LastName.ToLower() == lastName.ToLower()) resultList.Add(p);
                }
                if (resultList.Count > 0) return Ok(resultList);
                return NotFound();
            }*/

            if (lastName == null) return Ok(this.context.People.ToList());
            else
            {
                //TODO: merk op, dit kan veel beter, zie later bij LINQ!
                var resultList = new List<Person>();
                foreach (var p in this.context.People)
                {
                    if (p.LastName.ToLower() == lastName.ToLower()) resultList.Add(p);
                }
                if (resultList.Count > 0) return Ok(this.context.People.Where(p => p.LastName.ToLower() == lastName.ToLower()));
                return NotFound();
            }
        }

        /*[HttpPost]
        public IActionResult CreatePerson(string firstName, string lastName, string email, string gender, string birthPlace)
        {
            Person p = new Person(list.Max(p => p.Id), firstName, lastName, email, gender, birthPlace);
            list.Add(p);
            return Created("", é);
        }*/
        [HttpPost]
        public IActionResult Add(Person p)
        {
            context.People.Add(p);
            context.SaveChanges();
            return Created("", p);
        }

        /*[HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            foreach (var p in list)
            {
                if (p.Id == id)
                {
                    list.Remove(p);
                    return NoContent();
                }
            }
            return NotFound($"The person with Id {id} was not found");
        }*/

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromHeader(Name = "X-AccessKey")] int key)
        {
            if (key != 123456789) return Unauthorized();

            try
            {
                context.People.Remove(new Person() { Id = id });
                context.SaveChanges();
                return NoContent();
            } catch(DBConcurrencyException ex)
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Person p)
        {
            if (p == null) return BadRequest("No person object was present");
            if(p.Id != id) return BadRequest("Id in route is different from id in body");

            //var found = GetById(id);
            var found = context.People.Find(id);
            if (found == null) return NotFound();
            
            found.FirstName = p.FirstName;
            found.LastName = p.LastName;
            found.Email = p.Email;
            found.Gender = p.Gender;
            found.BirthDate = p.BirthDate;
            found.MobileNr = p.MobileNr;
            //found.BirthPlace = p.BirthPlace;
            context.SaveChanges();
            return Ok(found);
        }

        /*private Person findById(int id)
        {
            foreach (var p in list) if (p.Id == id) return p;
            return null;
        }*/

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //var p = findById(id);
            var p = context.People.Find(id);
            return p != null ? Ok(p) : NotFound();
        }
    }
}
