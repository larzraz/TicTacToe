using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BattleShipMenu
    {
        private bool placeOrGuess = false;

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
                        case "3": GuessShip();placeOrGuess = true;break; 
                        case "0": running = false; break;
                        default: ShowMenuSelectionErroe(); break;
                    }
                } while (running);
            }

        private void GuessShip()
        {
            battleship.GuessShip();
            battleship.placementOrGuessing = true;
        }

        private void PlaceShip()
        {
            if (battleship.shipCounter <= 4)
            {
                battleship.PlaceShips();
                battleship.placementOrGuessing = false;
            }
            else
                
                Console.WriteLine("Du har placeret alle dine skibe");
            Console.ReadKey();
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
                if (placeOrGuess == false)
                {
                    Console.WriteLine(battleship.GetGridBoardView());
                   
                    Console.WriteLine(battleship.currentplayer);
                }
                if (placeOrGuess == true)
                {
                    Console.WriteLine(battleship.GetShootingGameBoardView());
                  
                    Console.WriteLine(battleship.currentplayer);
                }

            }
            
                Console.WriteLine("Battleships");
                Console.WriteLine();
                Console.WriteLine("1. Opret nyt spil");
                Console.WriteLine("2. Placër et skib");
                Console.WriteLine("3. Skyd Skibe");
              // Console.Write(battleship.playerNo);
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

    
            

