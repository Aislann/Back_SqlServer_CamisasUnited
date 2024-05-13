﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using camisas_united.Models;

namespace camisas_united.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly CamisasUnitedContext _context;

        public CategoriasController(CamisasUnitedContext context)
        {
            _context = context;
        }

        // GET: api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategoria()
        {
          if (_context.Categoria == null)
          {
              return NotFound();
          }
            return await _context.Categoria.ToListAsync();
        }

        // GET: api/Categorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> GetCategorium(int id)
        {
          if (_context.Categoria == null)
          {
              return NotFound();
          }
            var categorium = await _context.Categoria.FindAsync(id);

            if (categorium == null)
            {
                return NotFound();
            }

            return categorium;
        }

        // PUT: api/Categorias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategorium(int id, Categoria categorium)
        {
            if (id != categorium.Id)
            {
                return BadRequest();
            }

            _context.Entry(categorium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriumExists(id))
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

        // POST: api/Categorias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Categoria>> PostCategorium(Categoria categorium)
        {
          if (_context.Categoria == null)
          {
              return Problem("Entity set 'CamisasUnitedContext.Categoria'  is null.");
          }
            _context.Categoria.Add(categorium);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategorium", new { id = categorium.Id }, categorium);
        }

        // DELETE: api/Categorias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategorium(int id)
        {
            if (_context.Categoria == null)
            {
                return NotFound();
            }
            var categorium = await _context.Categoria.FindAsync(id);
            if (categorium == null)
            {
                return NotFound();
            }

            _context.Categoria.Remove(categorium);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoriumExists(int id)
        {
            return (_context.Categoria?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
