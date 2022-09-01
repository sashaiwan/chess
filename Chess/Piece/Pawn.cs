using System;
namespace Chess.Piece
{
    public class Pawn : Piece
    {
        public Pawn(string name, int[] coords) : base(name, coords)
        {
        }

        public override bool IsValid(int[] newCoords)
        {
            if (Coords[1] + 1 == newCoords[1] && Coords[0] == newCoords[0])
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