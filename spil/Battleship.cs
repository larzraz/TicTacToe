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
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + placeShipGrid[0, 9] + "  *  " + placeShipGrid[1, 9] + "  *  " + placeShipGrid[2, 9] + "  *  " + placeShipGrid[3, 9] + "  *  " + placeShipGrid[4, 9] + "  *  " + placeShipGrid[5, 9] + "  *  " + placeShipGrid[6, 9] + "  *  " + placeShipGrid[7, 9] + "  *  " + placeShipGrid[8, 9] + "  *  " + placeShipGrid[9, 9] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + placeShipGrid[0, 8] + "  *  " + placeShipGrid[1, 8] + "  *  " + placeShipGrid[2, 8] + "  *  " + placeShipGrid[3, 8] + "  *  " + placeShipGrid[4, 8] + "  *  " + placeShipGrid[5, 8] + "  *  " + placeShipGrid[6, 8] + "  *  " + placeShipGrid[7, 8] + "  *  " + placeShipGrid[8, 8] + "  *  " + placeShipGrid[9, 8] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + placeShipGrid[0, 7] + "  *  " + placeShipGrid[1, 7] + "  *  " + placeShipGrid[2, 7] + "  *  " + placeShipGrid[3, 7] + "  *  " + placeShipGrid[4, 7] + "  *  " + placeShipGrid[5, 7] + "  *  " + placeShipGrid[6, 7] + "  *  " + placeShipGrid[7, 7] + "  *  " + placeShipGrid[8, 7] + "  *  " + placeShipGrid[9, 7] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + placeShipGrid[0, 6] + "  *  " + placeShipGrid[1, 6] + "  *  " + placeShipGrid[2, 6] + "  *  " + placeShipGrid[3, 6] + "  *  " + placeShipGrid[4, 6] + "  *  " + placeShipGrid[5, 6] + "  *  " + placeShipGrid[6, 6] + "  *  " + placeShipGrid[7, 6] + "  *  " + placeShipGrid[8, 6] + "  *  " + placeShipGrid[9, 6] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + placeShipGrid[0, 5] + "  *  " + placeShipGrid[1, 5] + "  *  " + placeShipGrid[2, 5] + "  *  " + placeShipGrid[3, 5] + "  *  " + placeShipGrid[4, 5] + "  *  " + placeShipGrid[5, 5] + "  *  " + placeShipGrid[6, 5] + "  *  " + placeShipGrid[7, 5] + "  *  " + placeShipGrid[8, 5] + "  *  " + placeShipGrid[9, 5] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + placeShipGrid[0, 4] + "  *  " + placeShipGrid[1, 4] + "  *  " + placeShipGrid[2, 4] + "  *  " + placeShipGrid[3, 4] + "  *  " + placeShipGrid[4, 4] + "  *  " + placeShipGrid[5, 4] + "  *  " + placeShipGrid[6, 4] + "  *  " + placeShipGrid[7, 4] + "  *  " + placeShipGrid[8, 4] + "  *  " + placeShipGrid[9, 4] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + placeShipGrid[0, 3] + "  *  " + placeShipGrid[1, 3] + "  *  " + placeShipGrid[2, 3] + "  *  " + placeShipGrid[3, 3] + "  *  " + placeShipGrid[4, 3] + "  *  " + placeShipGrid[5, 3] + "  *  " + placeShipGrid[6, 3] + "  *  " + placeShipGrid[7, 3] + "  *  " + placeShipGrid[8, 3] + "  *  " + placeShipGrid[9, 3] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + placeShipGrid[0, 2] + "  *  " + placeShipGrid[1, 2] + "  *  " + placeShipGrid[2, 2] + "  *  " + placeShipGrid[3, 2] + "  *  " + placeShipGrid[4, 2] + "  *  " + placeShipGrid[5, 2] + "  *  " + placeShipGrid[6, 2] + "  *  " + placeShipGrid[7, 2] + "  *  " + placeShipGrid[8, 2] + "  *  " + placeShipGrid[9, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + placeShipGrid[0, 1] + "  *  " + placeShipGrid[1, 1] + "  *  " + placeShipGrid[2, 1] + "  *  " + placeShipGrid[3, 1] + "  *  " + placeShipGrid[4, 1] + "  *  " + placeShipGrid[5, 1] + "  *  " + placeShipGrid[6, 1] + "  *  " + placeShipGrid[7, 1] + "  *  " + placeShipGrid[8, 1] + "  *  " + placeShipGrid[9, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "0 *  " + placeShipGrid[0, 0] + "  *  " + placeShipGrid[1, 0] + "  *  " + placeShipGrid[2, 0] + "  *  " + placeShipGrid[3, 0] + "  *  " + placeShipGrid[4, 0] + "  *  " + placeShipGrid[5, 0] + "  *  " + placeShipGrid[6, 0] + "  *  " + placeShipGrid[7, 0] + "  *  " + placeShipGrid[8, 0] + "  *  " + placeShipGrid[9, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "     0     1     2     3     4     5     6     7    8     9   X\n";


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
            PlaceShip();

            horizontal = false;
            vertical = false;


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

            HorizontalOrVertical();



            if (vertical == true)
                placeShipGrid[xCordinat, yCordinat] = 'a';
            {
                for (int i = 0; i < boatType; i++)
                {
                    yCordinat = yCordinat + 1;
                    placeShipGrid[xCordinat, yCordinat] = 'k';
                }
                horizontal = false;
                vertical = false;
            }
            if (horizontal == true)
                placeShipGrid[xCordinat, yCordinat] = 'a';
            {
                for (int i = 0; i <= boatType; i++)
                {
                    xCordinat = xCordinat + 1;
                    placeShipGrid[xCordinat, yCordinat] = 'c'; 
                }
                horizontal = false;
                vertical = false;

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
