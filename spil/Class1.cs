using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class GameBoards
    {
        public char[,] GameBoardPlayer1 { get; set; }
        public char[,] GameBoardPlayer2 { get; set; }
        public char[,] GameBoardGuessPlayer2 { get; set; }
        public char[,] GameBoardGuessPlayer1 { get; set; }
        public GameBoards()
        {
            GameBoardPlayer1 = new char[10, 10] { {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
             {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
              {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
               {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                 {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                  {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                   {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '} };


            GameBoardPlayer2 = new char[10, 10] { {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
             {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
              {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
               {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                 {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                  {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                   {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '} };

            GameBoardGuessPlayer2 = new char[10, 10] { {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
             {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
              {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
               {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                 {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                  {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
                   {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
            {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '} };

            GameBoardGuessPlayer1 = new char[10, 10] { {' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' '},
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

        public string GetGridBoardPlayer1View()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + GameBoardPlayer1[0, 9] + "  *  " + GameBoardPlayer1[1, 9] + "  *  " + GameBoardPlayer1[2, 9] + "  *  " + GameBoardPlayer1[3, 9] + "  *  " + GameBoardPlayer1[4, 9] + "  *  " + GameBoardPlayer1[5, 9] + "  *  " + GameBoardPlayer1[6, 9] + "  *  " + GameBoardPlayer1[7, 9] + "  *  " + GameBoardPlayer1[8, 9] + "  *  " + GameBoardPlayer1[9, 9] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + GameBoardPlayer1[0, 8] + "  *  " + GameBoardPlayer1[1, 8] + "  *  " + GameBoardPlayer1[2, 8] + "  *  " + GameBoardPlayer1[3, 8] + "  *  " + GameBoardPlayer1[4, 8] + "  *  " + GameBoardPlayer1[5, 8] + "  *  " + GameBoardPlayer1[6, 8] + "  *  " + GameBoardPlayer1[7, 8] + "  *  " + GameBoardPlayer1[8, 8] + "  *  " + GameBoardPlayer1[9, 8] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + GameBoardPlayer1[0, 7] + "  *  " + GameBoardPlayer1[1, 7] + "  *  " + GameBoardPlayer1[2, 7] + "  *  " + GameBoardPlayer1[3, 7] + "  *  " + GameBoardPlayer1[4, 7] + "  *  " + GameBoardPlayer1[5, 7] + "  *  " + GameBoardPlayer1[6, 7] + "  *  " + GameBoardPlayer1[7, 7] + "  *  " + GameBoardPlayer1[8, 7] + "  *  " + GameBoardPlayer1[9, 7] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + GameBoardPlayer1[0, 6] + "  *  " + GameBoardPlayer1[1, 6] + "  *  " + GameBoardPlayer1[2, 6] + "  *  " + GameBoardPlayer1[3, 6] + "  *  " + GameBoardPlayer1[4, 6] + "  *  " + GameBoardPlayer1[5, 6] + "  *  " + GameBoardPlayer1[6, 6] + "  *  " + GameBoardPlayer1[7, 6] + "  *  " + GameBoardPlayer1[8, 6] + "  *  " + GameBoardPlayer1[9, 6] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + GameBoardPlayer1[0, 5] + "  *  " + GameBoardPlayer1[1, 5] + "  *  " + GameBoardPlayer1[2, 5] + "  *  " + GameBoardPlayer1[3, 5] + "  *  " + GameBoardPlayer1[4, 5] + "  *  " + GameBoardPlayer1[5, 5] + "  *  " + GameBoardPlayer1[6, 5] + "  *  " + GameBoardPlayer1[7, 5] + "  *  " + GameBoardPlayer1[8, 5] + "  *  " + GameBoardPlayer1[9, 5] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + GameBoardPlayer1[0, 4] + "  *  " + GameBoardPlayer1[1, 4] + "  *  " + GameBoardPlayer1[2, 4] + "  *  " + GameBoardPlayer1[3, 4] + "  *  " + GameBoardPlayer1[4, 4] + "  *  " + GameBoardPlayer1[5, 4] + "  *  " + GameBoardPlayer1[6, 4] + "  *  " + GameBoardPlayer1[7, 4] + "  *  " + GameBoardPlayer1[8, 4] + "  *  " + GameBoardPlayer1[9, 4] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoardPlayer1[0, 3] + "  *  " + GameBoardPlayer1[1, 3] + "  *  " + GameBoardPlayer1[2, 3] + "  *  " + GameBoardPlayer1[3, 3] + "  *  " + GameBoardPlayer1[4, 3] + "  *  " + GameBoardPlayer1[5, 3] + "  *  " + GameBoardPlayer1[6, 3] + "  *  " + GameBoardPlayer1[7, 3] + "  *  " + GameBoardPlayer1[8, 3] + "  *  " + GameBoardPlayer1[9, 3] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoardPlayer1[0, 2] + "  *  " + GameBoardPlayer1[1, 2] + "  *  " + GameBoardPlayer1[2, 2] + "  *  " + GameBoardPlayer1[3, 2] + "  *  " + GameBoardPlayer1[4, 2] + "  *  " + GameBoardPlayer1[5, 2] + "  *  " + GameBoardPlayer1[6, 2] + "  *  " + GameBoardPlayer1[7, 2] + "  *  " + GameBoardPlayer1[8, 2] + "  *  " + GameBoardPlayer1[9, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoardPlayer1[0, 1] + "  *  " + GameBoardPlayer1[1, 1] + "  *  " + GameBoardPlayer1[2, 1] + "  *  " + GameBoardPlayer1[3, 1] + "  *  " + GameBoardPlayer1[4, 1] + "  *  " + GameBoardPlayer1[5, 1] + "  *  " + GameBoardPlayer1[6, 1] + "  *  " + GameBoardPlayer1[7, 1] + "  *  " + GameBoardPlayer1[8, 1] + "  *  " + GameBoardPlayer1[9, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "0 *  " + GameBoardPlayer1[0, 0] + "  *  " + GameBoardPlayer1[1, 0] + "  *  " + GameBoardPlayer1[2, 0] + "  *  " + GameBoardPlayer1[3, 0] + "  *  " + GameBoardPlayer1[4, 0] + "  *  " + GameBoardPlayer1[5, 0] + "  *  " + GameBoardPlayer1[6, 0] + "  *  " + GameBoardPlayer1[7, 0] + "  *  " + GameBoardPlayer1[8, 0] + "  *  " + GameBoardPlayer1[9, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "     0     1     2     3     4     5     6     7    8     9   X\n";


            return resultat;
        }
        public string GetGridBoardPlayer2View()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + GameBoardPlayer2[0, 9] + "  *  " + GameBoardPlayer2[1, 9] + "  *  " + GameBoardPlayer2[2, 9] + "  *  " + GameBoardPlayer2[3, 9] + "  *  " + GameBoardPlayer2[4, 9] + "  *  " + GameBoardPlayer2[5, 9] + "  *  " + GameBoardPlayer2[6, 9] + "  *  " + GameBoardPlayer2[7, 9] + "  *  " + GameBoardPlayer2[8, 9] + "  *  " + GameBoardPlayer2[9, 9] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + GameBoardPlayer2[0, 8] + "  *  " + GameBoardPlayer2[1, 8] + "  *  " + GameBoardPlayer2[2, 8] + "  *  " + GameBoardPlayer2[3, 8] + "  *  " + GameBoardPlayer2[4, 8] + "  *  " + GameBoardPlayer2[5, 8] + "  *  " + GameBoardPlayer2[6, 8] + "  *  " + GameBoardPlayer2[7, 8] + "  *  " + GameBoardPlayer2[8, 8] + "  *  " + GameBoardPlayer2[9, 8] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + GameBoardPlayer2[0, 7] + "  *  " + GameBoardPlayer2[1, 7] + "  *  " + GameBoardPlayer2[2, 7] + "  *  " + GameBoardPlayer2[3, 7] + "  *  " + GameBoardPlayer2[4, 7] + "  *  " + GameBoardPlayer2[5, 7] + "  *  " + GameBoardPlayer2[6, 7] + "  *  " + GameBoardPlayer2[7, 7] + "  *  " + GameBoardPlayer2[8, 7] + "  *  " + GameBoardPlayer2[9, 7] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + GameBoardPlayer2[0, 6] + "  *  " + GameBoardPlayer2[1, 6] + "  *  " + GameBoardPlayer2[2, 6] + "  *  " + GameBoardPlayer2[3, 6] + "  *  " + GameBoardPlayer2[4, 6] + "  *  " + GameBoardPlayer2[5, 6] + "  *  " + GameBoardPlayer2[6, 6] + "  *  " + GameBoardPlayer2[7, 6] + "  *  " + GameBoardPlayer2[8, 6] + "  *  " + GameBoardPlayer2[9, 6] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + GameBoardPlayer2[0, 5] + "  *  " + GameBoardPlayer2[1, 5] + "  *  " + GameBoardPlayer2[2, 5] + "  *  " + GameBoardPlayer2[3, 5] + "  *  " + GameBoardPlayer2[4, 5] + "  *  " + GameBoardPlayer2[5, 5] + "  *  " + GameBoardPlayer2[6, 5] + "  *  " + GameBoardPlayer2[7, 5] + "  *  " + GameBoardPlayer2[8, 5] + "  *  " + GameBoardPlayer2[9, 5] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + GameBoardPlayer2[0, 4] + "  *  " + GameBoardPlayer2[1, 4] + "  *  " + GameBoardPlayer2[2, 4] + "  *  " + GameBoardPlayer2[3, 4] + "  *  " + GameBoardPlayer2[4, 4] + "  *  " + GameBoardPlayer2[5, 4] + "  *  " + GameBoardPlayer2[6, 4] + "  *  " + GameBoardPlayer2[7, 4] + "  *  " + GameBoardPlayer2[8, 4] + "  *  " + GameBoardPlayer2[9, 4] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoardPlayer2[0, 3] + "  *  " + GameBoardPlayer2[1, 3] + "  *  " + GameBoardPlayer2[2, 3] + "  *  " + GameBoardPlayer2[3, 3] + "  *  " + GameBoardPlayer2[4, 3] + "  *  " + GameBoardPlayer2[5, 3] + "  *  " + GameBoardPlayer2[6, 3] + "  *  " + GameBoardPlayer2[7, 3] + "  *  " + GameBoardPlayer2[8, 3] + "  *  " + GameBoardPlayer2[9, 3] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoardPlayer2[0, 2] + "  *  " + GameBoardPlayer2[1, 2] + "  *  " + GameBoardPlayer2[2, 2] + "  *  " + GameBoardPlayer2[3, 2] + "  *  " + GameBoardPlayer2[4, 2] + "  *  " + GameBoardPlayer2[5, 2] + "  *  " + GameBoardPlayer2[6, 2] + "  *  " + GameBoardPlayer2[7, 2] + "  *  " + GameBoardPlayer2[8, 2] + "  *  " + GameBoardPlayer2[9, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoardPlayer2[0, 1] + "  *  " + GameBoardPlayer2[1, 1] + "  *  " + GameBoardPlayer2[2, 1] + "  *  " + GameBoardPlayer2[3, 1] + "  *  " + GameBoardPlayer2[4, 1] + "  *  " + GameBoardPlayer2[5, 1] + "  *  " + GameBoardPlayer2[6, 1] + "  *  " + GameBoardPlayer2[7, 1] + "  *  " + GameBoardPlayer2[8, 1] + "  *  " + GameBoardPlayer2[9, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "0 *  " + GameBoardPlayer2[0, 0] + "  *  " + GameBoardPlayer2[1, 0] + "  *  " + GameBoardPlayer2[2, 0] + "  *  " + GameBoardPlayer2[3, 0] + "  *  " + GameBoardPlayer2[4, 0] + "  *  " + GameBoardPlayer2[5, 0] + "  *  " + GameBoardPlayer2[6, 0] + "  *  " + GameBoardPlayer2[7, 0] + "  *  " + GameBoardPlayer2[8, 0] + "  *  " + GameBoardPlayer2[9, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "     0     1     2     3     4     5     6     7    8     9   X\n";


            return resultat;
        }

        public string GetGridBoardGuessPlayer2View()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + GameBoardGuessPlayer2[0, 9] + "  *  " + GameBoardGuessPlayer2[1, 9] + "  *  " + GameBoardGuessPlayer2[2, 9] + "  *  " + GameBoardGuessPlayer2[3, 9] + "  *  " + GameBoardGuessPlayer2[4, 9] + "  *  " + GameBoardGuessPlayer2[5, 9] + "  *  " + GameBoardGuessPlayer2[6, 9] + "  *  " + GameBoardGuessPlayer2[7, 9] + "  *  " + GameBoardGuessPlayer2[8, 9] + "  *  " + GameBoardGuessPlayer2[9, 9] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + GameBoardGuessPlayer2[0, 8] + "  *  " + GameBoardGuessPlayer2[1, 8] + "  *  " + GameBoardGuessPlayer2[2, 8] + "  *  " + GameBoardGuessPlayer2[3, 8] + "  *  " + GameBoardGuessPlayer2[4, 8] + "  *  " + GameBoardGuessPlayer2[5, 8] + "  *  " + GameBoardGuessPlayer2[6, 8] + "  *  " + GameBoardGuessPlayer2[7, 8] + "  *  " + GameBoardGuessPlayer2[8, 8] + "  *  " + GameBoardGuessPlayer2[9, 8] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + GameBoardGuessPlayer2[0, 7] + "  *  " + GameBoardGuessPlayer2[1, 7] + "  *  " + GameBoardGuessPlayer2[2, 7] + "  *  " + GameBoardGuessPlayer2[3, 7] + "  *  " + GameBoardGuessPlayer2[4, 7] + "  *  " + GameBoardGuessPlayer2[5, 7] + "  *  " + GameBoardGuessPlayer2[6, 7] + "  *  " + GameBoardGuessPlayer2[7, 7] + "  *  " + GameBoardGuessPlayer2[8, 7] + "  *  " + GameBoardGuessPlayer2[9, 7] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + GameBoardGuessPlayer2[0, 6] + "  *  " + GameBoardGuessPlayer2[1, 6] + "  *  " + GameBoardGuessPlayer2[2, 6] + "  *  " + GameBoardGuessPlayer2[3, 6] + "  *  " + GameBoardGuessPlayer2[4, 6] + "  *  " + GameBoardGuessPlayer2[5, 6] + "  *  " + GameBoardGuessPlayer2[6, 6] + "  *  " + GameBoardGuessPlayer2[7, 6] + "  *  " + GameBoardGuessPlayer2[8, 6] + "  *  " + GameBoardGuessPlayer2[9, 6] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + GameBoardGuessPlayer2[0, 5] + "  *  " + GameBoardGuessPlayer2[1, 5] + "  *  " + GameBoardGuessPlayer2[2, 5] + "  *  " + GameBoardGuessPlayer2[3, 5] + "  *  " + GameBoardGuessPlayer2[4, 5] + "  *  " + GameBoardGuessPlayer2[5, 5] + "  *  " + GameBoardGuessPlayer2[6, 5] + "  *  " + GameBoardGuessPlayer2[7, 5] + "  *  " + GameBoardGuessPlayer2[8, 5] + "  *  " + GameBoardGuessPlayer2[9, 5] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + GameBoardGuessPlayer2[0, 4] + "  *  " + GameBoardGuessPlayer2[1, 4] + "  *  " + GameBoardGuessPlayer2[2, 4] + "  *  " + GameBoardGuessPlayer2[3, 4] + "  *  " + GameBoardGuessPlayer2[4, 4] + "  *  " + GameBoardGuessPlayer2[5, 4] + "  *  " + GameBoardGuessPlayer2[6, 4] + "  *  " + GameBoardGuessPlayer2[7, 4] + "  *  " + GameBoardGuessPlayer2[8, 4] + "  *  " + GameBoardGuessPlayer2[9, 4] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoardGuessPlayer2[0, 3] + "  *  " + GameBoardGuessPlayer2[1, 3] + "  *  " + GameBoardGuessPlayer2[2, 3] + "  *  " + GameBoardGuessPlayer2[3, 3] + "  *  " + GameBoardGuessPlayer2[4, 3] + "  *  " + GameBoardGuessPlayer2[5, 3] + "  *  " + GameBoardGuessPlayer2[6, 3] + "  *  " + GameBoardGuessPlayer2[7, 3] + "  *  " + GameBoardGuessPlayer2[8, 3] + "  *  " + GameBoardGuessPlayer2[9, 3] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoardGuessPlayer2[0, 2] + "  *  " + GameBoardGuessPlayer2[1, 2] + "  *  " + GameBoardGuessPlayer2[2, 2] + "  *  " + GameBoardGuessPlayer2[3, 2] + "  *  " + GameBoardGuessPlayer2[4, 2] + "  *  " + GameBoardGuessPlayer2[5, 2] + "  *  " + GameBoardGuessPlayer2[6, 2] + "  *  " + GameBoardGuessPlayer2[7, 2] + "  *  " + GameBoardGuessPlayer2[8, 2] + "  *  " + GameBoardGuessPlayer2[9, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoardGuessPlayer2[0, 1] + "  *  " + GameBoardGuessPlayer2[1, 1] + "  *  " + GameBoardGuessPlayer2[2, 1] + "  *  " + GameBoardGuessPlayer2[3, 1] + "  *  " + GameBoardGuessPlayer2[4, 1] + "  *  " + GameBoardGuessPlayer2[5, 1] + "  *  " + GameBoardGuessPlayer2[6, 1] + "  *  " + GameBoardGuessPlayer2[7, 1] + "  *  " + GameBoardGuessPlayer2[8, 1] + "  *  " + GameBoardGuessPlayer2[9, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "0 *  " + GameBoardGuessPlayer2[0, 0] + "  *  " + GameBoardGuessPlayer2[1, 0] + "  *  " + GameBoardGuessPlayer2[2, 0] + "  *  " + GameBoardGuessPlayer2[3, 0] + "  *  " + GameBoardGuessPlayer2[4, 0] + "  *  " + GameBoardGuessPlayer2[5, 0] + "  *  " + GameBoardGuessPlayer2[6, 0] + "  *  " + GameBoardGuessPlayer2[7, 0] + "  *  " + GameBoardGuessPlayer2[8, 0] + "  *  " + GameBoardGuessPlayer2[9, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "     0     1     2     3     4     5     6     7    8     9   X\n";


            return resultat;
        }
        public string GetGridBoardGuessPlayer1View()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + GameBoardGuessPlayer1[0, 9] + "  *  " + GameBoardGuessPlayer1[1, 9] + "  *  " + GameBoardGuessPlayer1[2, 9] + "  *  " + GameBoardGuessPlayer1[3, 9] + "  *  " + GameBoardGuessPlayer1[4, 9] + "  *  " + GameBoardGuessPlayer1[5, 9] + "  *  " + GameBoardGuessPlayer1[6, 9] + "  *  " + GameBoardGuessPlayer1[7, 9] + "  *  " + GameBoardGuessPlayer1[8, 9] + "  *  " + GameBoardGuessPlayer1[9, 9] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + GameBoardGuessPlayer1[0, 8] + "  *  " + GameBoardGuessPlayer1[1, 8] + "  *  " + GameBoardGuessPlayer1[2, 8] + "  *  " + GameBoardGuessPlayer1[3, 8] + "  *  " + GameBoardGuessPlayer1[4, 8] + "  *  " + GameBoardGuessPlayer1[5, 8] + "  *  " + GameBoardGuessPlayer1[6, 8] + "  *  " + GameBoardGuessPlayer1[7, 8] + "  *  " + GameBoardGuessPlayer1[8, 8] + "  *  " + GameBoardGuessPlayer1[9, 8] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + GameBoardGuessPlayer1[0, 7] + "  *  " + GameBoardGuessPlayer1[1, 7] + "  *  " + GameBoardGuessPlayer1[2, 7] + "  *  " + GameBoardGuessPlayer1[3, 7] + "  *  " + GameBoardGuessPlayer1[4, 7] + "  *  " + GameBoardGuessPlayer1[5, 7] + "  *  " + GameBoardGuessPlayer1[6, 7] + "  *  " + GameBoardGuessPlayer1[7, 7] + "  *  " + GameBoardGuessPlayer1[8, 7] + "  *  " + GameBoardGuessPlayer1[9, 7] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + GameBoardGuessPlayer1[0, 6] + "  *  " + GameBoardGuessPlayer1[1, 6] + "  *  " + GameBoardGuessPlayer1[2, 6] + "  *  " + GameBoardGuessPlayer1[3, 6] + "  *  " + GameBoardGuessPlayer1[4, 6] + "  *  " + GameBoardGuessPlayer1[5, 6] + "  *  " + GameBoardGuessPlayer1[6, 6] + "  *  " + GameBoardGuessPlayer1[7, 6] + "  *  " + GameBoardGuessPlayer1[8, 6] + "  *  " + GameBoardGuessPlayer1[9, 6] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + GameBoardGuessPlayer1[0, 5] + "  *  " + GameBoardGuessPlayer1[1, 5] + "  *  " + GameBoardGuessPlayer1[2, 5] + "  *  " + GameBoardGuessPlayer1[3, 5] + "  *  " + GameBoardGuessPlayer1[4, 5] + "  *  " + GameBoardGuessPlayer1[5, 5] + "  *  " + GameBoardGuessPlayer1[6, 5] + "  *  " + GameBoardGuessPlayer1[7, 5] + "  *  " + GameBoardGuessPlayer1[8, 5] + "  *  " + GameBoardGuessPlayer1[9, 5] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + GameBoardGuessPlayer1[0, 4] + "  *  " + GameBoardGuessPlayer1[1, 4] + "  *  " + GameBoardGuessPlayer1[2, 4] + "  *  " + GameBoardGuessPlayer1[3, 4] + "  *  " + GameBoardGuessPlayer1[4, 4] + "  *  " + GameBoardGuessPlayer1[5, 4] + "  *  " + GameBoardGuessPlayer1[6, 4] + "  *  " + GameBoardGuessPlayer1[7, 4] + "  *  " + GameBoardGuessPlayer1[8, 4] + "  *  " + GameBoardGuessPlayer1[9, 4] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoardGuessPlayer1[0, 3] + "  *  " + GameBoardGuessPlayer1[1, 3] + "  *  " + GameBoardGuessPlayer1[2, 3] + "  *  " + GameBoardGuessPlayer1[3, 3] + "  *  " + GameBoardGuessPlayer1[4, 3] + "  *  " + GameBoardGuessPlayer1[5, 3] + "  *  " + GameBoardGuessPlayer1[6, 3] + "  *  " + GameBoardGuessPlayer1[7, 3] + "  *  " + GameBoardGuessPlayer1[8, 3] + "  *  " + GameBoardGuessPlayer1[9, 3] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoardGuessPlayer1[0, 2] + "  *  " + GameBoardGuessPlayer1[1, 2] + "  *  " + GameBoardGuessPlayer1[2, 2] + "  *  " + GameBoardGuessPlayer1[3, 2] + "  *  " + GameBoardGuessPlayer1[4, 2] + "  *  " + GameBoardGuessPlayer1[5, 2] + "  *  " + GameBoardGuessPlayer1[6, 2] + "  *  " + GameBoardGuessPlayer1[7, 2] + "  *  " + GameBoardGuessPlayer1[8, 2] + "  *  " + GameBoardGuessPlayer1[9, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoardGuessPlayer1[0, 1] + "  *  " + GameBoardGuessPlayer1[1, 1] + "  *  " + GameBoardGuessPlayer1[2, 1] + "  *  " + GameBoardGuessPlayer1[3, 1] + "  *  " + GameBoardGuessPlayer1[4, 1] + "  *  " + GameBoardGuessPlayer1[5, 1] + "  *  " + GameBoardGuessPlayer1[6, 1] + "  *  " + GameBoardGuessPlayer1[7, 1] + "  *  " + GameBoardGuessPlayer1[8, 1] + "  *  " + GameBoardGuessPlayer1[9, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "0 *  " + GameBoardGuessPlayer1[0, 0] + "  *  " + GameBoardGuessPlayer1[1, 0] + "  *  " + GameBoardGuessPlayer1[2, 0] + "  *  " + GameBoardGuessPlayer1[3, 0] + "  *  " + GameBoardGuessPlayer1[4, 0] + "  *  " + GameBoardGuessPlayer1[5, 0] + "  *  " + GameBoardGuessPlayer1[6, 0] + "  *  " + GameBoardGuessPlayer1[7, 0] + "  *  " + GameBoardGuessPlayer1[8, 0] + "  *  " + GameBoardGuessPlayer1[9, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "     0     1     2     3     4     5     6     7    8     9   X\n";


            return resultat;
        }


    }
}
