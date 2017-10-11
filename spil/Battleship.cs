using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Battleship

    {
        BattleShipMenu battleShipMenu = new BattleShipMenu();
        GameBoards boards = new GameBoards();
        int boatType = 0;
        int xCordinat = 0;
        int yCordinat = 0;
        public int shipCounter = 0;
        int shipCounterP1 = 0;
        int shipCounterP2 = 0;
        int hitcounter = 1;
        int hitcounterP1 = 1;
        int hitcounterP2 = 1;
        public bool placementOrGuessing = false;
        bool error = false;
        bool running = true;
        bool placementError = false;
        
        bool horizontalorvertical = false;
        string choice = "";
        public char[,] GameBoard { get; set; }
        public char[,] placeShipGrid { get; set; }
        
        public Battleship()
        {
            GameBoard = new char[10, 10] { {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' '    , ' ', ' ',' '},
             {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
              {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
               {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                 {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                  {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                   {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '} };

            placeShipGrid = new char[10, 10]{ {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
             {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
              {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
               {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                 {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                  {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                   {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '} };

            placeShipGrid = boards.GameBoardPlayer1;
        }
        

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

        public string GetShootingGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + GameBoard[0, 9] + "  *  " + GameBoard[1, 9] + "  *  " + GameBoard[2, 9] + "  *  " + GameBoard[3, 9] + "  *  " + GameBoard[4, 9] + "  *  " + GameBoard[5, 9] + "  *  " + GameBoard[6, 9] + "  *  " + GameBoard[7, 9] + "  *  " + GameBoard[8, 9] + "  *  " + GameBoard[9, 9] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + GameBoard[0, 8] + "  *  " + GameBoard[1, 8] + "  *  " + GameBoard[2, 8] + "  *  " + GameBoard[3, 8] + "  *  " + GameBoard[4, 8] + "  *  " + GameBoard[5, 8] + "  *  " + GameBoard[6, 8] + "  *  " + GameBoard[7, 8] + "  *  " + GameBoard[8, 8] + "  *  " + GameBoard[9, 8] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + GameBoard[0, 7] + "  *  " + GameBoard[1, 7] + "  *  " + GameBoard[2, 7] + "  *  " + GameBoard[3, 7] + "  *  " + GameBoard[4, 7] + "  *  " + GameBoard[5, 7] + "  *  " + GameBoard[6, 7] + "  *  " + GameBoard[7, 7] + "  *  " + GameBoard[8, 7] + "  *  " + GameBoard[9, 7] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + GameBoard[0, 6] + "  *  " + GameBoard[1, 6] + "  *  " + GameBoard[2, 6] + "  *  " + GameBoard[3, 6] + "  *  " + GameBoard[4, 6] + "  *  " + GameBoard[5, 6] + "  *  " + GameBoard[6, 6] + "  *  " + GameBoard[7, 6] + "  *  " + GameBoard[8, 6] + "  *  " + GameBoard[9, 6] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + GameBoard[0, 5] + "  *  " + GameBoard[1, 5] + "  *  " + GameBoard[2, 5] + "  *  " + GameBoard[3, 5] + "  *  " + GameBoard[4, 5] + "  *  " + GameBoard[5, 5] + "  *  " + GameBoard[6, 5] + "  *  " + GameBoard[7, 5] + "  *  " + GameBoard[8, 5] + "  *  " + GameBoard[9, 5] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + GameBoard[0, 4] + "  *  " + GameBoard[1, 4] + "  *  " + GameBoard[2, 4] + "  *  " + GameBoard[3, 4] + "  *  " + GameBoard[4, 4] + "  *  " + GameBoard[5, 4] + "  *  " + GameBoard[6, 4] + "  *  " + GameBoard[7, 4] + "  *  " + GameBoard[8, 4] + "  *  " + GameBoard[9, 4] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard[0, 3] + "  *  " + GameBoard[1, 3] + "  *  " + GameBoard[2, 3] + "  *  " + GameBoard[3, 3] + "  *  " + GameBoard[4, 3] + "  *  " + GameBoard[5, 3] + "  *  " + GameBoard[6, 3] + "  *  " + GameBoard[7, 3] + "  *  " + GameBoard[8, 3] + "  *  " + GameBoard[9, 3] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *  " + GameBoard[3, 2] + "  *  " + GameBoard[4, 2] + "  *  " + GameBoard[5, 2] + "  *  " + GameBoard[6, 2] + "  *  " + GameBoard[7, 2] + "  *  " + GameBoard[8, 2] + "  *  " + GameBoard[9, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *  " + GameBoard[3, 1] + "  *  " + GameBoard[4, 1] + "  *  " + GameBoard[5, 1] + "  *  " + GameBoard[6, 1] + "  *  " + GameBoard[7, 1] + "  *  " + GameBoard[8, 1] + "  *  " + GameBoard[9, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "0 *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *  " + GameBoard[3, 0] + "  *  " + GameBoard[4, 0] + "  *  " + GameBoard[5, 0] + "  *  " + GameBoard[6, 0] + "  *  " + GameBoard[7, 0] + "  *  " + GameBoard[8, 0] + "  *  " + GameBoard[9, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "     0     1     2     3     4     5     6     7    8     9   X\n";


            return resultat;

        }
       
        //public string GetGameBoardView()
        //{
        //    string resultat = "";
        //    int Row;
        //    int Column;
           

        //    Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
        //    Console.WriteLine("--+--------------------");
        //    for (Row = 0; Row <= 9; Row++)
        //    {
        //        Console.Write((Row).ToString() + " ¦");
        //        for (Column = 0; Column <= 9; Column++)
        //        {
        //            resultat = resultat + GameBoard[Column, Row] + " ";
                  
        //        }

        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("\n");

        //    return resultat;
        //}






        // her kan implementeres metoder til at sætte og flytte en brik

        public void PlaceShips()
        {
            GetBoatType();
            ChoseShip();

            
            horizontalorvertical = false;


        }
        int xCordinatcheck = 0;
        int yCordinatcheck = 0;

        private void CheckforOutOfRangeError()
        {
            if (xCordinat > 9 || yCordinat > 9)
            {
                Console.WriteLine("Du kan ikke placerse her");
                placementError = true;

            }
        }
        private void CheckForOverlap()
        {
            if (placementError == false)
            {
                if (placeShipGrid[xCordinat, yCordinat] == 'S')
                {
                    Console.WriteLine("Du kan ikke placere her");
                    placementError = true;
                }
                if (horizontalorvertical == true)
                {
                    if (xCordinatcheck + boatType > 9)
                    {
                        Console.WriteLine("Du kan ikke placerse her");
                        placementError = true;
                    }
                    else
                    {
                        for (int i = 1; i < boatType; i++)
                        {
                            xCordinatcheck = xCordinatcheck + 1;
                            ShowCordinatesError();
                            if (placeShipGrid[xCordinatcheck, yCordinatcheck] == 'S')
                            {
                                Console.WriteLine("Du kan ikke placered her");
                                error = true;
                            }
                            else
                                break;
                        }
                    }


                }
                if (horizontalorvertical == false)
                {
                    if (yCordinatcheck + boatType > 9)
                    {
                        Console.WriteLine("Du kan ikke placerse her");
                        placementError = true;
                    }
                    else
                    {

                        for (int i = 1; i < boatType; i++)
                        {
                            yCordinatcheck = yCordinatcheck + 1;
                            ShowCordinatesError();
                            if (placeShipGrid[xCordinatcheck, yCordinatcheck] == 'S')
                            {
                                Console.WriteLine("Du kan ikke placere her");
                                error = true;
                            }
                            else
                                break;
                        }
                    }
                }
                if (error == true)
                {
                    placementError = true;
                }
            }
        }
        public void CheckForError()
        {            
            int xCordinatcheck = xCordinat;
            int yCordinatcheck = yCordinat;
            int xOrY = 0;
            int xPlace = 0;
            int yPlace = 0;
            
            bool outOfRange = false;
            TryAgain();
            CheckforOutOfRangeError();
            if (xCordinatcheck  > 10 || yCordinatcheck> 10)
            {
                Console.WriteLine("Du kan ikke placerse her");
                outOfRange = true;

            }
           
            if (outOfRange == false)
            {
                if (placeShipGrid[xCordinat, yCordinat] == 'S')
                {
                    Console.WriteLine("Du kan ikke placere hear");
                    placementError = true;
                }
                //if (horizontalorvertical == true)
                    if (horizontalorvertical == true)
                    {
                        xOrY = xCordinatcheck;
                    }
                else
                    {
                        xOrY = yCordinatcheck;
                    }


                        if (xCordinatcheck + boatType > 9)
                        {
                            Console.WriteLine("Du kan ikke placerse her");
                            placementError = true;
                        }
                        else
                        {
                            int i = 0;
                    do
                    {
                        xOrY = xOrY + 1;
                        ShowCordinatesError();
                        if (horizontalorvertical == true)
                        {
                            xPlace = xOrY;
                            yPlace = yCordinatcheck;
                        }
                        else
                        {
                            xPlace = xCordinatcheck;
                            yPlace = xOrY;
                        }


                        if (placeShipGrid[xPlace, yPlace] == 'S')
                        {
                            Console.WriteLine("Du kan ikke placereds her" + xPlace + "Ff" + yPlace);
                            error = true;
                        }
                        i++;



                    } while (i < boatType && error == false);

                    //    do
                    //    {
                    //        xCordinatcheck = xCordinatcheck + 1;
                    //        ShowCordinatesError();
                    //        if (placeShipGrid[xCordinatcheck, yCordinatcheck] == 'S')
                    //        {
                    //            Console.WriteLine("Du kan ikke placered her");
                    //            error = true;
                    //        }
                    //        i++;

                    //    } while (i < boatType && error == false);
                    //}


                }
                //if (horizontalorvertical == false)
                //{
                //    if (yCordinatcheck + boatType > 9)
                //    {
                //        Console.WriteLine("Du kan ikke placerse her");
                //        placementError = true;
                //    }
                //    else
                //    {
                //        int i = 0;
                //        do
                //        {

                //            yCordinatcheck = yCordinatcheck + 1;
                //            ShowCordinatesError();
                //            if (placeShipGrid[xCordinatcheck, yCordinatcheck] == 'S')
                //            {
                //                Console.WriteLine("Du kan ikke placerea her");
                //                error = true;
                //            }
                //            i++;
                //        } while (i < boatType || error == false);

            }

            if (error == true)
            {
                placementError = true;
            }
        }




    
        int hitShipcounter = 0;
        public void GuessShip()
        {
            Console.Write(currentplayer);
            Console.Write("Vælg X: ");
            xCordinat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vælg y: ");

            yCordinat = Convert.ToInt32(Console.ReadLine());
            CheckForError();
            ShowCordinatesError();
            if (placeShipGrid[xCordinat, yCordinat] == 'S')
            {
                GameBoard[xCordinat, yCordinat] = 'H';
                hitShipcounter++;
            }
            else
            {
                GameBoard[xCordinat, yCordinat] = 'M';
            }

            ValidateWinner();
            ChangePlayer();
            player++;

        }

        public void ValidateWinner()
        {
            if (hitShipcounter == hitcounter)
            {
                Console.Clear();
                Console.WriteLine("Tilykke du har vundet!");
                Console.ReadKey();
            }

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
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);

            

        }

        public int player = 0;

        public string currentplayer = "abe";
       public bool playerNo = false;

        public void ChangePlayer()
        {
            if (placementOrGuessing == false)
            {
                if (player % 2 == 0)
                {
                    currentplayer = "Player 1";
                    playerNo = false;
                    hitcounter = hitcounterP1;
                    shipCounter = shipCounterP1;
                    GameBoard = boards.GameBoardGuessPlayer1;
                    placeShipGrid = boards.GameBoardPlayer1;

                }

                else
                {
                    currentplayer = "Player 2";
                    playerNo = true;
                    hitcounter = hitcounterP2;
                    shipCounter = shipCounterP2;
                    GameBoard = boards.GameBoardGuessPlayer2;
                    placeShipGrid = boards.GameBoardPlayer2;
                }
            }
            if (placementOrGuessing == true)
            {
                if (player % 2 == 0)
                {
                    currentplayer = "Player 1";
                    playerNo = false;
                    hitcounter = hitcounterP1;
                    shipCounter = shipCounterP1;
                    GameBoard = boards.GameBoardGuessPlayer1;
                    placeShipGrid = boards.GameBoardPlayer2;

                }

                else
                {
                    currentplayer = "Player 2";
                    playerNo = true;
                    hitcounter = hitcounterP2;
                    shipCounter = shipCounterP2;
                    GameBoard = boards.GameBoardGuessPlayer2;
                    placeShipGrid = boards.GameBoardPlayer1                                                                                                                     ;
                }
            }
            GetShootingGameBoardView();

        }



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
                    case "1":horizontalorvertical = false;  running = false; break;
                    case "2":horizontalorvertical = true;  running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }

        public void ChoseShip()
        {

            Console.Write(currentplayer);
            Console.Write("Vælg X: ");

            xCordinat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vælg y: ");

            yCordinat = Convert.ToInt32(Console.ReadLine());
            CheckforOutOfRangeError();
            HorizontalOrVertical();
            CheckForError();
            if (placementError == false)
            {
                PlaceShip();
            }
        }

        public void PlaceShip()
        {
            Console.Write(currentplayer);
            if (horizontalorvertical == false)
            {
                placeShipGrid[xCordinat, yCordinat] = 'S';
                for (int i = 1; i < boatType; i++)
                {
                    yCordinat = yCordinat + 1;
                    CheckForError();
                    if (placementError == false)
                    {
                        placeShipGrid[xCordinat, yCordinat] = 'S';
                        if (playerNo == false)
                        {
                            hitcounterP1 = hitcounterP1 + 1;
                        }
                        if (playerNo == true)
                        {
                            hitcounterP2 = hitcounterP2 + 1;
                        }
                        ChangePlayer();

                    }
                   
                        

                }
                
            }
            if (horizontalorvertical == true)
            {
                placeShipGrid[xCordinat, yCordinat] = 'S';
                for (int i = 1; i < boatType; i++)
                {
                    xCordinat = xCordinat + 1;
                    CheckForError();
                    if (placementError == false) 
                    {
                        placeShipGrid[xCordinat, yCordinat] = 'S';
                        if (playerNo == false)
                        {
                            hitcounterP1 = hitcounterP1 + 1;
                        }
                        if (playerNo == true)
                        {
                            hitcounterP2 = hitcounterP2 + 1;
                        }
                        ChangePlayer();

                    } 
                    
                }

            }
            if(playerNo == false)
            {
                shipCounterP1++;
            }
            if (playerNo == true)
            {
                shipCounterP2++;
            }
            player++;           
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

        private void TryAgain()
        {
            placementError = false;
            error = false;
        }

        private void ShowCordinatesError()
        {
            if (xCordinat > 9 || yCordinat > 9)
            {
                Console.WriteLine("Ugyldigt valg.");
                Console.ReadLine();
            }

            if (xCordinatcheck > 9 || yCordinatcheck > 9)
            {
                Console.WriteLine("Ugyldigt valg.");
                Console.ReadLine();
            }
        }


    }
}
