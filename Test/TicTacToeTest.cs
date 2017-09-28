using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using spil;

namespace Test
{
    [TestClass]
    public class TicTacToeTest
    {
        [TestMethod]
        public void NeitherPlayerHasThreeInARow()
        {
            TicTacToe ticTacToe = new TicTacToe();
            const string expected = " ";
            string actual = ticTacToe.Validate();
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]

        public void PlayerHasThreeInVerticalRow()
        {
            TicTacToe ticTacToe = new TicTacToe();
            const string expected = "w";
            ticTacToe.GameBoard[2, 2] = ticTacToe.currentplayer;

            ticTacToe.GameBoard[2, 1] = ticTacToe.currentplayer;

            ticTacToe.GameBoard[2, 0] = ticTacToe.currentplayer;
            string actual = ticTacToe.Validate();
            Assert.AreEqual(expected.ToString(),
     actual.ToString());
        }

        [TestMethod]

        public void PlayerHasThreeInHorizontalRow()
        {
            TicTacToe ticTacToe = new TicTacToe();
            const string expected = "w";
            ticTacToe.GameBoard[0, 0] = ticTacToe.currentplayer;

            ticTacToe.GameBoard[1, 0] = ticTacToe.currentplayer;

            ticTacToe.GameBoard[2, 0] = ticTacToe.currentplayer;
            string actual = ticTacToe.Validate();
            Assert.AreEqual(expected.ToString(),
     actual.ToString());
        }


        [TestMethod]

        public void PlayerHasThreeInDiagonalRow()
        {
            TicTacToe ticTacToe = new TicTacToe();
            const string expected = "w";
            ticTacToe.GameBoard[0, 0] = ticTacToe.currentplayer;

            ticTacToe.GameBoard[1, 1] = ticTacToe.currentplayer;

            ticTacToe.GameBoard[2, 2] = ticTacToe.currentplayer;
            string actual = ticTacToe.Validate();
            Assert.AreEqual(expected.ToString(),
     actual.ToString());
        }


        [TestMethod]

        public void GameEnding()
        {
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.counter = 9;
            const string expected = "game over";
            string actual = ticTacToe.Validate();

            Assert.AreEqual(expected, actual);


        }
    }
}

     //   public void Winner()
     //   {
     //       TicTacToe ticTacToe = new TicTacToe();
     //       const string expected = "w";
     //       ticTacToe.GameBoard[2, 2] = ticTacToe.currentplayer;

     //       ticTacToe.GameBoard[2, 1] = ticTacToe.currentplayer;

     //       ticTacToe.GameBoard[2, 0] = ticTacToe.currentplayer;
     //       string actual = ticTacToe.();
     //       Assert.AreEqual(expected.ToString(),
     //actual.ToString());

     //   }

