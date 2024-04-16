using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiPerson.DBContext;
using WebApiPerson.Models;

namespace WebApiPerson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly AppDBContext _context;

        public PersonController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonModel>>> GetPerson()
        {
            return await _context.Person.ToListAsync();
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonModel>> GetPersonModel(int id)
        {
            var personModel = await _context.Person.FindAsync(id);

            if (personModel == null)
            {
                return NotFound();
            }

            return personModel;
        }

        // PUT: api/Person/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonModel(int id, PersonModel personModel)
        {
            if (id != personModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(personModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Person
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonModel>> PostPersonModel(PersonModel personModel)
        {
            _context.Person.Add(personModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonModel", new { id = personModel.Id }, personModel);
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonModel(int id)
        {
            var personModel = await _context.Person.FindAsync(id);
            if (personModel == null)
            {
                return NotFound();
            }

            _context.Person.Remove(personModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonModelExists(int id)
        {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
