using Chess.Board;

namespace Chess.Piece
{
    public class Queen : PieceBase
    {
        public Queen((PieceColor, PieceName) pieceType, Coordinate coords) : base(pieceType, coords)
        {
        }

        public override bool IsValid(Coordinate newCoords)
        {
            bool rookCondition = Coords.x == newCoords.x || Coords.y == newCoords.y;
            bool bishopCondition = Math.Abs(newCoords.x - Coords.x) == Math.Abs(newCoords.y - Coords.y);

            return rookCondition || bishopCondition;
        }
    }
}

