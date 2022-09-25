using Chess.Board;

namespace Chess.Piece
{
    public class King : PieceBase
    {
        public King((PieceColor, PieceName) pieceType, Coordinate coords) : base(pieceType, coords)
        {
        }

        public override bool IsValid(Coordinate newCoords)
        {
            return Math.Abs(newCoords.x - Coords.x) <= 1 && Math.Abs(newCoords.y - Coords.y) >= 1; 
        }
    }
}

