#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APiFizyo.Data;
using APiFizyo.Models;

namespace APiFizyo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly APIFizyoDBContext _context;

        public RolController(APIFizyoDBContext context)
        {
            _context = context;
        }

        //hepsini almak için
        // GET: api/Rol
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol>>> GetRoller()
        {
            return await _context.Roller.ToListAsync();
        }


        //seçili olan alma
        // GET: api/Rol/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rol>> GetRol(int id)
        {
                                            //primarykey olan seçili idyi getir, firstordefault gibi bir tane 
            var rol = await _context.Roller.FindAsync(id);

            if (rol == null)
            {
                return NotFound();
            }

            return rol;
        }

        // güncelleme
        // PUT: api/Rol/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRol(int id, Rol rol)
        {
            if (id != rol.RolID)
                //seçilen id , kullanıcının rol IDsine eşit değilse      
                //güvenlik amaçlı, bana id si 2 verip idsi 5 olanı güncelleme yaptirmasın diye
            {
                return BadRequest();
            }

            _context.Entry(rol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolExists(id))
                    //id yoksa true
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

        // ekleme
        // POST: api/Rol
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rol>> PostRol(Rol rol)
        {
            _context.Roller.Add(rol);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RolExists(rol.RolID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRol", new { id = rol.RolID }, rol);
        }

        // silme
        // DELETE: api/Rol/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRol(int id)
        {
            var rol = await _context.Roller.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }

            _context.Roller.Remove(rol);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RolExists(int id)
        {
            return _context.Roller.Any(e => e.RolID == id);
        }
    }
}
