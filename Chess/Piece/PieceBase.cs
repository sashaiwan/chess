using Chess.Board;

namespace Chess.Piece
{
    public abstract class PieceBase : IPieceType
    {
        public Coordinate Coords;

        public PieceColor Color { get; set; }
        public PieceName Name { get; set; }

        public PieceBase((PieceColor, PieceName) pieceType, Coordinate coords)
        {
            Color = pieceType.Item1;
            Name = pieceType.Item2;
            Coords = coords;
        }
        
        public Coordinate GetCoords()
        {
            Console.WriteLine($"{Color} {Name} are in X:{Coords.x} Y:{Coords.y}");
            return Coords;
        }

        private void SetCoords(Coordinate newCoords)
        {
            Coords.x = newCoords.x;
            Coords.y = newCoords.y;
        }

        public void Move(Coordinate targetCoords)
        {
            if (IsValid(targetCoords))
            {
                SetCoords(targetCoords);
            }
            else
            {
                Console.WriteLine("Move not valid");
            }
        }

        public abstract bool IsValid(Coordinate newCoords);

        public int GetPieceType()
        {
            return (int)Color * (int)Name;
        }
    }
}

