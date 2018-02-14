using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class RPSTest
  {
    [TestMethod]
    public void GetPlayer1_FetchPlayerSelection_String()
    {
      //arrange
      Game newGame = new Game("scissors", "paper");
      string testSelection = "scissors";

      //act
      string player1Selection = newGame.GetPlayer1();

      //assert
      Assert.AreEqual(testSelection, player1Selection);
    }

    [TestMethod]
    public void GetPlayer2_FetchPlayerSelection_String()
    {
      //arrange
      Game newGame = new Game("scissors", "paper");
      string testSelection = "scissors";

      //act
      string player2Selection = newGame.GetPlayer2();

      //assert
      Assert.AreEqual(testSelection, player2Selection);
    }
  }
}