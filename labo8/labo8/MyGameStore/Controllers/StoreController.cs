using AP.MyGameStore.API.DAL;
using AP.MyGameStore.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP.MyGameStore.API.Controllers
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameFilter"></param>
        /// <param name="filter"></param>
        /// <param name="pageNumber">First page = 1</param>
        /// <param name="pageLength"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<PagedResult<Store>> GetAll(string nameFilter = null, SortStore? sort = null, int pageNumber = 1, int pageLength = 10)
        {
            //check pre-conditions
            if (pageLength > 20)
                return BadRequest("PageLength is limited to 20 items");
            if (pageNumber < 1)
                return BadRequest("PageNumber cannot be negative");

            var result = new PagedResult<Store>();
            result.PageNumber = pageNumber;
            result.PageSize = pageLength;

            //Starting to build query taking into account the parameters given
            //As long as we work with IQueryable the actual query is not performed yet (deferred execution)
            IQueryable<Store> query = context.Stores;

            //Also fill in the total number of items already.
            result.TotalRecordCount = query.Count();

            //filtering first
            if (nameFilter != null)
                query = query.Where(s => s.Name.Contains(nameFilter));

            //fill in the filtered count (paging will not change that)
            result.FilteredRecordCount = query.Count();
            //now we can calculate the total number of pages (for the filtered set of results)
            result.TotalNumberOfPages = (int)Math.Ceiling((double)result.FilteredRecordCount / result.PageSize);

            if (pageNumber > 1 && pageNumber > result.TotalNumberOfPages)
                return BadRequest("The request page does not exist");

            //Then sorting (if required)
            switch (sort)
            {
                case SortStore.ByNameAscending:
                    query = query.OrderBy(s => s.Name);
                    break;
                case SortStore.ByNameDescending:
                    query = query.OrderByDescending(s => s.Name);
                    break;
                default:
                    break;
            }
            //paging must be the last step !
            query = query.Skip((pageNumber - 1) * pageLength).Take(pageLength);

            //here the actual query for filtered stores with paging is performed on the DB !
            result.Data = query.ToList();

            return result;
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
            catch (DbUpdateConcurrencyException e)
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
            catch (DbUpdateConcurrencyException e)
            {
                return NotFound();
            }
        }

        public enum SortStore
        {
            ByNameAscending,
            ByNameDescending
        }
    }
}
