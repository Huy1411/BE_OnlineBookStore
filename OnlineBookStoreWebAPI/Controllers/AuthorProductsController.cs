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
    public class AuthorProductsController : ControllerBase
    {
        private readonly OnlineBookStoreDbContext _context;

        public AuthorProductsController(OnlineBookStoreDbContext context)
        {
            _context = context;
        }

        // GET: api/AuthorProducts
        [HttpGet]
        [ActionName("get")]
        public async Task<ActionResult<IEnumerable<AuthorProducts>>> GetAuthorProducts()
        {
            return await _context.AuthorProducts.ToListAsync();
        }

        // GET: api/AuthorProducts/5
        [HttpGet("{id}")]
        [ActionName("get")]
        public async Task<ActionResult<AuthorProducts>> GetAuthorProducts(int id)
        {
            var authorProducts = await _context.AuthorProducts.FindAsync(id);

            if (authorProducts == null)
            {
                return NotFound();
            }

            return authorProducts;
        }

        // PUT: api/AuthorProducts/5
        [HttpPut("{id}")]
        [ActionName("get")]
        public async Task<IActionResult> PutAuthorProducts(int id, AuthorProducts authorProducts)
        {
            authorProducts.ID = id;
            if (id != authorProducts.ID)
            {
                return BadRequest();
            }

            _context.Entry(authorProducts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorProductsExists(id))
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

        // POST: api/AuthorProducts
        [HttpPost]
        [ActionName("add")]
        public async Task<ActionResult<AuthorProducts>> PostAuthorProducts(AuthorProducts authorProducts)
        {
            _context.AuthorProducts.Add(authorProducts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthorProducts", new { id = authorProducts.ID }, authorProducts);
        }

        // DELETE: api/AuthorProducts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AuthorProducts>> DeleteAuthorProducts(int id)
        {
            var authorProducts = await _context.AuthorProducts.FindAsync(id);
            if (authorProducts == null)
            {
                return NotFound();
            }

            _context.AuthorProducts.Remove(authorProducts);
            await _context.SaveChangesAsync();

            return authorProducts;
        }

        private bool AuthorProductsExists(int id)
        {
            return _context.AuthorProducts.Any(e => e.ID == id);
        }
    }
}
