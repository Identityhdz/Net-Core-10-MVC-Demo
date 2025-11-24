using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sys_Dates.Data;
using Sys_Dates.Models.Modules;

namespace Sys_Dates.Controllers.Modules
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public DatesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dates>>> GetAll()
        {
            return await _dbContext.Dates.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dates>> GetById(int id)
        {
            var date = await _dbContext.Dates.FindAsync(id);

            if (date == null)
                return NotFound();

            return date;
        }

        [HttpPost]
        public async Task<ActionResult<Dates>> Create(Dates model)
        {
            _dbContext.Dates.Add(model);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Dates model)
        {
            if (id != model.Id)
                return BadRequest("El ID no coincide");

            var exists = await _dbContext.Dates.AnyAsync(x => x.Id == id);
            if (!exists)
                return NotFound();

            _dbContext.Entry(model).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var row = await _dbContext.Dates.FindAsync(id);

            if (row == null)
                return NotFound();

            _dbContext.Dates.Remove(row);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}
