using Chess.Board;

namespace Chess.Services
{
    public class PositionController
    {
        private BoardBase _board;
        private PieceService _piecesSet;
        private List<(int, int)> _positionsSet = new List<(int, int)>();

        public PositionController(BoardBase board, PieceService piecesSet)
        {
            _board = board;
            _piecesSet = piecesSet;
        }

        private void CreateRandomPositons()
        {
            _positionsSet = _board.GetAllSquares();
            Random rnd = new Random();

            for (int i = 0; i < (_positionsSet.Count - 1); i++)
            {
                var key = i + rnd.Next(_positionsSet.Count - i);
                var t = _positionsSet[key];
                _positionsSet[key] = _positionsSet[i];
                _positionsSet[i] = t;
            }
        }

        public List<(int, int)> GetPositionSet()
        {
            CreateRandomPositons();
            return _positionsSet;
        }
    }
}

