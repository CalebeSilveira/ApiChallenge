using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiChallenge.Data;

namespace ApiChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CartaoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Cartao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cartao>>> GetCartao()
        {
            return await _context.Cartao.ToListAsync();
        }

        // GET: api/Cartao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cartao>> GetCartao(int id)
        {
            var cartao = await _context.Cartao.FindAsync(id);

            if (cartao == null)
            {
                return NotFound();
            }

            return cartao;
        }

        // PUT: api/Cartao/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCartao(int id, Cartao cartao)
        {
            if (id != cartao.Id)
            {
                return BadRequest();
            }

            _context.Entry(cartao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartaoExists(id))
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

        // POST: api/Cartao
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cartao>> PostCartao(Cartao cartao)
        {
            _context.Cartao.Add(cartao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCartao", new { id = cartao.Id }, cartao);
        }

        // DELETE: api/Cartao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartao(int id)
        {
            var cartao = await _context.Cartao.FindAsync(id);
            if (cartao == null)
            {
                return NotFound();
            }

            _context.Cartao.Remove(cartao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CartaoExists(int id)
        {
            return _context.Cartao.Any(e => e.Id == id);
        }
    }
}
