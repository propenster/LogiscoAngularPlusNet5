using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogicoStartupEngine.Data;
using LogicoStartupEngine.Models;

namespace LogicoStartupEngine.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LogisticCompaniesController : ControllerBase
    {
        private readonly ApplicationDataContext _context;

        public LogisticCompaniesController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: api/LogisticCompanies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LogisticCompany>>> GetLogisticCompanies()
        {
            return await _context.LogisticCompanies.ToListAsync();
        }

        // GET: api/LogisticCompanies/5
        [HttpGet("{Id}")]
        public async Task<ActionResult<LogisticCompany>> GetLogisticCompany(int Id)
        {
            var logisticCompany = await _context.LogisticCompanies.FindAsync(Id);

            if (logisticCompany == null)
            {
                return NotFound();
            }

            return logisticCompany;
        }

        // PUT: api/LogisticCompanies/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutLogisticCompany(int Id, LogisticCompany logisticCompany)
        {
            if (Id != logisticCompany.Id)
            {
                return BadRequest();
            }

            _context.Entry(logisticCompany).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogisticCompanyExists(Id))
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

        // POST: api/LogisticCompanies
        [HttpPost]
        public async Task<ActionResult<LogisticCompany>> PostLogisticCompany(LogisticCompany logisticCompany)
        {
            _context.LogisticCompanies.Add(logisticCompany);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLogisticCompany", new { Id = logisticCompany.Id }, logisticCompany);
        }

        // DELETE: api/LogisticCompanies/5
        [HttpDelete("{Id}")]
        public async Task<ActionResult<LogisticCompany>> DeleteLogisticCompany(int Id)
        {
            var logisticCompany = await _context.LogisticCompanies.FindAsync(Id);
            if (logisticCompany == null)
            {
                return NotFound();
            }

            _context.LogisticCompanies.Remove(logisticCompany);
            await _context.SaveChangesAsync();

            return logisticCompany;
        }

        private bool LogisticCompanyExists(int Id)
        {
            return _context.LogisticCompanies.Any(e => e.Id == Id);
        }
    }
}
