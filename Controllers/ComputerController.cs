using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Data;
using api.Models;

namespace api.Controllers
{
    [ApiController]
    [Route("v1/computers")]

    public class ComputerController : ControllerBase
    {
        private readonly DataContext _context;
        public ComputerController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Computer>>> Get()
        {
            var computers = await _context.Computers.ToListAsync();
            return computers;
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Computer>> Post(
            [FromBody] Computer model)
        {
            if(ModelState.IsValid)
            {
                _context.Computers.Add(model);
                await _context.SaveChangesAsync();
                return model;
            }
            else{
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Computer>> Put(int id, [FromBody] Computer computer)
        {
            if (computer.Id != id){
                return BadRequest();
            }
            _context.Entry(computer).State =  EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var computer = await _context.Computers.FindAsync(id);
            if (computer == null)
            {
                return NotFound();
            }
            _context.Computers.Remove(computer);
            await _context.SaveChangesAsync();
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}