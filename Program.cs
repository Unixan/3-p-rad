namespace _3_på_rad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameBoard = new Board();
            var gameConsole = new GameConsole(gameBoard);
            var gameOver = false;
            char[] Hor = new[] { 'a', 'b','c' };
            char[] Ver = new[] {'1', '2', '3' };
            while (!gameOver)
            {
                Console.WriteLine(
                    "Velg en rute ved å skrive inn koordinater (f.eks: a1) og trykk enter for å sette en X\n");
                gameConsole.Show();
                Console.Write("\nValg: ");
                var coords = Console.ReadLine();
                
            }
        }
    }
}