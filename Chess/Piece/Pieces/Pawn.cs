using System;
using Chess.Board;

namespace Chess.Piece
{
    public class Pawn : Piece
    {
        public Pawn(string name, Coordinate coords) : base(name, coords)
        {
        }

        public override bool IsValid(Coordinate newCoords)
        {
            if (Coords.x == newCoords.x && newCoords.y - Coords.y == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}