using Chess.Piece;

namespace Chess.Services
{
    public class PieceService
    {
        public List<(PieceColor, PieceName)> Pieces { get; set; }

        public PieceService()
        {
        }

        public void AddPiecesToSet()
        {
            Pieces = new List<(PieceColor, PieceName)>();

            for (int i = 0; i < 8; i++)
            {
                Pieces.Add((PieceColor.white, PieceName.pawn));
                Pieces.Add((PieceColor.black, PieceName.pawn));

                if (i == 7)
                {

                    Pieces.Add((PieceColor.white, PieceName.rook));
                    Pieces.Add((PieceColor.white, PieceName.rook));
                    Pieces.Add((PieceColor.black, PieceName.rook));
                    Pieces.Add((PieceColor.black, PieceName.rook));

                    Pieces.Add((PieceColor.white, PieceName.knight));
                    Pieces.Add((PieceColor.white, PieceName.knight));
                    Pieces.Add((PieceColor.black, PieceName.knight));
                    Pieces.Add((PieceColor.black, PieceName.knight));

                    Pieces.Add((PieceColor.white, PieceName.bishop));
                    Pieces.Add((PieceColor.white, PieceName.bishop));
                    Pieces.Add((PieceColor.black, PieceName.bishop));
                    Pieces.Add((PieceColor.black, PieceName.bishop));

                    Pieces.Add((PieceColor.white, PieceName.queen));
                    Pieces.Add((PieceColor.black, PieceName.queen));
                    Pieces.Add((PieceColor.white, PieceName.king));
                    Pieces.Add((PieceColor.black, PieceName.king));
                }
            }
        }

        public List<(PieceColor, PieceName)> GetPiecesList()
        {
            return Pieces;
        }
    }
}

