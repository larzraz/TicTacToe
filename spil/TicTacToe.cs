using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class TicTacToe
    {


        public char[,] GameBoard { get; set; }
        public TicTacToe()
        {
            GameBoard = new char[3, 3] { {'1', '4', '7'},
                {'2', '5', '8'},
                { '3', '6', '9'} };
        }

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "     1     2     3    X\n";

            return resultat;
        }

        public int counter = 0;
        public string result = " ";
        private string playAgain = "Y";

        public void Playagain()
        {
            Console.WriteLine("Do you want to play again?");
            if (Console.ReadLine().Equals("y"))
                playAgain = "y";
            else
                playAgain = "n";
        }

        Boolean hasWon = false;

        public string Validate()
        {

            int u = 0;

            for (int i = 0; i < 3; i++)
            {

                if (GameBoard[i, u] == currentplayer && GameBoard[i, u + 1] == currentplayer && GameBoard[i, u + 2] == currentplayer)
                {

                    result = "w";
                    hasWon = true;

                }

                if (GameBoard[u, i] == currentplayer && GameBoard[u + 1, i] == currentplayer && GameBoard[u + 2, i] == currentplayer)
                {
                    result = "w";
                    hasWon = true;
                }

                if (GameBoard[0, 0] == currentplayer && GameBoard[1, 1] == currentplayer && GameBoard[2, 2] == currentplayer)
                {
                    result = "w";
                    hasWon = true;
                }

                if (GameBoard[0, 2] == currentplayer && GameBoard[1, 1] == currentplayer && GameBoard[2, 0] == currentplayer)
                {
                    result = "w";
                    hasWon = true;
                }
                if (GameBoard.Length == counter)
                {
                    result = "game over";

                }
            }

            return result;
        }

    
        //void askData(String player)
        //{
        //    Console.Clear();

        //    Console.WriteLine("Player: " + player);
        //    int selection1   ;
        //    int selection2;
        //    while (true)
        //    {
        //        Console.WriteLine("Please enter your selection.");
        //        GetGameBoardView();
        //        selection1 = Convert.ToInt32(Console.ReadLine());
        //        selection2 = Convert.ToInt32(Console.ReadLine());
        //        if (selection1 < 0 || selection1 > 9 ||selection2 < 0 || selection2 > 9 || GameBoard[selection1, selection2].Equals("X") || GameBoard[selection1, selection2].Equals("O"))
        //            Console.WriteLine("Invalid selection!");
        //        else
        //            break;
        //    }
        //    GameBoard[selection1,selection2] = currentplayer;
            


        //}   




        //public void WinnerOrLoser()
        //{
        //    if (result == "w")
        //    {
        //        Winner();
        //    }
        //}

        //public string Winner()

        //{
        //    while (hasWon == true)
        //        return "Tillykke du har vundet"; }
        //    else

        //}

    
                    

        public int player = 0; // Konstant til brug af skift spiller

        public char currentplayer = 'x'; //Currentplayer bliver ikke b, men omdannet til x eller o i "Shiftplayer"


                 
           
           
        

        public char ChangePlayer() //Metode for at skifte spiller
        {
            if (player % 2 == 0)
            {
                currentplayer = 'x'; // player1 0 % 2 = 0 derfor = x

            }

            else
            { currentplayer = 'o'; } // player2 vil aktiveres da player++ vil være = 1 % 2 = 1 ('o')

            return currentplayer; // returner skiftevis x og 0
        }


        public void PlaceTile()
        {

            int xValue;

            int yValue;

            Console.Write("Vælg X: "); //Blank cursor, skriv hvad du vil

            xValue = Convert.ToInt32(Console.ReadLine()); // Giv din xValue en værdi (int) 

            Console.Write("Vælg y: "); // Blank cursor

            yValue = Convert.ToInt32(Console.ReadLine()); // Giv din yValue en værdi (int)

            ChangePlayer();

            GameBoard[xValue - 1, yValue - 1] = currentplayer;

            counter++;

            player++;

            Validate();


            //do
            //{
            //    choice = GetUserChoise();
            //    switch (choice)
            //    {
            //        case "1": GameBoard[0, 0] = 'x'; break;
            //        case "2": GameBoard[0, 1] = 'x'; break;
            //        case "3": GameBoard[0, 2] = 'x'; break;
            //        case "4": GameBoard[1, 0] = 'x'; break;
            //        case "5": GameBoard[1, 1] = 'x'; break;
            //        case "6": GameBoard[1, 1] = 'x'; break;
            //        case "7": GameBoard[1, 1] = 'x'; break;
            //        case "8": GameBoard[1, 1] = 'x'; break;
            //        case "9": GameBoard[1, 1] = 'x'; break;
            //        case "0": running = false; break;
            //        default: ShowMenuSelectionErroe(); break;
            //    }
            //} while (running);



        }

        

        // her kan implementeres metoder til at sætte og flytte en brik

    }
}
