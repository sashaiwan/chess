using Chess.Piece;

namespace Chess.Board
{
    public class BoardBase
    {
        public int boardSize;
        public int[,] Board { get; set; }

        public BoardBase(int size)
        {
            boardSize = size;
            Board = new int[size, size];
        }

        public void GetSize()
        {
            Console.WriteLine($"Board is {boardSize} x {boardSize}");
        }

        public void SetSquareContent(Coordinate coord, int piece)
        {
            this.Board[coord.x, coord.y] = piece;
        }

        public int GetSquareContent(Coordinate coord)
        {
            if (coord.x > Board.GetLength(0) || coord.y > Board.GetLength(1))
            {
                Console.WriteLine("Invalid Coordinates");
                return 0;
            }
            var result = Board[coord.x, coord.y];
            Console.WriteLine(result);
            return result;
        }

        public List<(int, int)> GetAllSquares()
        {
            List<(int, int)> squaresSet = new List<(int, int)>();

            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    squaresSet.Add((i, j));
                }
            }

            return squaresSet;
        }
    }
}

