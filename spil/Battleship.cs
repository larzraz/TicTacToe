using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Battleship

    {
        int boatType = 0;
        bool running = true;
        string choice = "";
        public char[,] GameBoard { get; set; }
        public Battleship()
        {
            GameBoard = new char[10, 10] { {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
             {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
              {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
               {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                 {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                  {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                   {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '} };
        }
        char[,] placeShipGrid = new char[10, 10];
       

      

        public string GetGridBoardView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "4 *  " + placeShipGrid[0, 3] + "  *  " + placeShipGrid[1, 3] + "  *  " + placeShipGrid[2, 3] + "  *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "3 *  " + placeShipGrid[0, 2] + "  *  " + placeShipGrid[1, 2] + "  *  " + placeShipGrid[2, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "2 *  " + placeShipGrid[0, 1] + "  *  " + placeShipGrid[1, 1] + "  *  " + placeShipGrid[2, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "1 *  " + placeShipGrid[0, 0] + "  *  " + placeShipGrid[1, 0] + "  *  " + placeShipGrid[2, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "     1     2     3    X\n";

            return resultat;
        }


        public string GetGameBoardView()
        {
            string resultat = "";
            int Row;
            int Column;
           

            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+--------------------");
            for (Row = 0; Row <= 9; Row++)
            {
                Console.Write((Row).ToString() + " ¦");
                for (Column = 0; Column <= 9; Column++)
                {
                    resultat = resultat + GameBoard[Column, Row] + " ";
                  
                }

                Console.WriteLine();
            }
            Console.WriteLine("\n");

            return resultat;
        }






        // her kan implementeres metoder til at sætte og flytte en brik

        public void PlaceShips()
        {
            GetBoatType();
            HorizontalOrVertical();
            PlaceShip();

        }

       

        public void GetBoatType()
        {
            int boat = 2;
            int ship = 3;

            Console.Write("Vælg båd: \n");

            Console.Write("1: båd \n");
            Console.Write("2: skib ");

            
            do
            {
                
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": boatType = boat; running = false; break;
                    case "2": boatType = ship; running = false;  break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);

            

        }

        bool vertical = false;
        bool horizontal = false;
        public void HorizontalOrVertical()
        {
            running = true;
            Console.Write("Hvilken vej vil du placere skibet?\n");

            Console.Write("1: Verticalt\n");
            Console.Write("2: Horizontalt");

            
            do
            {

                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": vertical = true; running = false; break;
                    case "2": horizontal = true; running = false; break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }

        public void PlaceShip()
        {
            int xCordinat;

            int yCordinat;

            Console.Write("Vælg X: ");

            xCordinat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vælg y: ");

            yCordinat = Convert.ToInt32(Console.ReadLine());



            placeShipGrid[xCordinat, yCordinat] = 'b';
            if (vertical == true)
            {
                for (int i = 0; i <= boatType; i++)
                {
                    yCordinat = yCordinat + 1;
                    placeShipGrid[xCordinat, yCordinat] = 'b';
                }
            }
            if (horizontal == true)
            {
                for (int i = 0; i <= boatType; i++)
                {
                    xCordinat = xCordinat + 1;
                    placeShipGrid[xCordinat, yCordinat] = 'b'; 
                }
            }
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
