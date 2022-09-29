﻿using Chess.Piece;
using Chess.Board;
using Chess.Services;

class Program
{
    static void Main(string[] args)
    {
        BoardBase board = new(4);
        PieceService pieceService = new();
        PositionService positionService = new(board, pieceService);

        var allSquares = board.GetAllSquares();
        Console.WriteLine(String.Join(", ", allSquares));
        Console.WriteLine(allSquares.Count);

        List<(int, int)> positionSet = positionService.GetPositionSet();
        Console.WriteLine(String.Join(", ", positionSet));
        Console.WriteLine(positionSet.Count);

        pieceService.AddPiecesToSet();
        var piecesSet = pieceService.GetPiecesList();
        Console.WriteLine(String.Join(", ", piecesSet));
        Console.WriteLine(piecesSet.Count);

        List<Coordinate> coords = positionService.GetCoordinatesSet();
        foreach (Coordinate coord in coords)
        {
            Console.WriteLine($"x: {coord.x} y: {coord.y}");
        }

        Pawn pawn = new(pieceService.Pieces[0], coords[0]);
        pawn.GetCoords();

        Console.ReadLine();
    }
};
