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
      string testSelection = "paper";

      //act
      string player2Selection = newGame.GetPlayer2();

      //assert
      Assert.AreEqual(testSelection, player2Selection);
    }
    [TestMethod]
    public void SetPlayers_SetPlayers_Void()
    {
      //arrange
      Game newGame = new Game("scissors", "paper");
      string testSelection = "rock";

      //act
      newGame.SetPlayers("scissors", testSelection);
      //assert
      Assert.AreEqual(testSelection, newGame.GetPlayer2());
    }

    [TestMethod]
    public void GetWinner_FetchTheWinner_Void()
    {
      //arrange
      Game newGame = new Game("scissors", "paper");
      string testWinner = "paper";

      //act
      string winner = newGame.GetWinner();
      //assert
      Assert.AreEqual(winner, testWinner);
    }

    // [TestMethod]
    // public void SetWinner_CompareRockandScissors_Void()
    // {
    //   //arrange
    //   Game newGame = new Game("rock", "scissors");
    //   string winner = "rock";
    //
    //   //act
    //   newGame.CompareEntries("rock", "scissors");
    //
    //   //assert
    //   Assert.AreEqual(winner, _winner);
    // }
  }
}
