using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGameStore.DAL;
using MyGameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly MyGameStoreContext context;

        public StoreController(MyGameStoreContext context)
        {
            this.context = context;
        }

        [HttpGet]   //api/people?lastname=Janssens
        public IActionResult GetAllStores()
        {
            return Ok(context.Stores);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetStore(int id)
        {
            var store = context.Stores.FirstOrDefault(p => p.Id == id);
            if (store != null)
                return Ok(store);

            return NotFound();
        }


        [HttpPost]
        public IActionResult CreateStore([FromBody] Store store)
        {
            context.Stores.Add(store);
            context.SaveChanges();
            return Created("", store);
        }


        [Route("{id}")]  //api/people/id
        [HttpDelete]
        public IActionResult DeleteStore(int id, [FromHeader(Name = "X-AccessKey")] string AccessKey)
        {
            try
            {
                context.Stores.Remove(new Store() { Id = id });
                context.SaveChanges();
                return NoContent();
            }
            catch(DbUpdateConcurrencyException e)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateStore(int id, [FromBody] Store updatedStore)
        {
            if (id != updatedStore.Id) 
                return BadRequest();
            try
            {
                context.Stores.Update(updatedStore);
                context.SaveChanges();
                return Ok(updatedStore);
            }
            catch(DbUpdateConcurrencyException e)
            {
                return NotFound();
            }
        }
    }
}
