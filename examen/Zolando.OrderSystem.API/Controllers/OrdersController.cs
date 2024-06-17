using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using Zolando.OrderSystem.BLL.Interfaces;
using Zolando.OrderSystem.DAL;
using Zolando.OrderSystem.DAL.Contexts;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        [HttpGet]   
        public IActionResult GetAll()
        {
            try
            {
                return Ok(ordersService.GetAll());
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
             var order = ordersService.Get(id);
            if (order == null)
                return NotFound();

            return Ok(order);
        }


        [HttpPost]
        public IActionResult Create([FromBody] Order order)
        {
            try
            {
                return Created("", ordersService.Create(order));
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("{id}")]  
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                ordersService.Delete(id);
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
        public IActionResult Update(int id, [FromBody] Order updatedItem)
        {
            if (id != updatedItem.Id) return BadRequest();

            try
            {
                return Ok(ordersService.Update(updatedItem));
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
    }
}
