using Chess.Piece;
using Chess.Board;
using Chess.Services;

class Program
{
    static void Main(string[] args)
    {
        BoardBase board = new(4);
        PieceService pieceService = new();
        PositionController positionController = new(board, pieceService);

        var allSquares = board.GetAllSquares();
        Console.WriteLine(String.Join(", ", allSquares));
        Console.WriteLine(allSquares.Count);

        List<(int, int)> positionSet = positionController.GetPositionSet();
        Console.WriteLine(String.Join(", ", positionSet));
        Console.WriteLine(positionSet.Count);
        //Console.WriteLine(String.Join(", ", positionSet));

        Console.ReadLine();
    }
};
