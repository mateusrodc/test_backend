using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Data;
using api.Models;

namespace api.Controllers
{
    [ApiController]
    [Route("v1/customers")]

    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;
        public CustomerController(DataContext context)
        {
            this._context = context;
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Customer>>> Get()
        {
            var customers = await _context.Customers.ToListAsync();
            return customers;
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Customer>> Post(
            [FromBody] Customer model)
        {
            if(ModelState.IsValid)
            {
                _context.Customers.Add(model);
                await _context.SaveChangesAsync();
                return model;
            }
            else{
                return BadRequest(ModelState);
            }
        }
        

    }
}