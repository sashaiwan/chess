using Chess.Board;

namespace Chess.Piece
{
    public class Knight : PieceBase
    {
        public Knight((PieceColor, PieceName) pieceType, Coordinate coords) : base(pieceType, coords)
        {
        }

        public override bool IsValid(Coordinate newCoords)
        {
            bool left1 = Math.Abs(newCoords.x - Coords.x) == 1;
            bool left2 = Math.Abs(newCoords.y - Coords.y) == 2;
            bool right1 = Math.Abs(newCoords.x - Coords.x) == 2;
            bool right2 = Math.Abs(newCoords.y - Coords.y) == 1;

            return (left1 && left2) || (right1 && right2);
        }
    }
}

