using Chess.Board;

namespace Chess.Services
{
    public class PositionService
    {
        private BoardBase _board;
        private PieceService _piecesSet;
        private List<(int, int)> _positionsSet = new List<(int, int)>();
        private List<Coordinate> _coordinatesSet = new List<Coordinate>();

        public PositionService(BoardBase board, PieceService piecesSet)
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

        private void PositionsToCoordinates()
        {
            foreach(var position in _positionsSet)
            {
                Coordinate coords;
                coords.x = position.Item1;
                coords.y = position.Item2;

                _coordinatesSet.Add(coords);
            }
        }

        public List<(int, int)> GetPositionSet()
        {
            CreateRandomPositons();
            return _positionsSet;
        }

        public List<Coordinate> GetCoordinatesSet()
        {
            PositionsToCoordinates();
            return _coordinatesSet;
        }
    }
}

