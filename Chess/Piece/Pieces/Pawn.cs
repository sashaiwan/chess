using Chess.Board;

namespace Chess.Piece
{
    public class Pawn : PieceBase
    {
        public Pawn((PieceColor, PieceName) pieceType, Coordinate coords) : base(pieceType, coords)
        {
        }

        public override bool IsValid(Coordinate newCoords)
        {
            return Coords.x == newCoords.x && Math.Abs(newCoords.y - Coords.y) == 1;
        }
    }
}