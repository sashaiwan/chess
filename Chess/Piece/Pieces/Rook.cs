using Chess.Board;

namespace Chess.Piece
{
    public class Rook : PieceBase
    {
        public Rook((PieceColor, PieceName) pieceType, Coordinate coords) : base(pieceType, coords)
        {
        }

        public override bool IsValid(Coordinate newCoords)
        {
            return Coords.x == newCoords.x || Coords.y == newCoords.y;
        }
    }
}

