using Chess.Board;

namespace Chess.Piece
{
    public class Bishop : PieceBase
    {
        public Bishop((PieceColor, PieceName) pieceType, Coordinate coords) : base(pieceType, coords)
        {
        }

        public override bool IsValid(Coordinate newCoords)
        {
            return Math.Abs(newCoords.x - Coords.x) == Math.Abs(newCoords.y - Coords.y);
        }
    }
}

