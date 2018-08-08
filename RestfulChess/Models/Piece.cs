using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace RestfulChess.Models
{
    public class Piece
    {
        public enum PieceType
        {
            Pawn = 0,
            Knight,
            Bishop,
            Rook,
            Queen,
            King
        }

        public enum PieceColor
        {
            White = 0,
            Black
        }

        public long Id { get; set; }
        public PieceColor Color { get; }
        public PieceType PieceTypeId { get; }
        public Char Column { get; set; }
        public int Row { get; set; }
        public bool Active { get; set; }

        public Piece() { }

        public Piece(PieceColor pieceColor, 
                     PieceType pieceType, 
                     int row,
                     Char column)
        {
            Color = pieceColor;
            PieceTypeId = pieceType;
            Row = row;
            Column = column;
            Active = true;
        }
    }
}
