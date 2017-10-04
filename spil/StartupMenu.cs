using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class StartupMenu
    {
        public void Show()
        {
            bool running = true;
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": CreateTicTacToe(); break;
                    case "2": CreateBattleShips(); break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);

            
        }

        private void CreateBattleShips()
        {
            BattleShipMenu battleShipMenu = new BattleShipMenu();
            battleShipMenu.Show();
        }

        private void CreateTicTacToe()
        {
            TicTacToeMenu ticTacToeMenu = new TicTacToeMenu();
            ticTacToeMenu.Show();
        }

        private void ShowMenu()
        {
            Console.Clear();

            {

            }
            Console.WriteLine("Velkommen til Vælg spil");
            Console.WriteLine();
            Console.WriteLine("1. Kryds og Bolle");
            Console.WriteLine("2. Sænke Slagskib");
            Console.WriteLine("0. exit");
        }

        private string GetUserChoise()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        private void ShowMenuSelectionErroe()
        {
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadLine();
        }
    }
}
