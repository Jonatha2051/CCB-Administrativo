using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CCB_Administrativo.Data;
using CCB_Administrativo.Models;
using CCB_Administrativo.Helpers;

namespace CCB_Administrativo.Controllers
{
    [Route(API.ObreirosApi)]
    [ApiController]
    public class ObreirosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ObreirosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Obreiro>>> GetObreiros()
        {
            return await _context.Obreiros.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Obreiro>> GetObreiro(int id)
        {
            var obreiro = await _context.Obreiros.FindAsync(id);

            if (obreiro == null)
            {
                return NotFound();
            }

            return obreiro;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutObreiro(int id, Obreiro obreiro)
        {
            if (id != obreiro.ID)
            {
                return BadRequest();
            }

            _context.Entry(obreiro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObreiroExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Obreiro>> PostObreiro(Obreiro obreiro)
        {
            _context.Obreiros.Add(obreiro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObreiro", new { id = obreiro.ID }, obreiro);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Obreiro>> DeleteObreiro(int id)
        {
            var obreiro = await _context.Obreiros.FindAsync(id);
            if (obreiro == null)
            {
                return NotFound();
            }

            _context.Obreiros.Remove(obreiro);
            await _context.SaveChangesAsync();

            return obreiro;
        }

        private bool ObreiroExists(int id)
        {
            return _context.Obreiros.Any(e => e.ID == id);
        }
    }
}
