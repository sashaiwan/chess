using Chess.Board;

namespace Chess.Piece
{
    public abstract class Piece
    {
        public Piece(string name, Coordinate coords)
        {
            Name = name;
            Coords.x = coords.x;
            Coords.y = coords.y;
        }

        public string Name;
        public Coordinate Coords;

        public void GetCoords()
        {
            Console.WriteLine($"{Name} are in X:{Coords.x} Y:{Coords.y}");
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
 
        //otra pieza en el camino
        //pieza del mismo color en casilla de llegada
        //no es un movimiento posible
    }
}

