using System.Security.AccessControl;

namespace _3_på_rad
{
    internal class Program
    {
        static void Main()
        {
            var gameBoard = new Board();
            var gameConsole = new GameConsole(gameBoard);
            while (!gameBoard.IsFull())
            {
                Console.WriteLine(
                    "Velg en rute ved å skrive inn koordinater (f.eks: a1) og trykk enter for å sette en X\n");
                gameConsole.Show();
                Console.Write("\nValg: ");
                var coords = MakeChoice();
                gameBoard.Mark(coords);
                gameConsole.Show();
                Thread.Sleep(2000);
                if (!gameBoard.IsFull()) gameBoard.OpponentChoice();
            }
        }

        private static string MakeChoice()
        {
            bool isValid = false;
            string validChoice = null;
            while (!isValid)
            {
                var userChoice = Console.ReadLine().ToLower();
                var choice = userChoice.Split("");
                if (choice.Length != 2)
                {
                    Common.Errormsg("Ugyldig valg");
                }
                if (choice[0] != 'a' || choice[0] != 'b' || choice[0] != 'c')
                {
                    Common.Errormsg("Ugyldig valg");
                }
                if (choice[1] != '1' || choice[0] != '2' || choice[0] != '3')
                {
                    Common.Errormsg("Ugyldig valg");
                }
                else
                {
                    validChoice = choice;
                    isValid = true;
                }


            }

            return validChoice;
        }
    }
}