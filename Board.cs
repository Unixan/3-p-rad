namespace _3_på_rad
{
    internal class Board
    {
        public Square[] Squares { get; }

        public Board()
        {
            Squares = new Square[9];
            for (var i = 0; i < Squares.Length; i++)
            {
                Squares[i] = new Square();
            }
        }

        public void Mark(string coords)
        {
            var index = IndexInGameBoard(coords);
            
            Squares[index].Mark(true);
        }

        private static int IndexInGameBoard(string coords)
        {
            if (coords.Length != 2) return -1;
            var columnChar = coords[0];
            var rowChar = coords[1];
            var columnIndex = columnChar - 'a';
            var rowIndex = rowChar - '1';
            var index = rowIndex * 3 + columnIndex;
            return index;
        }

        public void OpponentChoice()
        {
            var availableIndexes = AvailableIndexes();
            var randomIndex = new Random().Next(availableIndexes.Count);
            var randomAvailableIndex = availableIndexes[randomIndex];
            Squares[randomAvailableIndex].Mark(false);
        }

        private List<int> AvailableIndexes()
        {
            var availableIndexes = new List<int>();
            for (var i = 0; i < Squares.Length; i++)
            {
                var square = Squares[i];
                if (square.IsEmpty())
                {
                    availableIndexes.Add(i);
                }
            }

            return availableIndexes;
        }

        public bool IsFull()
        {
            foreach (var square in Squares)
            {
                if (square.IsEmpty())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
