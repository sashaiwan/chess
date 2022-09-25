namespace Chess.Piece
{
    public interface IPieceType
    {
        PieceColor Color { set; get; }
        PieceName Name { set; get; }

        int GetPieceType();
    }

    public enum PieceColor
    {
        white = 1,
        black = -1,
    }

    public enum PieceName
    {
        pawn = 2,
        rook,
        knight,
        bishop,
        queen,
        king,
    }
}

