using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiRest.Controllers
{
    [Produces("application/json")]
    [Route("api/Ticket")]
    public class TicketController : Controller
    {
        private TicketContext _context;

        public TicketController(TicketContext context)
        {
            _context = context;
            if (_context.TicketItems.Count() == 0)
            {
                _context.TicketItems.Add(new TicketItem { Concert = "Tiffany" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<TicketItem> GetAll()
        {
            return _context.TicketItems.AsNoTracking().ToList();
        }


        [HttpGet("{id}", Name ="GetTicket")]
        public IActionResult GetById(long id)
        {
            var ticket = _context.TicketItems.FirstOrDefault(t => t.Id == id);
            if (ticket == null)
            {
                return NotFound(); //400
            }

            return new ObjectResult(ticket); //200
        }
        [HttpPost]
        public IActionResult Create([FromBody]TicketItem ticket)
        {
            if (ticket == null)
            {
                return BadRequest(); //400
            }
            _context.TicketItems.Add(ticket);
            _context.SaveChanges();
            return CreatedAtRoute("GetTicket", new { id = ticket.Id }, ticket);
        }
        [HttpPut("{id}")]
        public IActionResult update(long id, [FromBody] TicketItem ticket)
        {
            if (ticket == null || ticket.Id != id)
            {
                return BadRequest();
            }
            var tic = _context.TicketItems.FirstOrDefault(t => t.Id == id);
            if (tic  == null)
            {
                return NotFound();
            }
            tic.Concert = ticket.Concert;
            tic.Artist = ticket.Artist;
            tic.Available = ticket.Available;
            _context.TicketItems.Update(tic);
            _context.SaveChanges();
            return new NoContentResult();
        }
        [HttpDelete("{id}")]
        public IActionResult delete(long id)
        {
            var tic = _context.TicketItems.FirstOrDefault(t => t.Id == id);
            if (tic == null)
            {
                return NotFound();
            }
            _context.TicketItems.Remove(tic);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}