using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBookStoreWebAPI.Models;

namespace OnlineBookStoreWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class AuthorsController : ControllerBase
    {
        private readonly OnlineBookStoreDbContext _context;

        public AuthorsController(OnlineBookStoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Authors/get
        [HttpGet]
        [ActionName("get")]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return await _context.Authors.ToListAsync();
        }

        // GET: api/Authors/get/id
        [HttpGet("{id}")]
        [ActionName("get")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
            var author = await _context.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            return author;
        }

        // PUT: api/Authors/get/id
        [HttpPut("{id}")]
        [ActionName("get")]
        public async Task<IActionResult> PutAuthor(int id, Author author)
        {
            author.ID = id;
            if (id != author.ID)
            {
                return BadRequest();
            }

            _context.Entry(author).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(id))
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

        // POST: api/Authors/add
        [HttpPost]
        [ActionName("add")]
        public async Task<ActionResult<Author>> PostAuthor(Author author)
        {
            
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();

            return CreatedAtAction("adr", new { id = author.ID }, author);
        }

        // DELETE: api/Authors/delete/id
        [HttpDelete("{id}")]
        [ActionName("delete")]
        public async Task<ActionResult<Author>> DeleteAuthor(int id)
        {
            var author = await _context.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }

            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();

            return author;
        }

        private bool AuthorExists(int id)
        {
            return _context.Authors.Any(e => e.ID == id);
        }
    }
}
