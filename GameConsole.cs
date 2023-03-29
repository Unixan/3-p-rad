namespace _3_på_rad
{
    internal class GameConsole
    {
        private readonly Board _board;
        public GameConsole(Board board)
        {
            _board = board;
        }
        public void Show()
        {
            Console.Clear();
            Console.WriteLine(@$"  a b c
  ┌─┬─┬─┐
 1│{GetChar(0)}│{GetChar(1)}│{GetChar(2)}│
  ├─┼─┼─┤
 2│{GetChar(3)}│{GetChar(4)}│{GetChar(5)}│
  ├─┼─┼─┤
 3│{GetChar(6)}│{GetChar(7)}│{GetChar(8)}│
  └─┴─┴─┘");
        }
        public string GetChar(int index)
        {
            var square = _board.Squares[index];
            return square.IsEmpty() ? " " : square.Player() ? "X" : "O";
        }
    }
}
