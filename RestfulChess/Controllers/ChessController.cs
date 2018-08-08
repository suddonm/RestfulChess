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
            //    //Set up white pieces
            //    //_context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2, 'A' ));
            //    //_context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2,  'B' ));
            //    /*_context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 2, Column = 'C' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 2, Column = 'D' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 2, Column = 'E' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 2, Column = 'F' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 2, Column = 'G' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 2, Column = 'H' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Rook, new Piece.PiecePosition { Row = 1, Column = 'A' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Rook, new Piece.PiecePosition { Row = 1, Column = 'H' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Knight, new Piece.PiecePosition { Row = 1, Column = 'B' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Knight, new Piece.PiecePosition { Row = 1, Column = 'G' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Bishop, new Piece.PiecePosition { Row = 1, Column = 'C' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Bishop, new Piece.PiecePosition { Row = 1, Column = 'F' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Queen, new Piece.PiecePosition { Row = 1, Column = 'D' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.King, new Piece.PiecePosition { Row = 1, Column = 'E' }));

            //    //Set up black pieces
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 7, Column = 'A' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 7, Column = 'B' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 7, Column = 'C' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 7, Column = 'D' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 7, Column = 'E' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 7, Column = 'F' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 7, Column = 'G' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, new Piece.PiecePosition { Row = 7, Column = 'H' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Rook, new Piece.PiecePosition { Row = 8, Column = 'A' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Rook, new Piece.PiecePosition { Row = 8, Column = 'H' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Knight, new Piece.PiecePosition { Row = 8, Column = 'B' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Knight, new Piece.PiecePosition { Row = 8, Column = 'G' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Bishop, new Piece.PiecePosition { Row = 8, Column = 'C' }));
            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Bishop, new Piece.PiecePosition { Row = 8, Column = 'F' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Queen, new Piece.PiecePosition { Row = 8, Column = 'D' }));

            //    _context.Pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.King, new Piece.PiecePosition { Row = 8, Column = 'E' }));*/

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
        public IActionResult Delete(Game item)
        {
            if (_context.Games.Contains(item))
            {
                _context.Games.Remove(item);
                _context.SaveChanges();

                return NoContent();
            }
            else
            {
                return NotFound();
            }            
        }
    }
}
