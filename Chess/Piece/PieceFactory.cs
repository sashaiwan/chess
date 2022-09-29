using System;
using Chess.Board;

namespace Chess.Piece
{
    public class PieceFactory
    {
        private List<(PieceColor, PieceName)> _piecesSet;
        private List<Coordinate> _coordinatesSet;
        private List<PieceBase> _pieces = new List<PieceBase>();

        public PieceFactory(List<(PieceColor, PieceName)> pieces, List<Coordinate> coordinates)
        {
            _piecesSet = pieces;
            _coordinatesSet = coordinates;
        }

        public List<PieceBase> GetPieces()
        {
            GetPiecesAndCoordsList();
            return _pieces;
        }

        private void GetPiecesAndCoordsList()
        {
            for (int i = 0; i == _coordinatesSet.Count - 1; i++)
            {
                switch (((int)_piecesSet.ElementAt(i).Item2))
                {
                    case 2:
                        _pieces.Add(new Pawn(_piecesSet.ElementAt(i), _coordinatesSet.ElementAt(i)));
                        break;
                    case 3:
                        _pieces.Add(new Rook(_piecesSet.ElementAt(i), _coordinatesSet.ElementAt(i)));
                        break;
                    case 4:
                        _pieces.Add(new Knight(_piecesSet.ElementAt(i), _coordinatesSet.ElementAt(i)));
                        break;
                    case 5:
                        _pieces.Add(new Bishop(_piecesSet.ElementAt(i), _coordinatesSet.ElementAt(i)));
                        break;
                    case 6:
                        _pieces.Add(new Queen(_piecesSet.ElementAt(i), _coordinatesSet.ElementAt(i)));
                        break;
                    case 7:
                        _pieces.Add(new King(_piecesSet.ElementAt(i), _coordinatesSet.ElementAt(i)));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

