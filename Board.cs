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

      
    }
}
