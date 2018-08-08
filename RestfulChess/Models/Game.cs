using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulChess.Models
{
    public class Game
    {
        public long Id { get; set; }
        public string MoveList { get; set; }

        private Piece[] Pieces;

        public Game()
        {
            Pieces = new Piece[32];
        }

        private bool MovePiece(string move)
        {
            if (move.Length <= 0)
            {
                return false;
            }

            // if lower case, then pawn move
            if (char.IsLower(move[0]))
            {
                return MovePawn(move);
            }

            return true;
        }

        private bool MovePawn(string move)
        {
            foreach (Piece piece in Pieces)
            {
                //Get any active piece that is a pawn and is on the same file as the move specified
                if (piece.PieceTypeId == Piece.PieceType.Pawn &&
                    char.ToLower(piece.Column) == move[0] &&
                    piece.Active)
                {
                    //we have found the piece we were looking for, now see if the move is valid

                }
            }

            return true;
        }

        private void InitializeBoard()
        {
            //Set up white pieces
            int index = 0;
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2, 'A' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2, 'B' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2, 'C' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2, 'D' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2, 'E' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2, 'F' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2, 'G' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, 2, 'H' );

            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Rook, 1, 'A' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Rook, 1, 'H' );

            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Knight, 1, 'B' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Knight, 1, 'G' );

            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Bishop, 1, 'C' );
            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Bishop, 1, 'F' );

            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.Queen, 1, 'D' );

            Pieces[index++] = new Piece(Piece.PieceColor.White, Piece.PieceType.King, 1, 'E' );

            //Set up black pieces
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, 7, 'A' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, 7, 'B' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, 7, 'C' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, 7, 'D' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, 7, 'E' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, 7, 'F' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, 7, 'G' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, 7, 'H' );

            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Rook, 8, 'A' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Rook, 8, 'H' );

            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Knight, 8, 'B' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Knight, 8, 'G' );

            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Bishop, 8, 'C' );
            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Bishop, 8, 'F' );

            Pieces[index++] = new Piece(Piece.PieceColor.Black, Piece.PieceType.Queen, 8, 'D' );

            Pieces[index] = new Piece(Piece.PieceColor.White, Piece.PieceType.King, 8, 'E' );
        }
    }
}
