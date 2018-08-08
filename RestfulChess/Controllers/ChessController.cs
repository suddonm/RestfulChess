using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestfulChess.Models;

namespace RestfulChess.Controllers
{
    //[ApiVersion("v1")]
    //[Route("api/{version:apiVersion}/[controller]")]    
    [Route("api/[controller]")]
    [ApiController]
    public class ChessController : ControllerBase
    {
        private readonly ChessDBContext _context;

        public ChessController(ChessDBContext context)
        {
            _context = context;
            
            // Start a new chess game
            //if (_context.Pieces.Count() <= 0)
            //{


            //    _context.SaveChanges();
            //}
            
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Game>> Games()
        {
            return _context.Games;
        }

        [HttpPost]
        public IActionResult Create(Game item)
        {
            _context.Games.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetGames", new { id = item.Id }, item);
        }

        [HttpGet("{id}", Name = "GetGames")]
        public ActionResult<Game> GamesById(long id)
        {
            Game item = _context.Games.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Game item = _context.Games.Find(id);
            if (item == null)
            {
                return NotFound();

            }
            _context.Games.Remove(item);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
