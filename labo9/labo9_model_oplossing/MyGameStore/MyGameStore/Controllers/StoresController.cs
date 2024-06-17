using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using static AP.MyGameStore.DAL.Interfaces.IStoresRepository;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly IStoresService storesService;

        public StoresController(IStoresService storesService)
        {
            this.storesService = storesService;
        }

        [HttpGet]   //api/people?lastname=Janssens
        public IActionResult GetAllStores(string? nameFilter = null, SortBy? sortBy = null, int pageNumber = 1, int pageLength = 10)
        {
            try
            {
                return Ok(storesService.GetAll(nameFilter, sortBy, pageNumber, pageLength));
            }
            catch(ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetStore(int id)
        {
            var store = storesService.GetById(id);
            if (store == null)
                return NotFound();

            return Ok(store);
        }


        [HttpPost]
        public IActionResult CreateStore([FromBody] Store store)
        {
            try
            {
                return Created("", storesService.Add(store));
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("{id}")]  //api/people/id
        [HttpDelete]
        public IActionResult DeleteStore(int id, [FromHeader(Name = "X-AccessKey")] string AccessKey)
        {
            //if (AccessKey != "123456789") return Unauthorized();

            try
            {
                storesService.Delete(id);
                return NoContent();
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateStore(int id, [FromBody] Store updatedStore)
        {
            if (id != updatedStore.Id) return BadRequest();

            try
            {
                return Ok(storesService.Update(updatedStore));
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpGet]
        [Route("{storeId}/employees")]
        public IActionResult GetEmployees(int storeId)
        {
            return Ok(storesService.GetEmployees(storeId));
        }

        [HttpDelete]
        [Route("{storeId}/employees")]
        public IActionResult DeleteEmployees(int storeId)
        {
            storesService.DeleteEmployees(storeId);
            return NoContent();
        }


    }
}
