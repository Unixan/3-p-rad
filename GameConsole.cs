namespace _3_på_rad
{
    internal class GameConsole
    {
        private Board _board;
        public GameConsole(Board board)
        {
            _board = board;
        }
        public void Show()
        {
            Console.WriteLine(@$"  a b c
  ┌─┬─┬─┐
 1│{GetOccupiedBy(0)}│{GetOccupiedBy(1)}│{GetOccupiedBy(2)}│
  ├─┼─┼─┤
 2│{GetOccupiedBy(3)}│{GetOccupiedBy(4)}│{GetOccupiedBy(5)}│
  ├─┼─┼─┤
 3│{GetOccupiedBy(6)}│{GetOccupiedBy(7)}│{GetOccupiedBy(8)}│
  └─┴─┴─┘");
        }
        public string GetOccupiedBy(int index)
        {
            var square = _board.Squares[index];
            return square.Unchecked() ? " " : square.Player() ? "X" : "O";
        }
    }
}
