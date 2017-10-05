using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BattleShipMenu
    { 
 

           
            Battleship battleship{ get; set; }

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
                        case "1": CreateNewGame(); break;
                        case "2": PlaceShip(); break;
                        case "0": running = false; break;
                        default: ShowMenuSelectionErroe(); break;
                    }
                } while (running);
            }

        private void PlaceShip()
        {
            battleship.PlaceShips();
        }

        private void CreateNewGame()
        {
            battleship = new Battleship();
            
        }

        private void ShowMenu()
            {
                Console.Clear();
                if (battleship != null)
                {
                Console.WriteLine(battleship.GetGridBoardView());
            }
            
                Console.WriteLine("tic tac toe");
                Console.WriteLine();
                Console.WriteLine("1. Opret nyt spil");
                Console.WriteLine("2. Set en brik");
                Console.WriteLine("3. Flyt en brik");
                Console.WriteLine("4. Spil Variation");
                Console.WriteLine();
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

    
            

